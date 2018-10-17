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
    public partial class frmSearch : Form
    {
        SqlConnection conn = new SqlConnection(DBHelper.connection);
        SqlDataAdapter adp = null;
        DataSet set = DBHelper.GetDBAdapter();
        public string sql ="";

        public frmSearch()
        {
            InitializeComponent();
        }

        private void kapatAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                sql = @"SELECT NAME AS AD ,SURNAME AS SOYAD 
                                          ,WORK_EXTENSION AS [DAHİLİ NO] 
                                          ,DEPARTMENT AS DEPARTMAN 
                                          ,WORK_PHONE AS [İŞ TELEFONU]
                                          ,MOBILE AS GSM
                                          ,ADDRESS AS ADRES
                                          ,FIRM_NAME AS FIRMA
                                          FROM PERSONAL 
                                          WHERE FIRM_NAME LIKE '%" + frmMain.SearchFirm.ToString() + "%' AND NAME +' '+ SURNAME LIKE '%"
                                                                   + frmMain.SearchName.ToString() + "%' ";
                adp = new SqlDataAdapter(sql, conn);
                adp.Fill(set, "PERSONAL");
                dgvSearchResult.DataSource = set.Tables["PERSONAL"];
                set.Tables.Remove("PERSONAL");
                adp.Dispose();
                conn.Close();
            }

            catch (Exception ex) 
            {
                MessageBox.Show("Hata: " + ex.InnerException);
            }
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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook excelWorkBook = excel.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet excelSheet = excelWorkBook.ActiveSheet;
                excelSheet.Name = "Rehber";
                for (int i = 1; i < dgvSearchResult.Columns.Count + 1; i++)
                {
                    excelSheet.Cells[1, i] = dgvSearchResult.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dgvSearchResult.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvSearchResult.Columns.Count; j++)
                    {
                        excelSheet.Cells[i + 2, j + 1] = dgvSearchResult.Rows[i].Cells[j].Value.ToString();
                    }

                }
                MessageBox.Show("Excel dosyanız başarıyla oluşturuldu! Kontrol edip kaydetmeyi unutmayınız!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

    }
}
