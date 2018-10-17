using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessLayer;
using BusinessLayer.DTO;

namespace CallGuide
{
    public partial class frmUpdatePersonal : Form
    {

        private int recordId = 0;
        public string temp = ""; //Firma Seç combo'sunun text ine gelen değeri atamak için
        public frmUpdatePersonal(PERSONALDTO record)
        {
            InitializeComponent();
            recordId = record.ID;
            txtName.Text = record.NAME;
            txtSurname.Text = record.SURNAME;
            temp = record.FIRM_NAME;
            txtWorkExtension.Text = record.WORK_EXTENSION;
            txtDepartment.Text = record.DEPARTMENT;
            txtWorkPhone.Text = record.WORK_PHONE;
            txtMobile.Text = record.MOBILE;
            txtAddress.Text = record.ADDRESS;
        }
        SqlConnection conn = new SqlConnection(DBHelper.connection);
        DataSet set = DBHelper.GetDBAdapter();
        SqlCommand cmd = null;
        SqlDataAdapter adp = null;
        public string sql = "";

        private void btnUpdate_Click(object sender, EventArgs e)
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
                        sql = "SELECT ID,WORK_EXTENSION FROM PERSONAL WHERE WORK_EXTENSION = '" + txtWorkExtension.Text + "'";
                        DataTable resultTable = new DataTable();
                        adp = new SqlDataAdapter(sql, conn);
                        adp.Fill(resultTable);

                        cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "UPDATE PERSONAL SET NAME = '"
                                           + txtName.Text.Trim() + "' , SURNAME = '"
                                           + txtSurname.Text.Trim() + "' , FIRM_NAME = '"
                                           + cmbSelectFirm.Text.Trim() + "' , WORK_EXTENSION = '"
                                           + txtWorkExtension.Text.Trim() + "' , DEPARTMENT = '"
                                           + txtDepartment.Text.Trim() + "' , WORK_PHONE = '"
                                           + txtWorkPhone.Text.Trim() + "' , MOBILE = '"
                                           + txtMobile.Text.Trim() + "' , ADDRESS = '"
                                           + txtAddress.Text.Trim() + "' WHERE ID = " + recordId;
                        if (txtWorkPhone.Text.Length != 11)
                            MessageBox.Show("İş telefonunu eksik girdiniz!");
                        else
                        {
                            if (resultTable.Rows.Count > 0)
                            {
                                DataRow recordRow = resultTable.Rows[0];
                                if (resultTable.Rows.Count == 1 && Convert.ToInt32(recordRow["ID"]) == recordId)
                                {
                                    cmd.ExecuteNonQuery();
                                    {
                                        MessageBox.Show("Güncelleme işlemi başarılı!");
                                        this.Close();
                                    }
                                }
                                else
                                MessageBox.Show("Aynı Dahili No'ya ait kayıt var.Kayıt yapılamaz");
                            }
                            else
                            {
                                cmd.ExecuteNonQuery();
                                {
                                    MessageBox.Show("Güncelleme işlemi başarılı!");
                                    this.Close();
                                }
                            }
                        }
                        resultTable.Dispose();
                        adp.Dispose();
                        cmd.Dispose();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Güncelleme işlemi başarısız! Hata : " + ex.Message);
                    }
            }
            else MessageBox.Show("Lütfen doldurulması gereken yerleri doldurunuz");
        }

        private void txtWorkExtension_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtWorkNumber_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMobile_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) && txtMobile.Text.Length == 1)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtWorkNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) && txtWorkPhone.Text.Length == 1)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void frmUpdatePersonal_Load(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                sql = "SELECT ID,NAME FROM FIRM";
                adp = new SqlDataAdapter(sql, conn);
                adp.Fill(set, "FIRM");
                cmbSelectFirm.DataSource = set.Tables["FIRM"];
                cmbSelectFirm.DisplayMember = "NAME";
                cmbSelectFirm.ValueMember = "ID";
                adp.Dispose();
                set.Tables.Remove("FIRM");
                conn.Close();

                cmbSelectFirm.Text = temp;
            }
            catch(Exception ex)
            {
             MessageBox.Show("Hata: " + ex.Message);
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

    }
}