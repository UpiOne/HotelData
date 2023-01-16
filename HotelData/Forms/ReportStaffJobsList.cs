using Microsoft.Reporting.WinForms;
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

namespace HotelData.Forms
{
    public partial class ReportStaffJobsList : Form
    {
        public ReportStaffJobsList()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\APEX\source\repos\HotelData\HotelData\DateBaseHotel.mdf;Integrated Security=True;Connect Timeout=30");

        private void ReportStaffJobsList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dateBaseHotelDataSet.StaffsJobsTbl". При необходимости она может быть перемещена или удалена.
            this.staffsJobsTblTableAdapter.Fill(this.dateBaseHotelDataSet.StaffsJobsTbl);
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

            this.reportViewer1.RefreshReport();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select *from StaffsJobsTbl", Con);
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1", dt);
            this.staffsJobsTblTableAdapter.Fill(this.dateBaseHotelDataSet.StaffsJobsTbl);
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }
    }
}
