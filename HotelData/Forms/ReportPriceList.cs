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
    public partial class ReportPriceList : Form
    {
        public ReportPriceList()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\APEX\source\repos\HotelData\HotelData\DateBaseHotel.mdf;Integrated Security=True;Connect Timeout=30");

        private void ReportPriceList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dateBaseHotelDataSet.TypeTbl". При необходимости она может быть перемещена или удалена.
            this.typeTblTableAdapter.Fill(this.dateBaseHotelDataSet.TypeTbl);
          
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
           
            this.reportViewer1.RefreshReport();
        }

    
        private void FilterStatusCb_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.typeTblTableAdapter.FillBy(this.dateBaseHotelDataSet.TypeTbl, FilterStatusCb.Text);
            reportViewer1.RefreshReport();
        }
    }
}
