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
    public partial class frmUpdateFirm : Form
    {
        private int recordId = 0;
        private Int16 firmType = 0;
        public frmUpdateFirm(FIRMDTO record)
        {
            InitializeComponent();
            recordId = record.ID;
            txtFirmName.Text = record.NAME;
            txtFirmTitle.Text = record.TITLE;
            cmbSelectFirmType.Text = record.TYPE_ID;
            txtAddress.Text = record.ADDRESS;
        }

        SqlConnection conn = new SqlConnection(DBHelper.connection);
        SqlCommand cmd = null;
       
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbSelectFirmType.Text == "Dahili")
                firmType = 1;
            else
                firmType = 2;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE FIRM SET NAME = '"
                                   + txtFirmName.Text.Trim() + "' , TITLE = '"
                                   + txtFirmTitle.Text.Trim() + "' , ADDRESS = '"
                                   + txtAddress.Text.Trim() + "' , TYPE_ID = "
                                   + firmType + " WHERE ID = " + recordId;
                cmd.ExecuteNonQuery();
                {
                    MessageBox.Show("Güncelleme işlemi başarılı!");
                    cmd.Dispose();
                    conn.Close();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme işlemi başarısız! Hata : " + ex.Message);
            }
        }
    }
}
