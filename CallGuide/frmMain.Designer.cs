namespace CallGuide
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anaEkranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaKaydıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kişiKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hariciFirmalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatAltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımıGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbl_time1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.dgvFirm = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbSelectFirm = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbAdSoyad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbInternalFirm = new System.Windows.Forms.RadioButton();
            this.rdbExternalFirm = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtUnvan = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirm)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(731, 387);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -1;
            this.lineShape1.X2 = 735;
            this.lineShape1.Y1 = 24;
            this.lineShape1.Y2 = 24;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaEkranToolStripMenuItem,
            this.firmaKaydıSilToolStripMenuItem,
            this.firmalarToolStripMenuItem,
            this.hariciFirmalarToolStripMenuItem,
            this.kapatAltF4ToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // anaEkranToolStripMenuItem
            // 
            this.anaEkranToolStripMenuItem.Name = "anaEkranToolStripMenuItem";
            this.anaEkranToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.anaEkranToolStripMenuItem.Text = "Ana Ekran";
            this.anaEkranToolStripMenuItem.Click += new System.EventHandler(this.anaEkranToolStripMenuItem_Click);
            // 
            // firmaKaydıSilToolStripMenuItem
            // 
            this.firmaKaydıSilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kişiKayıtToolStripMenuItem,
            this.firmaKayıtToolStripMenuItem});
            this.firmaKaydıSilToolStripMenuItem.Name = "firmaKaydıSilToolStripMenuItem";
            this.firmaKaydıSilToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.firmaKaydıSilToolStripMenuItem.Text = "Kayıt";
            // 
            // kişiKayıtToolStripMenuItem
            // 
            this.kişiKayıtToolStripMenuItem.Name = "kişiKayıtToolStripMenuItem";
            this.kişiKayıtToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.kişiKayıtToolStripMenuItem.Text = "Kişi Kayıt ";
            this.kişiKayıtToolStripMenuItem.Click += new System.EventHandler(this.kişiKayıtToolStripMenuItem_Click);
            // 
            // firmaKayıtToolStripMenuItem
            // 
            this.firmaKayıtToolStripMenuItem.Name = "firmaKayıtToolStripMenuItem";
            this.firmaKayıtToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.firmaKayıtToolStripMenuItem.Text = "Kayıtlı Firma İşlemleri";
            this.firmaKayıtToolStripMenuItem.Click += new System.EventHandler(this.firmaKayıtToolStripMenuItem_Click);
            // 
            // firmalarToolStripMenuItem
            // 
            this.firmalarToolStripMenuItem.Name = "firmalarToolStripMenuItem";
            this.firmalarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.firmalarToolStripMenuItem.Text = "Dahili Firmalar";
            this.firmalarToolStripMenuItem.Click += new System.EventHandler(this.firmalarToolStripMenuItem_Click);
            // 
            // hariciFirmalarToolStripMenuItem
            // 
            this.hariciFirmalarToolStripMenuItem.Name = "hariciFirmalarToolStripMenuItem";
            this.hariciFirmalarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.hariciFirmalarToolStripMenuItem.Text = "Harici Firmalar";
            this.hariciFirmalarToolStripMenuItem.Click += new System.EventHandler(this.hariciFirmalarToolStripMenuItem_Click);
            // 
            // kapatAltF4ToolStripMenuItem
            // 
            this.kapatAltF4ToolStripMenuItem.Name = "kapatAltF4ToolStripMenuItem";
            this.kapatAltF4ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.kapatAltF4ToolStripMenuItem.Text = "Kapat    Alt + F4";
            this.kapatAltF4ToolStripMenuItem.Click += new System.EventHandler(this.kapatAltF4ToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yardımıGösterToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // yardımıGösterToolStripMenuItem
            // 
            this.yardımıGösterToolStripMenuItem.Name = "yardımıGösterToolStripMenuItem";
            this.yardımıGösterToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.yardımıGösterToolStripMenuItem.Text = "Yardımı Göster";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lbl_time1
            // 
            this.lbl_time1.AutoSize = true;
            this.lbl_time1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_time1.Location = new System.Drawing.Point(556, 9);
            this.lbl_time1.Name = "lbl_time1";
            this.lbl_time1.Size = new System.Drawing.Size(35, 13);
            this.lbl_time1.TabIndex = 8;
            this.lbl_time1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "©  2015  Programmed By Hasan Koç";
            // 
            // dgvFirm
            // 
            this.dgvFirm.AllowUserToAddRows = false;
            this.dgvFirm.AllowUserToDeleteRows = false;
            this.dgvFirm.AllowUserToResizeColumns = false;
            this.dgvFirm.AllowUserToResizeRows = false;
            this.dgvFirm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFirm.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvFirm.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFirm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFirm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFirm.EnableHeadersVisualStyles = false;
            this.dgvFirm.Location = new System.Drawing.Point(48, 52);
            this.dgvFirm.MultiSelect = false;
            this.dgvFirm.Name = "dgvFirm";
            this.dgvFirm.ReadOnly = true;
            this.dgvFirm.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFirm.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFirm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFirm.Size = new System.Drawing.Size(331, 286);
            this.dgvFirm.TabIndex = 22;
            this.dgvFirm.Visible = false;
            this.dgvFirm.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFirm_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cmbSelectFirm);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.cmbAdSoyad);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(33, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 76);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hızlı Arama";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Firma Seç";
            // 
            // cmbSelectFirm
            // 
            this.cmbSelectFirm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSelectFirm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSelectFirm.DisplayMember = "Seçiniz";
            this.cmbSelectFirm.DropDownHeight = 70;
            this.cmbSelectFirm.FormattingEnabled = true;
            this.cmbSelectFirm.IntegralHeight = false;
            this.cmbSelectFirm.Location = new System.Drawing.Point(79, 26);
            this.cmbSelectFirm.Name = "cmbSelectFirm";
            this.cmbSelectFirm.Size = new System.Drawing.Size(294, 21);
            this.cmbSelectFirm.TabIndex = 24;
            this.cmbSelectFirm.SelectedIndexChanged += new System.EventHandler(this.f1firm_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.BackgroundImage = global::CallGuide.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(347, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(26, 21);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbAdSoyad
            // 
            this.cmbAdSoyad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAdSoyad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAdSoyad.DropDownHeight = 100;
            this.cmbAdSoyad.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cmbAdSoyad.FormattingEnabled = true;
            this.cmbAdSoyad.IntegralHeight = false;
            this.cmbAdSoyad.Location = new System.Drawing.Point(79, 51);
            this.cmbAdSoyad.Name = "cmbAdSoyad";
            this.cmbAdSoyad.Size = new System.Drawing.Size(270, 21);
            this.cmbAdSoyad.TabIndex = 23;
            this.cmbAdSoyad.SelectedIndexChanged += new System.EventHandler(this.f2arama_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ad ve Soyad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtUnvan);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 217);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Firma Kayıt";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbInternalFirm);
            this.groupBox2.Controls.Add(this.rdbExternalFirm);
            this.groupBox2.Location = new System.Drawing.Point(6, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 32);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // rdbInternalFirm
            // 
            this.rdbInternalFirm.AutoSize = true;
            this.rdbInternalFirm.Location = new System.Drawing.Point(14, 9);
            this.rdbInternalFirm.Name = "rdbInternalFirm";
            this.rdbInternalFirm.Size = new System.Drawing.Size(79, 17);
            this.rdbInternalFirm.TabIndex = 19;
            this.rdbInternalFirm.TabStop = true;
            this.rdbInternalFirm.Text = "Dahili Firma";
            this.rdbInternalFirm.UseVisualStyleBackColor = true;
            // 
            // rdbExternalFirm
            // 
            this.rdbExternalFirm.AutoSize = true;
            this.rdbExternalFirm.Location = new System.Drawing.Point(126, 9);
            this.rdbExternalFirm.Name = "rdbExternalFirm";
            this.rdbExternalFirm.Size = new System.Drawing.Size(80, 17);
            this.rdbExternalFirm.TabIndex = 20;
            this.rdbExternalFirm.TabStop = true;
            this.rdbExternalFirm.Text = "Harici Firma";
            this.rdbExternalFirm.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(256, 185);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(62, 99);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(312, 74);
            this.txtAddress.TabIndex = 5;
            // 
            // txtUnvan
            // 
            this.txtUnvan.Location = new System.Drawing.Point(62, 61);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Size = new System.Drawing.Size(312, 20);
            this.txtUnvan.TabIndex = 4;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(62, 35);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(312, 20);
            this.txtAd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ünvan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::CallGuide.Properties.Resources.telefon_rehberi_21;
            this.pictureBox1.Location = new System.Drawing.Point(457, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 387);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvFirm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_time1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Call Guide";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirm)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hariciFirmalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatAltF4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbl_time1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem firmaKaydıSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kişiKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anaEkranToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvFirm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbSelectFirm;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbAdSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbInternalFirm;
        private System.Windows.Forms.RadioButton rdbExternalFirm;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtUnvan;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem yardımıGösterToolStripMenuItem;
    }
}