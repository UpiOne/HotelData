using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelData.Forms
{
    public partial class ReportBookingsList : Form
    {
        public ReportBookingsList()
        {
            InitializeComponent();
            GetCustomers();

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\APEX\source\repos\HotelData\HotelData\DateBaseHotel.mdf;Integrated Security=True;Connect Timeout=30");

        private void ReportBookingsList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dateBaseHotelDataSet1.CustomerTbl". При необходимости она может быть перемещена или удалена.
            this.customerTblTableAdapter.Fill(this.dateBaseHotelDataSet1.CustomerTbl);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dateBaseHotelDataSet1.BookingTbl". При необходимости она может быть перемещена или удалена.
            this.bookingTblTableAdapter.Fill(this.dateBaseHotelDataSet1.BookingTbl);
            //this.bookingTblTableAdapter.Fill(this.dateBaseHotelDataSet1.BookingTbl);
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

            this.reportViewer1.RefreshReport();

        }
        private void GetCustomers()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT* FROM CustomerTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustNum", typeof(int));
            dt.Load(rdr);
            FilterStatusCb.ValueMember = "CustNum";
            FilterStatusCb.DataSource = dt;
            reportViewer1.RefreshReport();
            Con.Close();
        }
        private void Population()
        {
            Con.Open();
            string Query = "SELECT* FROM BookingTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);

            Con.Close();
                    reportViewer1.RefreshReport();
        }

        private void FilterStatusCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bookingTblTableAdapter.FillBy(this.dateBaseHotelDataSet1.BookingTbl, (int)FilterStatusCb.SelectedValue);
            reportViewer1.RefreshReport();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Population();
        }
    }
}
