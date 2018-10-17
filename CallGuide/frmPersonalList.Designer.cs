namespace CallGuide
{
    partial class frmPersonalList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonalList));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_time = new System.Windows.Forms.Label();
            this.btn_excel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1050, 427);
            this.dataGridView1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 24);
            this.menuStrip1.TabIndex = 7;
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
            this.firmaKaydıSilToolStripMenuItem.Enabled = false;
            this.firmaKaydıSilToolStripMenuItem.Name = "firmaKaydıSilToolStripMenuItem";
            this.firmaKaydıSilToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.firmaKaydıSilToolStripMenuItem.Text = "Kayıt";
            // 
            // kişiKayıtToolStripMenuItem
            // 
            this.kişiKayıtToolStripMenuItem.Name = "kişiKayıtToolStripMenuItem";
            this.kişiKayıtToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.kişiKayıtToolStripMenuItem.Text = "Kişi Kayıt ";
            // 
            // firmaKayıtToolStripMenuItem
            // 
            this.firmaKayıtToolStripMenuItem.Enabled = false;
            this.firmaKayıtToolStripMenuItem.Name = "firmaKayıtToolStripMenuItem";
            this.firmaKayıtToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.firmaKayıtToolStripMenuItem.Text = "Firma Kayıt";
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
            this.shapeContainer1.Size = new System.Drawing.Size(1050, 488);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -1;
            this.lineShape1.X2 = 1058;
            this.lineShape1.Y1 = 24;
            this.lineShape1.Y2 = 24;
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
            this.lbl_time.Location = new System.Drawing.Point(863, 9);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(35, 13);
            this.lbl_time.TabIndex = 9;
            this.lbl_time.Text = "label1";
            // 
            // btn_excel
            // 
            this.btn_excel.Location = new System.Drawing.Point(955, 36);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(83, 19);
            this.btn_excel.TabIndex = 13;
            this.btn_excel.Text = "Excele Aktar";
            this.btn_excel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 488);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.Text = "Kayıtlar Listesi";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.ToolStripMenuItem yardımıGösterToolStripMenuItem;
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.Label label1;
    }
}