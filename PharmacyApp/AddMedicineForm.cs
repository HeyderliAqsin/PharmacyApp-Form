using PharmacyApp.Helpers;
using PharmacyApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class AddMedicineForm : Form
    {
        private PharmacyDbContext db = new();

        #region Contructor
        public AddMedicineForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Medicinine Load
        private void AddMedicineForm_Load(object sender, EventArgs e)
        {
            FillFirmsCombo();
            FillTagsCombo();
            FillMedicineGridData();
        }
        #endregion

        #region Firms Combo Fill
        private void FillFirmsCombo()
        {
            cmbFirms.Items.AddRange(db.Firms.Select(x => x.Name).ToArray());

        }
        #endregion

        #region Tags Combo Fill
        private void FillTagsCombo()
        {
            cmbTags.Items.AddRange(db.Tags.Select(x => x.Name).ToArray());

        }
        #endregion

        private void FillMedicineGridData()
        {
            dtgMedicineLIst.DataSource = db.Medicines.Select(md => new
            {
                medicineName = md.Name,
                md.Price,
                md.Quantity,
                Receipt = md.IsReceipt ? "Reseptli" : "Resepsiz",
                FirmName=md.Firm.Name,
                productionDate=md.ProductDate.ToString("MM/dd/yyyy HH:mm"),
                ExpireDate=md.ExpireDate.ToString("MM/dd/yyyy HH:mm")
            }).ToList();
            for (int i= 0;i<dtgMedicineLIst.RowCount;i++)
            {
                if (dtgMedicineLIst.Rows[i].Index % 2 == 0)
                {
                    dtgMedicineLIst.Rows[i].DefaultCellStyle.BackColor=Color.Teal;
                    dtgMedicineLIst.Rows[i].DefaultCellStyle.ForeColor = Color.White;

                }

            }
        }

        public int FindFirmId(string firmName)
        {
            Firm currentFirm = db.Firms.FirstOrDefault(x => x.Name == firmName);
            if (currentFirm == null)
            {
                Firm newFirm = new()
                {
                    Name = firmName

                };
                db.Firms.Add(newFirm);
                db.SaveChanges();
                return newFirm.FirmId;
            }
            return currentFirm.FirmId;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string medicineName = txtMedName.Text;
            decimal Price = nmPrice.Value;
            decimal quantity = nmquantity.Value;
            string desc = rcDescription.Text;
            string tagName = cmbTags.Text;
            string firms = cmbFirms.Text;
            string barcode = txtbarcode.Text;
            DateTime prodate = dtProduceDate.Value;
            DateTime exdate = dtgexpiredate.Value;
            bool isRes = ckReceipt.Checked;
            string[] medString = new string[] { medicineName, desc, firms,barcode};
                
            if (Utilities.IsEmpty(medString) )
            {
                if (prodate < exdate)
                {
                
                    if (Price != 0)
                    {
                        int firmId = FindFirmId(firms);
                        Medicine newMed = new()
                        {
                            Name = medicineName,
                            Price = Price,
                            Quantity = (int)quantity,
                            Description = desc,
                            ProductDate = prodate,
                            ExpireDate = exdate,
                            FirmId = firmId,
                            IsReceipt = isRes ? true : false,
                            Barcode = barcode

                        };
                        db.Medicines.Add(newMed);
                        db.SaveChanges();
                        AddTagMedicine(newMed.MedicineId);
                        MessageBox.Show("Medicines added successfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearDataForm();
                        FillMedicineGridData();

                    }
                    else
                    {
                        MessageBox.Show("Please write price", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Date isn`t correct", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("PLEASE FILL ALL THE REQUIRED FIELDS", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private int HasTag(string tagname)
        {
            Tag selectedTag = db.Tags.FirstOrDefault(x => x.Name == tagname);
            if (selectedTag == null)
            {
                Tag newtag = new Tag()
                {
                    Name = tagname
                };
                db.Tags.Add(newtag);
                db.SaveChanges();
                return newtag.TagId;
            }
            return selectedTag.TagId;
        }

        private bool CheckTagname(string tg)
        {
           Tag tag= db.Tags.FirstOrDefault(x => x.Name == tg);
            if (tag == null)
            {
                return false;
            }
            return true;
        }
        private void AddTagMedicine(int medicineId)
        {
            for(var i = 0; i < ckTagList.Items.Count;i++)
            {
                string tagName=ckTagList.Items[i].ToString();
                int tagID;
                if (CheckTagname(tagName))
                {
                    tagID = db.Tags.First(x => x.Name == tagName).TagId;
                }
                else
                {
                    Tag tag =  new ()
                    {
                        Name = tagName
                    };
                    db.SaveChanges();
                    tagID = tag.TagId;
                }

                db.TagToMedicines.Add(new TagToMedicine
                {
                    MedicineId=medicineId,
                    TagId=tagID

                });
                db.SaveChanges();
            }
        }

        private void cmbTags_KeyUp(object sender, KeyEventArgs e)
        {
            string tagname = cmbTags.Text;
            if (e.KeyCode == Keys.Enter)
            {
                AddTagItem();
            }
        }

      private void AddTagItem()
        {
            string tagName = cmbTags.Text;
            if (!ckTagList.Items.Contains(tagName) && !string.IsNullOrWhiteSpace(tagName))
            {
                ckTagList.Items.Add(tagName,true);

            }
        }

        private void txtbarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar<48 || e.KeyChar>57 || txtbarcode.TextLength > 11) && e.KeyChar!=8 )
            {
                e.Handled = true;
            }
        }

        private void cmbTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddTagItem();
        }
        private void ClearDataForm()
        {
            foreach (Control item in this.Controls)
            {
                if(item is TextBox || item is ComboBox || item is RichTextBox)
                {
                    item.Text = "";
                }else if(item is NumericUpDown)
                {
                    NumericUpDown nm = (NumericUpDown)item;
                    nm.Value = 1;
                }else if (item is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)item;
                    dt.Value = DateTime.Now;
                }else if(item is CheckedListBox)
                {
                    CheckedListBox ck = (CheckedListBox)item;
                    ck.Items.Clear();
                }else if(item is CheckBox)
                {
                    CheckBox ch = (CheckBox)item;
                    ch.Checked = false;
                }
              
            }
        }
        private void ckTagList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = ckTagList.SelectedIndex;
            if (selected != -1)
            {
                ckTagList.Items.RemoveAt(selected);
            }
        }

        private void txtbarcode_TextChanged(object sender, EventArgs e)
        {
            Barcode br = new Barcode();
            br.ShowDialog();

        }
    }
}
