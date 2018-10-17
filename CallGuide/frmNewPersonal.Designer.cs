namespace CallGuide
{
    partial class frmNewPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewPersonal));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kişiKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hariciFirmalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatAltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımıGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_time = new System.Windows.Forms.Label();
            this.tbpDelUpd = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbSelectFirm = new System.Windows.Forms.ComboBox();
            this.cmbFindPersonal = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvPersonal = new System.Windows.Forms.DataGridView();
            this.label21 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbpIns = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbFirm = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtWorkPhone = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtWorkExtension = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbcInsDelUpd = new System.Windows.Forms.TabControl();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.msMenu.SuspendLayout();
            this.tbpDelUpd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).BeginInit();
            this.tbpIns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbcInsDelUpd.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenu,
            this.tsmHelp});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(959, 24);
            this.msMenu.TabIndex = 4;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmMenu
            // 
            this.tsmMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaKaydıToolStripMenuItem,
            this.firmalarToolStripMenuItem,
            this.hariciFirmalarToolStripMenuItem,
            this.kapatAltF4ToolStripMenuItem});
            this.tsmMenu.Name = "tsmMenu";
            this.tsmMenu.Size = new System.Drawing.Size(50, 20);
            this.tsmMenu.Text = "Menu";
            // 
            // firmaKaydıToolStripMenuItem
            // 
            this.firmaKaydıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kişiKayıtToolStripMenuItem,
            this.firmaKayıtToolStripMenuItem});
            this.firmaKaydıToolStripMenuItem.Name = "firmaKaydıToolStripMenuItem";
            this.firmaKaydıToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.firmaKaydıToolStripMenuItem.Text = "Firma Kaydı";
            // 
            // kişiKayıtToolStripMenuItem
            // 
            this.kişiKayıtToolStripMenuItem.Enabled = false;
            this.kişiKayıtToolStripMenuItem.Name = "kişiKayıtToolStripMenuItem";
            this.kişiKayıtToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.kişiKayıtToolStripMenuItem.Text = "Kişi Kayıt";
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
            this.firmalarToolStripMenuItem.Enabled = false;
            this.firmalarToolStripMenuItem.Name = "firmalarToolStripMenuItem";
            this.firmalarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.firmalarToolStripMenuItem.Text = "Dahili Firmalar";
            this.firmalarToolStripMenuItem.Click += new System.EventHandler(this.firmalarToolStripMenuItem_Click);
            // 
            // hariciFirmalarToolStripMenuItem
            // 
            this.hariciFirmalarToolStripMenuItem.Enabled = false;
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
            this.kapatAltF4ToolStripMenuItem.Click += new System.EventHandler(this.kapatAltF4ToolStripMenuItem_Click_1);
            // 
            // tsmHelp
            // 
            this.tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yardımıGösterToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(56, 20);
            this.tsmHelp.Text = "Yardım";
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
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(959, 500);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -1;
            this.lineShape2.X2 = 965;
            this.lineShape2.Y1 = 24;
            this.lineShape2.Y2 = 24;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.lineShape1.BorderWidth = 5;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 1;
            this.lineShape1.X2 = 784;
            this.lineShape1.Y1 = 20;
            this.lineShape1.Y2 = 20;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_time.Location = new System.Drawing.Point(797, 8);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(35, 13);
            this.lbl_time.TabIndex = 7;
            this.lbl_time.Text = "label1";
            // 
            // tbpDelUpd
            // 
            this.tbpDelUpd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbpDelUpd.Controls.Add(this.btnRefresh);
            this.tbpDelUpd.Controls.Add(this.label13);
            this.tbpDelUpd.Controls.Add(this.cmbSelectFirm);
            this.tbpDelUpd.Controls.Add(this.cmbFindPersonal);
            this.tbpDelUpd.Controls.Add(this.btnDelete);
            this.tbpDelUpd.Controls.Add(this.dgvPersonal);
            this.tbpDelUpd.Controls.Add(this.label21);
            this.tbpDelUpd.Controls.Add(this.btnSearch);
            this.tbpDelUpd.Location = new System.Drawing.Point(4, 26);
            this.tbpDelUpd.Name = "tbpDelUpd";
            this.tbpDelUpd.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDelUpd.Size = new System.Drawing.Size(951, 443);
            this.tbpDelUpd.TabIndex = 2;
            this.tbpDelUpd.Text = "Sil & Düzelt";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(47, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "FİRMA SEÇ";
            // 
            // cmbSelectFirm
            // 
            this.cmbSelectFirm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSelectFirm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSelectFirm.DropDownHeight = 86;
            this.cmbSelectFirm.FormattingEnabled = true;
            this.cmbSelectFirm.IntegralHeight = false;
            this.cmbSelectFirm.Location = new System.Drawing.Point(123, 27);
            this.cmbSelectFirm.Name = "cmbSelectFirm";
            this.cmbSelectFirm.Size = new System.Drawing.Size(487, 21);
            this.cmbSelectFirm.TabIndex = 25;
            this.cmbSelectFirm.SelectedIndexChanged += new System.EventHandler(this.cmbFirmaSec_SelectedIndexChanged);
            // 
            // cmbFindPersonal
            // 
            this.cmbFindPersonal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFindPersonal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFindPersonal.DropDownHeight = 86;
            this.cmbFindPersonal.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbFindPersonal.FormattingEnabled = true;
            this.cmbFindPersonal.IntegralHeight = false;
            this.cmbFindPersonal.Location = new System.Drawing.Point(123, 54);
            this.cmbFindPersonal.Name = "cmbFindPersonal";
            this.cmbFindPersonal.Size = new System.Drawing.Size(455, 21);
            this.cmbFindPersonal.TabIndex = 24;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(645, 27);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 48);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "SİL";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvPersonal
            // 
            this.dgvPersonal.AllowUserToAddRows = false;
            this.dgvPersonal.AllowUserToDeleteRows = false;
            this.dgvPersonal.AllowUserToOrderColumns = true;
            this.dgvPersonal.AllowUserToResizeRows = false;
            this.dgvPersonal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonal.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPersonal.Location = new System.Drawing.Point(3, 92);
            this.dgvPersonal.MultiSelect = false;
            this.dgvPersonal.Name = "dgvPersonal";
            this.dgvPersonal.ReadOnly = true;
            this.dgvPersonal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonal.Size = new System.Drawing.Size(945, 348);
            this.dgvPersonal.TabIndex = 21;
            this.dgvPersonal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonal_CellDoubleClick);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(47, 57);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 13);
            this.label21.TabIndex = 18;
            this.label21.Text = "KAYIT BUL";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.BackgroundImage = global::CallGuide.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(584, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(26, 21);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbpIns
            // 
            this.tbpIns.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbpIns.Controls.Add(this.label14);
            this.tbpIns.Controls.Add(this.pictureBox1);
            this.tbpIns.Controls.Add(this.label12);
            this.tbpIns.Controls.Add(this.label11);
            this.tbpIns.Controls.Add(this.cmbFirm);
            this.tbpIns.Controls.Add(this.label10);
            this.tbpIns.Controls.Add(this.label9);
            this.tbpIns.Controls.Add(this.label8);
            this.tbpIns.Controls.Add(this.label7);
            this.tbpIns.Controls.Add(this.txtAddress);
            this.tbpIns.Controls.Add(this.txtMobile);
            this.tbpIns.Controls.Add(this.txtWorkPhone);
            this.tbpIns.Controls.Add(this.txtDepartment);
            this.tbpIns.Controls.Add(this.txtWorkExtension);
            this.tbpIns.Controls.Add(this.txtSurname);
            this.tbpIns.Controls.Add(this.txtName);
            this.tbpIns.Controls.Add(this.label6);
            this.tbpIns.Controls.Add(this.label5);
            this.tbpIns.Controls.Add(this.label4);
            this.tbpIns.Controls.Add(this.label3);
            this.tbpIns.Controls.Add(this.label2);
            this.tbpIns.Controls.Add(this.label1);
            this.tbpIns.Controls.Add(this.btnSave);
            this.tbpIns.Location = new System.Drawing.Point(4, 26);
            this.tbpIns.Name = "tbpIns";
            this.tbpIns.Padding = new System.Windows.Forms.Padding(3);
            this.tbpIns.Size = new System.Drawing.Size(951, 443);
            this.tbpIns.TabIndex = 0;
            this.tbpIns.Text = "Yeni Kayıt";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(480, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "*Doldurulması zorunlu alan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = global::CallGuide.Properties.Resources.absract_icon;
            this.pictureBox1.Location = new System.Drawing.Point(674, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 325);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(480, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "*Doldurulması zorunlu alan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(68, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "FİRMA SEÇ";
            // 
            // cmbFirm
            // 
            this.cmbFirm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFirm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFirm.DropDownHeight = 80;
            this.cmbFirm.FormattingEnabled = true;
            this.cmbFirm.IntegralHeight = false;
            this.cmbFirm.Location = new System.Drawing.Point(167, 41);
            this.cmbFirm.Name = "cmbFirm";
            this.cmbFirm.Size = new System.Drawing.Size(275, 21);
            this.cmbFirm.TabIndex = 20;
            this.cmbFirm.SelectedIndexChanged += new System.EventHandler(this.f2firm_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(480, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "*Doldurulması zorunlu alan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(480, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "*Doldurulması zorunlu alan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(480, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "*Doldurulması zorunlu alan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ADRES";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(167, 253);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(275, 76);
            this.txtAddress.TabIndex = 13;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(167, 215);
            this.txtMobile.MaxLength = 11;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(275, 20);
            this.txtMobile.TabIndex = 12;
            this.txtMobile.Text = "0";
            this.txtMobile.Enter += new System.EventHandler(this.txtMobile_Enter);
            this.txtMobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMobile_KeyDown);
            this.txtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f1ceptel_KeyPress);
            // 
            // txtWorkPhone
            // 
            this.txtWorkPhone.Location = new System.Drawing.Point(167, 183);
            this.txtWorkPhone.MaxLength = 11;
            this.txtWorkPhone.Name = "txtWorkPhone";
            this.txtWorkPhone.Size = new System.Drawing.Size(275, 20);
            this.txtWorkPhone.TabIndex = 10;
            this.txtWorkPhone.Text = "0";
            this.txtWorkPhone.Enter += new System.EventHandler(this.txtWorkPhone_Enter);
            this.txtWorkPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWorkPhone_KeyDown);
            this.txtWorkPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f1istel_KeyPress);
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(167, 157);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(275, 20);
            this.txtDepartment.TabIndex = 9;
            // 
            // txtWorkExtension
            // 
            this.txtWorkExtension.Location = new System.Drawing.Point(167, 128);
            this.txtWorkExtension.MaxLength = 11;
            this.txtWorkExtension.Name = "txtWorkExtension";
            this.txtWorkExtension.Size = new System.Drawing.Size(275, 20);
            this.txtWorkExtension.TabIndex = 8;
            this.txtWorkExtension.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f1dahilino_KeyPress);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(167, 99);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(275, 20);
            this.txtSurname.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(167, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(275, 20);
            this.txtName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "CEP TEL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "İŞ TEL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "DAHİLİ NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "DEPARTMAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SOYAD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "AD";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(342, 363);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 37);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "KAYDET";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbcInsDelUpd
            // 
            this.tbcInsDelUpd.Controls.Add(this.tbpIns);
            this.tbcInsDelUpd.Controls.Add(this.tbpDelUpd);
            this.tbcInsDelUpd.Location = new System.Drawing.Point(0, 27);
            this.tbcInsDelUpd.Name = "tbcInsDelUpd";
            this.tbcInsDelUpd.Padding = new System.Drawing.Point(9, 5);
            this.tbcInsDelUpd.SelectedIndex = 0;
            this.tbcInsDelUpd.Size = new System.Drawing.Size(959, 473);
            this.tbcInsDelUpd.TabIndex = 8;
            this.tbcInsDelUpd.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(753, 27);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 48);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "YENİLE";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmNewPersonal
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(959, 500);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.tbcInsDelUpd);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.MaximizeBox = false;
            this.Name = "frmNewPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kişi Kayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.tbpDelUpd.ResumeLayout(false);
            this.tbpDelUpd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).EndInit();
            this.tbpIns.ResumeLayout(false);
            this.tbpIns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbcInsDelUpd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmMenu;
        private System.Windows.Forms.ToolStripMenuItem firmalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.ToolStripMenuItem hariciFirmalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatAltF4ToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.ToolStripMenuItem firmaKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kişiKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaKayıtToolStripMenuItem;
        private System.Windows.Forms.TabPage tbpDelUpd;
        private System.Windows.Forms.ComboBox cmbFindPersonal;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvPersonal;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabPage tbpIns;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbFirm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtWorkPhone;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtWorkExtension;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tbcInsDelUpd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbSelectFirm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem yardımıGösterToolStripMenuItem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnRefresh;
    }
}

