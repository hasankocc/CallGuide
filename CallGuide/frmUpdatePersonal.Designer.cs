namespace CallGuide
{
    partial class frmUpdatePersonal
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbSelectFirm = new System.Windows.Forms.ComboBox();
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = global::CallGuide.Properties.Resources.absract_icon;
            this.pictureBox1.Location = new System.Drawing.Point(465, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-170, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "FİRMA SEÇ";
            // 
            // cmbSelectFirm
            // 
            this.cmbSelectFirm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSelectFirm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSelectFirm.DropDownHeight = 80;
            this.cmbSelectFirm.FormattingEnabled = true;
            this.cmbSelectFirm.IntegralHeight = false;
            this.cmbSelectFirm.Location = new System.Drawing.Point(116, 41);
            this.cmbSelectFirm.Name = "cmbSelectFirm";
            this.cmbSelectFirm.Size = new System.Drawing.Size(275, 21);
            this.cmbSelectFirm.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-170, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "ADRES";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(116, 253);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(275, 76);
            this.txtAddress.TabIndex = 37;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(116, 215);
            this.txtMobile.MaxLength = 11;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(275, 20);
            this.txtMobile.TabIndex = 36;
            this.txtMobile.Text = "0";
            this.txtMobile.Enter += new System.EventHandler(this.txtMobile_Enter);
            this.txtMobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMobile_KeyDown);
            this.txtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobile_KeyPress);
            // 
            // txtWorkPhone
            // 
            this.txtWorkPhone.Location = new System.Drawing.Point(116, 183);
            this.txtWorkPhone.MaxLength = 11;
            this.txtWorkPhone.Name = "txtWorkPhone";
            this.txtWorkPhone.Size = new System.Drawing.Size(275, 20);
            this.txtWorkPhone.TabIndex = 34;
            this.txtWorkPhone.Text = "0";
            this.txtWorkPhone.Enter += new System.EventHandler(this.txtWorkPhone_Enter);
            this.txtWorkPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWorkNumber_KeyDown);
            this.txtWorkPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWorkNumber_KeyPress);
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(116, 157);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(275, 20);
            this.txtDepartment.TabIndex = 33;
            // 
            // txtWorkExtension
            // 
            this.txtWorkExtension.Location = new System.Drawing.Point(116, 128);
            this.txtWorkExtension.MaxLength = 11;
            this.txtWorkExtension.Name = "txtWorkExtension";
            this.txtWorkExtension.Size = new System.Drawing.Size(275, 20);
            this.txtWorkExtension.TabIndex = 32;
            this.txtWorkExtension.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWorkExtension_KeyPress);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(116, 99);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(275, 20);
            this.txtSurname.TabIndex = 31;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(275, 20);
            this.txtName.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-170, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "CEP TEL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-170, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "İŞ TEL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-170, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "DAHİLİ NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-170, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "DEPARTMAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-170, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "SOYAD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-170, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "AD";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(291, 363);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 37);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "DÜZELT";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "FİRMA SEÇ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 256);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "ADRES";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 51;
            this.label15.Text = "CEP TEL";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 186);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 50;
            this.label16.Text = "İŞ TEL";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(26, 135);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 49;
            this.label17.Text = "DAHİLİ NO";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 160);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 13);
            this.label18.TabIndex = 48;
            this.label18.Text = "DEPARTMAN";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(26, 102);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 47;
            this.label19.Text = "SOYAD";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(26, 74);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(22, 13);
            this.label20.TabIndex = 46;
            this.label20.Text = "AD";
            // 
            // frmUpdatePersonal
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 485);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbSelectFirm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtWorkPhone);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtWorkExtension);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.MaximizeBox = false;
            this.Name = "frmUpdatePersonal";
            this.Text = "Personel Güncelle";
            this.Load += new System.EventHandler(this.frmUpdatePersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbSelectFirm;
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}