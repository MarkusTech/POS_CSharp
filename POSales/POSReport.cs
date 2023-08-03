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
using Microsoft.Reporting.WinForms;

namespace POSales
{
    public partial class POSReport : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        string store;
        string address;
        public POSReport()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadStore();
        }

        public void LoadStore()
        {
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbStore", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                store = dr["store"].ToString();
                address = dr["address"].ToString();
            }
            dr.Close();
            cn.Close();
        }

        private void POSReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadDailyReport(string sql, string param, string cashier)
        {
            try
            {
                ReportDataSource rptDS;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptSoldReport.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                cn.Open();
                da.SelectCommand = new SqlCommand(sql, cn);
                da.Fill(ds.Tables["dtSoldReport"]);
                cn.Close();

                ReportParameter pDate = new ReportParameter("pDate", param);
                ReportParameter pCashier = new ReportParameter("pCashier", cashier);
                ReportParameter pHeader = new ReportParameter("pHeader", "Daily Sales Report");
                ReportParameter pStore = new ReportParameter("pStore", store);
                ReportParameter pAddress = new ReportParameter("pAddress", address);

                reportViewer1.LocalReport.SetParameters(pDate);
                reportViewer1.LocalReport.SetParameters(pCashier);
                reportViewer1.LocalReport.SetParameters(pHeader);
                reportViewer1.LocalReport.SetParameters(pStore);
                reportViewer1.LocalReport.SetParameters(pAddress);

                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtSoldReport"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 30;


            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    
        public void LoadTopSelling(string sql, string param, string header)
        {
            try
            {
                ReportDataSource rptDS;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptTopSell.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                cn.Open();
                da.SelectCommand = new SqlCommand(sql, cn);
                da.Fill(ds.Tables["dtTopSell"]);
                cn.Close();

                ReportParameter pDate = new ReportParameter("pDate", param);
                ReportParameter pHeader = new ReportParameter("pHeader", header);

                reportViewer1.LocalReport.SetParameters(pDate);         
                reportViewer1.LocalReport.SetParameters(pHeader);
                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtTopSell"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 30;
            }
            catch (Exception ex)
            {

                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadSoldItems(string sql, string param)
        {
            try
            {
                ReportDataSource rptDS;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptSoldItems.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                cn.Open();
                da.SelectCommand = new SqlCommand(sql, cn);
                da.Fill(ds.Tables["dtSoldItems"]);
                cn.Close();

                ReportParameter pDate = new ReportParameter("pDate", param);                

                reportViewer1.LocalReport.SetParameters(pDate);                
                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtSoldItems"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {

                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadInventory(string sql)
        {
            try
            {
                ReportDataSource rptDS;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptInventory.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                cn.Open();
                da.SelectCommand = new SqlCommand(sql, cn);
                da.Fill(ds.Tables["dtInventory"]);
                cn.Close();

        
                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtInventory"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {

                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadCancelledOrder(string sql, string param)
        {
            try
            {
                ReportDataSource rptDS;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptCancelled.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                cn.Open();
                da.SelectCommand = new SqlCommand(sql, cn);
                da.Fill(ds.Tables["dtCancelOrder"]);
                cn.Close();

                ReportParameter pDate = new ReportParameter("pDate", param);

                reportViewer1.LocalReport.SetParameters(pDate);
                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtCancelOrder"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadStockInHist(string sql, string param)
        {
            try
            {
                ReportDataSource rptDS;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptStockInHist.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                cn.Open();
                da.SelectCommand = new SqlCommand(sql, cn);
                da.Fill(ds.Tables["dtStockInHist"]);
                cn.Close();

                ReportParameter pDate = new ReportParameter("pDate", param);

                reportViewer1.LocalReport.SetParameters(pDate);
                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtStockInHist"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void POSReport_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
