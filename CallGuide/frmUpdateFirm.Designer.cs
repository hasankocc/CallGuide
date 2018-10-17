namespace CallGuide
{
    partial class frmUpdateFirm
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
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbSelectFirmType = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFirmTitle = new System.Windows.Forms.TextBox();
            this.txtFirmName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 71;
            this.label13.Text = "FİRMA TİPİ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 70;
            this.label14.Text = "ADRES";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(33, 114);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 13);
            this.label19.TabIndex = 65;
            this.label19.Text = "ÜNVAN";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(33, 78);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 13);
            this.label20.TabIndex = 64;
            this.label20.Text = "FİRMA İSMİ";
            // 
            // cmbSelectFirmType
            // 
            this.cmbSelectFirmType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSelectFirmType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSelectFirmType.DropDownHeight = 80;
            this.cmbSelectFirmType.FormattingEnabled = true;
            this.cmbSelectFirmType.IntegralHeight = false;
            this.cmbSelectFirmType.Items.AddRange(new object[] {
            "Dahili",
            "Harici"});
            this.cmbSelectFirmType.Location = new System.Drawing.Point(123, 40);
            this.cmbSelectFirmType.Name = "cmbSelectFirmType";
            this.cmbSelectFirmType.Size = new System.Drawing.Size(275, 21);
            this.cmbSelectFirmType.TabIndex = 62;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(123, 193);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(275, 76);
            this.txtAddress.TabIndex = 61;
            // 
            // txtFirmTitle
            // 
            this.txtFirmTitle.Location = new System.Drawing.Point(123, 111);
            this.txtFirmTitle.Name = "txtFirmTitle";
            this.txtFirmTitle.Size = new System.Drawing.Size(275, 20);
            this.txtFirmTitle.TabIndex = 56;
            // 
            // txtFirmName
            // 
            this.txtFirmName.Location = new System.Drawing.Point(123, 75);
            this.txtFirmName.Name = "txtFirmName";
            this.txtFirmName.Size = new System.Drawing.Size(275, 20);
            this.txtFirmName.TabIndex = 55;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(298, 302);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 37);
            this.btnUpdate.TabIndex = 54;
            this.btnUpdate.Text = "DÜZELT";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = global::CallGuide.Properties.Resources.absract_icon;
            this.pictureBox1.Location = new System.Drawing.Point(458, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // frmUpdateFirm
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 392);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbSelectFirmType);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFirmTitle);
            this.Controls.Add(this.txtFirmName);
            this.Controls.Add(this.btnUpdate);
            this.MaximizeBox = false;
            this.Name = "frmUpdateFirm";
            this.Text = "frmUpdateFirm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbSelectFirmType;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFirmTitle;
        private System.Windows.Forms.TextBox txtFirmName;
        private System.Windows.Forms.Button btnUpdate;

    }
}