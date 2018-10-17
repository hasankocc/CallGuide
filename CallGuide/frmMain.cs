using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessLayer.DTO;

namespace CallGuide
{
    public partial class frmMain : Form
    {
        public static string FirmName="";
        public static string SearchFirm = "";
        public static string SearchName="";
        
        SqlConnection conn = new SqlConnection(DBHelper.connection);
        SqlDataAdapter adp = null;
        SqlCommand cmd = null;
        DataSet set = DBHelper.GetDBAdapter();
        public string sql = "";
        public frmMain()
        {
            InitializeComponent();
        }
        private void sifirla()
        {
            txtAd.Text = "";
            txtUnvan.Text = "";
            txtAddress.Text = "";
        }

        private void load() 
        {
            groupBox1.Visible = true;
            dgvFirm.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            rdbInternalFirm.Checked = true;

            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            sql="Select ID,NAME from FIRM";
            adp = new SqlDataAdapter(sql, conn);
            adp.Fill(set, "FIRM");
            cmbSelectFirm.DataSource = set.Tables["FIRM"];
            cmbSelectFirm.DisplayMember = "NAME";
            set.Tables.Remove("FIRM");
            adp.Dispose();
            conn.Close();
        }
       
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbl_time1.Text = DateTime.Now.ToString("dd MMMM dddd HH:mm",
            CultureInfo.CreateSpecificCulture("tr-TR"));
        }   

        private void firmalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // listBox2.Items.
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;

            dgvFirm.Visible = true;
            pictureBox1.Visible = true;
            label6.Visible = true;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            sql="Select NAME from FIRM WHERE TYPE_ID=1";
            adp = new SqlDataAdapter(sql, conn);
            adp.Fill(set, "FIRM");     
            dgvFirm.DataSource = set.Tables["FIRM"];
            dgvFirm.Columns[0].HeaderText = "FİRMA ADI";
            set.Tables.Remove("FIRM");
            adp.Dispose();
            conn.Close();       
        }

        private void hariciFirmalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;

            dgvFirm.Visible = true;
            pictureBox1.Visible = true;
            label6.Visible = true;

            if (conn.State == ConnectionState.Open)
                conn.Close();
                conn.Open();
                sql = "Select NAME from FIRM WHERE TYPE_ID=2";
                adp = new SqlDataAdapter(sql, conn);
                adp.Fill(set, "FIRM");
                dgvFirm.DataSource = set.Tables["FIRM"];
                dgvFirm.Columns[0].HeaderText = "FİRMA ADI";
                set.Tables.Remove("FIRM");
                adp.Dispose();
                conn.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata!" + ex.InnerException);
            }
        }
      
        private void kişiKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmNewPersonal frm1 = new frmNewPersonal();
           frm1.ShowDialog();  
        }

        private void firmaKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewFirm frm4 = new frmNewFirm();
            frm4.ShowDialog();
        }

        private void anaEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata!" + ex.InnerException);
            }
        }

        private void f2arama_SelectedIndexChanged(object sender, EventArgs e)
        {              
            SearchName = cmbAdSoyad.Text.Trim();         
        }

        private void f1firm_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchFirm = cmbSelectFirm.Text.Trim();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            sql = "Select ID,NAME + ' ' + SURNAME as ADI from PERSONAL WHERE FIRM_NAME LIKE '%" + SearchFirm + "%'";
            adp = new SqlDataAdapter(sql, conn);
            adp.Fill(set, "PERSONAL");
            cmbAdSoyad.DataSource = set.Tables["PERSONAL"];
            cmbAdSoyad.DisplayMember = "ADI";
            set.Tables.Remove("PERSONAL");
            adp.Dispose();
            conn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch frmSearch = new frmSearch();
            frmSearch.Show();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp frmHelp = new frmHelp();
            frmHelp.ShowDialog();
        }

        private void kapatAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtAd.Text.ToUpper(new CultureInfo("tr-TR", false));
            int x = 0;
            try
            {
                if (!string.IsNullOrWhiteSpace(txtAd.Text.Trim()) && 
                    !string.IsNullOrWhiteSpace(txtUnvan.Text.Trim()) && 
                    !string.IsNullOrWhiteSpace(txtAddress.Text.Trim()))
                {

                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                    conn.Open();
                    if (rdbInternalFirm.Checked == true)
                        x = 1;
                    else
                        x = 2;
                    sql = @"INSERT INTO FIRM( NAME, TITLE, TYPE_ID, ADDRESS ) 
                                            VALUES('"+ txtAd.Text.Trim() + "','" 
                                                     + txtUnvan.Text.Trim() + "','" + x + "','"
                                                     + txtAddress.Text.Trim() + "')";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show("Başarıyla Kaydedildi");
                }
                else
                    MessageBox.Show("Lütfen doldurulması gereken yerleri doldurunuz");
                sifirla();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt yapılamadı! Hata: " + ex.InnerException);
            }
        }

        private void dgvFirm_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (dgvFirm.SelectedRows.Count != 0)
            {
                FirmName = dgvFirm.CurrentRow.Cells["NAME"].Value.ToString().Trim();
                frmPersonalList frmPersonalList = new frmPersonalList();
                frmPersonalList.Show();
            }
        }
                  
    }
}
