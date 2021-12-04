
namespace PharmacyApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMedicine = new System.Windows.Forms.ComboBox();
            this.cmbTags = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgMedicine = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.medicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.medicineToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.firmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSell = new System.Windows.Forms.Button();
            this.ckSellList = new System.Windows.Forms.CheckedListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nmquantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMedName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicine)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmquantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(12, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "by Medicines";
            // 
            // cmbMedicine
            // 
            this.cmbMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbMedicine.FormattingEnabled = true;
            this.cmbMedicine.Location = new System.Drawing.Point(12, 185);
            this.cmbMedicine.Name = "cmbMedicine";
            this.cmbMedicine.Size = new System.Drawing.Size(249, 36);
            this.cmbMedicine.TabIndex = 1;
            this.cmbMedicine.SelectedIndexChanged += new System.EventHandler(this.cmbMedicine_SelectedIndexChanged);
            this.cmbMedicine.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbMedicine_KeyUp);
            // 
            // cmbTags
            // 
            this.cmbTags.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTags.FormattingEnabled = true;
            this.cmbTags.Location = new System.Drawing.Point(276, 184);
            this.cmbTags.Name = "cmbTags";
            this.cmbTags.Size = new System.Drawing.Size(249, 36);
            this.cmbTags.TabIndex = 3;
            this.cmbTags.SelectedIndexChanged += new System.EventHandler(this.cmbTags_SelectedIndexChanged);
            this.cmbTags.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbTags_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(276, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "by Tags";
            // 
            // dtgMedicine
            // 
            this.dtgMedicine.AllowUserToAddRows = false;
            this.dtgMedicine.AllowUserToDeleteRows = false;
            this.dtgMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMedicine.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedicine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgMedicine.Location = new System.Drawing.Point(0, 383);
            this.dtgMedicine.Name = "dtgMedicine";
            this.dtgMedicine.ReadOnly = true;
            this.dtgMedicine.RowHeadersWidth = 51;
            this.dtgMedicine.RowTemplate.Height = 29;
            this.dtgMedicine.Size = new System.Drawing.Size(1277, 214);
            this.dtgMedicine.TabIndex = 4;
            this.dtgMedicine.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgMedicine_RowHeaderMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicineToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 28);
            // 
            // medicineToolStripMenuItem
            // 
            this.medicineToolStripMenuItem.Name = "medicineToolStripMenuItem";
            this.medicineToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.medicineToolStripMenuItem.Text = "Medicine";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicineToolStripMenuItem1,
            this.firmsToolStripMenuItem,
            this.tagsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1277, 36);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // medicineToolStripMenuItem1
            // 
            this.medicineToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.medicineToolStripMenuItem1.Name = "medicineToolStripMenuItem1";
            this.medicineToolStripMenuItem1.Size = new System.Drawing.Size(113, 32);
            this.medicineToolStripMenuItem1.Text = "Medicine";
            this.medicineToolStripMenuItem1.Click += new System.EventHandler(this.medicineToolStripMenuItem1_Click);
            // 
            // firmsToolStripMenuItem
            // 
            this.firmsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.firmsToolStripMenuItem.Name = "firmsToolStripMenuItem";
            this.firmsToolStripMenuItem.Size = new System.Drawing.Size(77, 32);
            this.firmsToolStripMenuItem.Text = "Firms";
            // 
            // tagsToolStripMenuItem
            // 
            this.tagsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tagsToolStripMenuItem.Name = "tagsToolStripMenuItem";
            this.tagsToolStripMenuItem.Size = new System.Drawing.Size(68, 32);
            this.tagsToolStripMenuItem.Text = "Tags";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnSell);
            this.panel1.Controls.Add(this.ckSellList);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.nmquantity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMedName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(652, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 338);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btnSell.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSell.Location = new System.Drawing.Point(258, 253);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(330, 52);
            this.btnSell.TabIndex = 21;
            this.btnSell.Text = "SELL";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // ckSellList
            // 
            this.ckSellList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckSellList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckSellList.FormattingEnabled = true;
            this.ckSellList.Location = new System.Drawing.Point(258, 49);
            this.ckSellList.Margin = new System.Windows.Forms.Padding(2);
            this.ckSellList.MultiColumn = true;
            this.ckSellList.Name = "ckSellList";
            this.ckSellList.Size = new System.Drawing.Size(330, 178);
            this.ckSellList.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Teal;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(24, 202);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 45);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nmquantity
            // 
            this.nmquantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nmquantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nmquantity.Location = new System.Drawing.Point(24, 128);
            this.nmquantity.Margin = new System.Windows.Forms.Padding(2);
            this.nmquantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmquantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmquantity.Name = "nmquantity";
            this.nmquantity.Size = new System.Drawing.Size(129, 34);
            this.nmquantity.TabIndex = 9;
            this.nmquantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(24, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantity";
            // 
            // txtMedName
            // 
            this.txtMedName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMedName.Enabled = false;
            this.txtMedName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMedName.Location = new System.Drawing.Point(24, 49);
            this.txtMedName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMedName.Name = "txtMedName";
            this.txtMedName.Size = new System.Drawing.Size(209, 34);
            this.txtMedName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(24, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Medicine Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dtgMedicine);
            this.Controls.Add(this.cmbTags);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMedicine);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicine)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmquantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMedicine;
        private System.Windows.Forms.ComboBox cmbTags;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgMedicine;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem medicineToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem medicineToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem firmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nmquantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMedName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.CheckedListBox ckSellList;
    }
}

