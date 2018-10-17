namespace CallGuide
{
    partial class frmNewFirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewFirm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaKaydıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kişiKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hariciFirmalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatAltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımıGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvFirm = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirm)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaKaydıSilToolStripMenuItem,
            this.firmalarToolStripMenuItem,
            this.hariciFirmalarToolStripMenuItem,
            this.kapatAltF4ToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
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
            this.firmaKayıtToolStripMenuItem.Enabled = false;
            this.firmaKayıtToolStripMenuItem.Name = "firmaKayıtToolStripMenuItem";
            this.firmaKayıtToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.firmaKayıtToolStripMenuItem.Text = "Kayıtlı Firma İşlemleri";
            // 
            // firmalarToolStripMenuItem
            // 
            this.firmalarToolStripMenuItem.Enabled = false;
            this.firmalarToolStripMenuItem.Name = "firmalarToolStripMenuItem";
            this.firmalarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.firmalarToolStripMenuItem.Text = "Dahili Firmalar";
            // 
            // hariciFirmalarToolStripMenuItem
            // 
            this.hariciFirmalarToolStripMenuItem.Enabled = false;
            this.hariciFirmalarToolStripMenuItem.Name = "hariciFirmalarToolStripMenuItem";
            this.hariciFirmalarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.hariciFirmalarToolStripMenuItem.Text = "Harici Firmalar";
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
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(800, 460);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -3;
            this.lineShape1.X2 = 809;
            this.lineShape1.Y1 = 24;
            this.lineShape1.Y2 = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.dgvFirm);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sil & Düzelt";
            // 
            // dgvFirm
            // 
            this.dgvFirm.AllowUserToAddRows = false;
            this.dgvFirm.AllowUserToDeleteRows = false;
            this.dgvFirm.AllowUserToResizeRows = false;
            this.dgvFirm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFirm.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvFirm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFirm.Location = new System.Drawing.Point(-4, 0);
            this.dgvFirm.MultiSelect = false;
            this.dgvFirm.Name = "dgvFirm";
            this.dgvFirm.ReadOnly = true;
            this.dgvFirm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFirm.ShowEditingIcon = false;
            this.dgvFirm.Size = new System.Drawing.Size(599, 410);
            this.dgvFirm.TabIndex = 22;
            this.dgvFirm.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFirmList_CellDoubleClick);
            this.dgvFirm.MouseEnter += new System.EventHandler(this.dgvFirmList_MouseEnter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(619, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 53);
            this.button3.TabIndex = 27;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 436);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // frmNewFirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmNewFirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firma Kayıt";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirm)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hariciFirmalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaKaydıSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kişiKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatAltF4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.ToolStripMenuItem yardımıGösterToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvFirm;
        private System.Windows.Forms.TabControl tabControl1;
    }
}