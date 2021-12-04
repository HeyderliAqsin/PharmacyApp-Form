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
    public partial class Form1 : Form
    {
        PharmacyDbContext db = new PharmacyDbContext();
        Medicine SelectedMedicine;
        public Form1()
        {
            InitializeComponent();
        }

        private void medicineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddMedicineForm admf = new();
            admf.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDataMedicine();
            FillMedicineCombo();
            FillTagsCombo();
        }
        private void FillMedicineCombo()
        {
            cmbMedicine.Items.AddRange(db.Medicines.Select(x=>x.Name).ToArray());
        }
        private void FillTagsCombo()
        {
            cmbTags.Items.AddRange(db.Tags.Select(x => x.Name).ToArray());
        }


        private void FillDataMedicine()
         {

            dtgMedicine.DataSource = db.TagToMedicines.
            Where(x=>x.Medicine.Name.Contains(cmbMedicine.Text) && x.Tag.Name.Contains(cmbTags.Text)).Select(md => new
            {
                md.MedicineId,
                medicineName = md.Medicine.Name,
                md.Medicine.Price,
                md.Medicine.Quantity,
                Receipt = md.Medicine.IsReceipt ? "Reseptli" : "Resepsiz",
                FirmName = md.Medicine.Firm.Name,
                productionDate = md.Medicine.ProductDate.ToString("MM/dd/yyyy HH:mm"),
                ExpireDate = md.Medicine.ExpireDate.ToString("MM/dd/yyyy HH:mm")
            }).Distinct().ToList();
            dtgMedicine.Columns[0].Visible = false; 

            for (int i = 0; i < dtgMedicine.RowCount; i++)
            {
               int quant=(int) dtgMedicine.Rows[i].Cells[3].Value;
                if (quant == 0)
                {
                    dtgMedicine.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dtgMedicine.Rows[i].DefaultCellStyle.ForeColor = Color.White;


                }
            }

        }

        private void cmbMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDataMedicine();
        }

        private void cmbMedicine_KeyUp(object sender, KeyEventArgs e)
        {
            FillDataMedicine();
        }

        private void cmbTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDataMedicine();
        }

        private void cmbTags_KeyUp(object sender, KeyEventArgs e)
        {
            FillDataMedicine(); 
        }


        private void dtgMedicine_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int medicineId = (int) dtgMedicine.Rows[e.RowIndex].Cells[0].Value;
           SelectedMedicine = db.Medicines.FirstOrDefault(x => x.MedicineId == medicineId);
            if (SelectedMedicine.Quantity > 0)
            {
                txtMedName.Text = SelectedMedicine.Name;
                panel1.Visible = true;
                nmquantity.Value = 1;
                nmquantity.Maximum = SelectedMedicine.Quantity;
            }   
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String medName = txtMedName.Text;
            int quantity = (int)nmquantity.Value;
            bool isCorrect = false;
            if (ckSellList.Items.Count==0)
            {
              ckSellList.Items.Add(medName + "-" + quantity,true);

            }
            else
            {
                for (var i= 0;i< ckSellList.Items.Count;i++)
                {
                    var item = ckSellList.Items[i];
                    var currenttName = item.ToString().Split('-')[0];

                    if (medName == currenttName)
                    {
                        var quant = Convert.ToInt32(item.ToString().Split('-')[1]);
                        ckSellList.Items.Remove(item);
                        quant += quantity;
                        ckSellList.Items.Add(medName + "-" + quant, true);
                        isCorrect = true;
                    }
                    
                }
                if (!isCorrect)
                {
                   ckSellList.Items.Add(medName + "-" + quantity, true);

                }
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            foreach (var med in ckSellList.Items)
            {

            }
        }
    }
}
