using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessLayer.DTO;

namespace CallGuide
{
    public partial class frmNewFirm : Form
    {
        
        SqlConnection conn = new SqlConnection(DBHelper.connection);
        SqlDataAdapter adp = null;
        SqlCommand cmd = null;
        DataSet set = DBHelper.GetDBAdapter();
        public string sql = "";

        private void LoadData()
        {
            sql = @"SELECT F.ID ,F.NAME AS AD
                                ,F.TITLE AS ÜNVAN
                                ,T.NAME AS TİP
                                ,F.ADDRESS AS ADRES
                                FROM FIRM F INNER JOIN FIRM_TYPE T 
                                ON F.TYPE_ID = T.ID;";

            adp = new SqlDataAdapter(sql, conn);
            if (conn.State == ConnectionState.Open) conn.Close();
            conn.Open();
            set.Clear();        
            adp.Fill(set, "FIRM");
            dgvFirm.DataSource = set.Tables["FIRM"];
            dgvFirm.Columns["ID"].Visible = false;
            adp.Dispose();
            set.Tables.Remove("FIRM");
            conn.Close();
        }
        
        public frmNewFirm()
        {
            InitializeComponent();
        }

        private void kişiKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmNewPersonal frmNewPersonal = new frmNewPersonal();
            frmNewPersonal.ShowDialog();
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain frmMain = new frmMain();
            frmMain.ShowDialog();
        }

        private void kapatAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvFirm.CurrentRow == null)
                return;
            if (MessageBox.Show("Sildiğiniz firmaya ait tüm kayıtlar silinecektir.Seçili Firmayı Silmek İstediğinize Emin Misiniz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string deletedFirm;
                    deletedFirm = dgvFirm.CurrentRow.Cells[1].Value.ToString();
                    cmd = new SqlCommand();
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE FROM FIRM WHERE ID = @silinecekid";
                    cmd.Parameters.AddWithValue("@silinecekid", dgvFirm.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    conn.Close();
                    MessageBox.Show("Silme İşlemi Başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Silme işlemi gerçekleşmedi! Hata: " + ex.InnerException);
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();           
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp frmHelp = new frmHelp();
            frmHelp.ShowDialog();
        }

        private void dgvFirmList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            FIRMDTO record = new FIRMDTO();
            record.ID = Convert.ToInt32(dgvFirm.SelectedRows[0].Cells[0].Value);
            record.NAME = dgvFirm.SelectedRows[0].Cells[1].Value.ToString();
            record.TITLE = dgvFirm.SelectedRows[0].Cells[2].Value.ToString();
            record.TYPE_ID = dgvFirm.SelectedRows[0].Cells[3].Value.ToString();
            record.ADDRESS = dgvFirm.SelectedRows[0].Cells[4].Value.ToString();
            frmUpdateFirm openDialog = new frmUpdateFirm(record);
            openDialog.ShowDialog();
        }

        private void dgvFirmList_MouseEnter(object sender, EventArgs e)
        {
            LoadData();  
        }
    }
}
