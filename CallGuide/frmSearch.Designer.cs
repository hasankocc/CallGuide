namespace CallGuide
{
    partial class frmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hariciFirmalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatAltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımıGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSearchResult = new System.Windows.Forms.DataGridView();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_time = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(847, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtToolStripMenuItem,
            this.firmalarToolStripMenuItem,
            this.hariciFirmalarToolStripMenuItem,
            this.kapatAltF4ToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // kayıtToolStripMenuItem
            // 
            this.kayıtToolStripMenuItem.Enabled = false;
            this.kayıtToolStripMenuItem.Name = "kayıtToolStripMenuItem";
            this.kayıtToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.kayıtToolStripMenuItem.Text = "Kayıt";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Arama Sonuçları";
            // 
            // dgvSearchResult
            // 
            this.dgvSearchResult.AllowUserToAddRows = false;
            this.dgvSearchResult.AllowUserToDeleteRows = false;
            this.dgvSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchResult.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSearchResult.Location = new System.Drawing.Point(0, 74);
            this.dgvSearchResult.MultiSelect = false;
            this.dgvSearchResult.Name = "dgvSearchResult";
            this.dgvSearchResult.ReadOnly = true;
            this.dgvSearchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchResult.Size = new System.Drawing.Size(847, 632);
            this.dgvSearchResult.TabIndex = 8;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(847, 706);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -2;
            this.lineShape1.X2 = 844;
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
            this.lbl_time.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_time.Location = new System.Drawing.Point(635, 9);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(35, 13);
            this.lbl_time.TabIndex = 10;
            this.lbl_time.Text = "label2";
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(737, 49);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(83, 19);
            this.btnExcel.TabIndex = 12;
            this.btnExcel.Text = "Excele Aktar";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 706);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.dgvSearchResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arama Sonuçları";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hariciFirmalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatAltF4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSearchResult;
        private System.Windows.Forms.ToolStripMenuItem kayıtToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.ToolStripMenuItem yardımıGösterToolStripMenuItem;
        private System.Windows.Forms.Button btnExcel;
    }
}