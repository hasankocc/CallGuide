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
    public partial class frmPersonalList : Form
    {
        public frmPersonalList()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection( DBHelper.connection);
        SqlDataAdapter adp = null;
        DataSet set = DBHelper.GetDBAdapter();
        public string sql = "";

        private void kapatAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            label1.Text = frmMain.FirmName + " PERSONEL KAYITLARI";
            conn.Open();
            sql = @"Select NAME AS AD ,SURNAME AS SOYAD 
                                      ,WORK_EXTENSION AS [DAHİLİ NO] 
                                      ,DEPARTMENT AS DEPARTMAN 
                                      ,WORK_PHONE AS [İŞ TELEFONU]
                                      ,MOBILE AS GSM
                                      ,ADDRESS AS ADRES
                                      ,FIRM_NAME AS FIRMA
                                      FROM PERSONAL 
                                      WHERE FIRM_NAME LIKE '%" + frmMain.FirmName + "%' ";
            adp = new SqlDataAdapter(sql, conn);
            adp.Fill(set, "PERSONAL");
            dataGridView1.DataSource = set.Tables["PERSONAL"];
            set.Tables.Remove("PERSONAL");
            adp.Dispose();
            conn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("dd MMMM dddd HH:mm",
               CultureInfo.CreateSpecificCulture("tr-TR"));
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp frmHelp = new frmHelp();
            frmHelp.ShowDialog();
        }

      }
   }

