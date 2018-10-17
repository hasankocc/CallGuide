using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessLayer.DTO;

namespace CallGuide
{
    public partial class frmNewPersonal : Form
    {  

        SqlConnection conn = new SqlConnection(DBHelper.connection);
        SqlDataAdapter adp = null;
        SqlCommand cmd = null;
        DataSet set = DBHelper.GetDBAdapter();
        string sql = "";
        public static string FirmName = "";

        private void loadPersonalData() //Datagrid'i doldurur.
        {
            sql = @"SELECT ID ,NAME AS AD
                              ,SURNAME AS SOYAD 
                              ,WORK_EXTENSION AS [DAHİLİ NO]  
                              ,DEPARTMENT AS DEPARTMAN 
                              ,WORK_PHONE AS [İŞ TELEFONU] 
                              ,MOBILE AS GSM
                              ,ADDRESS AS ADRES
                              ,FIRM_NAME AS FİRMA 
                              FROM PERSONAL";
            adp = new SqlDataAdapter(sql, conn);
            
            if (conn.State == ConnectionState.Open)
                conn.Close();

            conn.Open();
            set.Clear();
            adp.Fill(set, "PERSONAL");
            dgvPersonal.DataSource = set.Tables["PERSONAL"];
            dgvPersonal.Columns["ID"].Visible = false;
            set.Tables.Remove("PERSONAL");
            adp.Dispose();
            conn.Close();
        }

        private void loadPersonalName() //Kayıt Bul cmb doldurur.
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            sql = "SELECT NAME + ' ' + SURNAME AS ADI FROM PERSONAL WHERE FIRM_NAME LIKE '%" + cmbSelectFirm.Text + "%'";
            adp = new SqlDataAdapter(sql, conn);
            adp.Fill(set, "PERSONAL");
            cmbFindPersonal.DataSource = set.Tables["PERSONAL"];
            cmbFindPersonal.DisplayMember = "ADI";
            set.Tables.Remove("PERSONAL");
            adp.Dispose();
            conn.Close();
        }

        public void sifirla() 
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtWorkPhone.Text = "";
            txtDepartment.Text = "";
            txtWorkExtension.Text = "";
            txtAddress.Text = "";
            txtMobile.Text = "";    
        }

        public frmNewPersonal()
        {
            InitializeComponent();
        }

        private void firmalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbcInsDelUpd.Visible = false;         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("dd MMMM dddd HH:mm", 
              CultureInfo.CreateSpecificCulture("tr-TR"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            adp = new SqlDataAdapter("SELECT ID,NAME FROM FIRM ", conn);
            adp.Fill(set, "FIRM");
            cmbSelectFirm.DataSource = set.Tables["FIRM"];
            cmbFirm.DataSource = set.Tables["FIRM"];
            cmbSelectFirm.DisplayMember = "NAME";
            cmbFirm.DisplayMember = "NAME";
            cmbSelectFirm.ValueMember = "ID";
            cmbFirm.ValueMember = "ID";
            adp.Dispose();
            set.Tables.Remove("FIRM");
            conn.Close();
        }
        
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
              loadPersonalData();
              loadPersonalName();
        }

        private void kapatAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hariciFirmalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbcInsDelUpd.Visible = false;     
        }

        private void kapatAltF4ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void f2firm_SelectedIndexChanged(object sender, EventArgs e)
        {          
            FirmName = cmbFirm.Text;
        }

        private void firmaKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmNewFirm frmNewFirm = new frmNewFirm();
            frmNewFirm.ShowDialog();           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            sql = @"SELECT ID
                           ,NAME AS AD 
                           ,SURNAME AS SOYAD 
                           ,WORK_EXTENSION AS [DAHİLİ NO] 
                           ,DEPARTMENT AS DEPARTMAN 
                           ,WORK_PHONE AS [İŞ TELEFONU]
                           ,MOBILE AS GSM
                           ,ADDRESS AS ADRES
                           ,FIRM_NAME AS FİRMA 
                           FROM PERSONAL 
                           WHERE FIRM_NAME LIKE '%" + cmbSelectFirm.Text + "%'AND NAME +' '+ SURNAME LIKE '%"
                                                               + cmbFindPersonal.Text + "%' ";
            adp = new SqlDataAdapter(sql, conn);
            adp.Fill(set, "PERSONAL");
            dgvPersonal.DataSource = set.Tables["PERSONAL"];
            dgvPersonal.Columns["ID"].Visible = false;
            adp.Dispose();
            set.Tables.Remove("PERSONAL");
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM PERSONAL WHERE ID = @silinecekid";
                cmd.Parameters.AddWithValue("@silinecekid", dgvPersonal.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteReader();
                cmd.Parameters.Clear();
                conn.Close();
                MessageBox.Show("Silme İşlemi Başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadPersonalData();            
            }
            else { }
           
           }
   
        private void f1dahilino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))//harf girişine izin vermeyen kod bloğu
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;      
            }
        }

        private void f1istel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))//harf girişine izin vermeyen kod bloğu
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void f1ceptel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))//harf girişine izin vermeyen kod bloğu
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp frmHelp = new frmHelp();
            frmHelp.ShowDialog();
        }

        private void cmbFirmaSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPersonalName();
        }

        private void dgvPersonal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            PERSONALDTO record = new PERSONALDTO(); 
            record.ID = Convert.ToInt32(dgvPersonal.SelectedRows[0].Cells[0].Value);
            record.NAME = dgvPersonal.SelectedRows[0].Cells[1].Value.ToString();
            record.SURNAME = dgvPersonal.SelectedRows[0].Cells[2].Value.ToString();
            record.WORK_EXTENSION = dgvPersonal.SelectedRows[0].Cells[3].Value.ToString();
            record.DEPARTMENT = dgvPersonal.SelectedRows[0].Cells[4].Value.ToString();
            record.WORK_PHONE = dgvPersonal.SelectedRows[0].Cells[5].Value.ToString();
            record.MOBILE = dgvPersonal.SelectedRows[0].Cells[6].Value.ToString();
            record.ADDRESS = dgvPersonal.SelectedRows[0].Cells[7].Value.ToString();
            record.FIRM_NAME = dgvPersonal.SelectedRows[0].Cells[8].Value.ToString();
            frmUpdatePersonal openDialog = new frmUpdatePersonal(record);
            openDialog.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtSurname.Text) 
                                                         && !string.IsNullOrWhiteSpace(txtWorkExtension.Text)
                                                         && !string.IsNullOrWhiteSpace(txtWorkPhone.Text)
                                                         && !string.IsNullOrWhiteSpace(txtDepartment.Text))
            {
                try
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                    conn.Open();
                    sql = "SELECT WORK_EXTENSION FROM PERSONAL WHERE WORK_EXTENSION = '" + txtWorkExtension.Text + "'";
                    DataTable result = new DataTable();
                    adp = new SqlDataAdapter(sql, conn);
                    adp.Fill(result);
                    if (result.Rows.Count > 0)
                        MessageBox.Show("Aynı Dahili No'ya ait kayıt var.Kayıt yapılamaz");
                    else
                    {
                        cmd = new SqlCommand(@"INSERT INTO PERSONAL ( NAME, SURNAME, FIRM_NAME, WORK_EXTENSION, DEPARTMENT, WORK_PHONE,MOBILE,ADDRESS ) 
                                                             VALUES ('"+ txtName.Text.Trim() + "','"
                                                                       + txtSurname.Text.Trim() + "','" 
                                                                       + FirmName + "','" 
                                                                       + txtWorkExtension.Text.Trim() + "','" 
                                                                       + txtDepartment.Text.Trim() + "','" 
                                                                       + txtWorkPhone.Text.Trim() + "','" 
                                                                       + txtMobile.Text.Trim() + "','" 
                                                                       + txtAddress.Text.Trim() + "')", conn);
                        if (txtWorkPhone.Text.Length != 11)
                            MessageBox.Show("İş telefonunu eksik girdiniz!");
                        else
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Başarıyla Kaydedildi");
                            cmd.Dispose();
                            sifirla();
                        }
                    }
                    adp.Dispose();
                    conn.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Kayıt yapılamadı!" + ex.Message);

                }
            }
            else MessageBox.Show("Lütfen doldurulması gereken yerleri doldurunuz");
        }

        private void txtWorkPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) && txtWorkPhone.Text.Length == 1)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtMobile_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) && txtMobile.Text.Length == 1)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtWorkPhone_Enter(object sender, EventArgs e)
        {
            txtWorkPhone.SelectionStart = txtWorkPhone.Text.Length;
        }

        private void txtMobile_Enter(object sender, EventArgs e)
        {
            txtMobile.SelectionStart = txtMobile.Text.Length;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadPersonalData();
        }

    }
}
