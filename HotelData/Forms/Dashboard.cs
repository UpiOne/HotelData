using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelData.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            CountRooms();
            CountCustomers();
            SumAmount();
            GetCustomers();
            AvaibleRooms();
           
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\APEX\source\repos\HotelData\HotelData\DateBaseHotel.mdf;Integrated Security=True;Connect Timeout=30");
        private void CountRooms()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT count(*) FROM RoomTbl ", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            RoomsLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void AvaibleRooms()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT count(*) FROM RoomTbl where RStatus = N'свободна' ", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            RoomsLbl1.Text = "("+dt.Rows[0][0].ToString() +")";
            Con.Close();
        }
        private void CountCustomers()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT count(*) FROM CustomerTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CustsLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void SumAmount()
        {
          
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT sum(Cost1) FROM ArchiveBookingsTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BookingsLbl.Text = "Сумма: " +dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void SumDaily()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select sum(Cost1) from ArchiveBookingsTbl where BookDate1='" + BDate.Value.ToString("MM/dd/yyyy") + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            InComeByDailyLbl.Text = "Сумма: " + dt.Rows[0][0];
            Con.Close();
        }
        private void SumByCustomer()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT sum(Cost1) FROM ArchiveBookingsTbl WHERE Customer1=" + CustomerCb.SelectedValue.ToString() + "", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                InComeByCustLbl.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception)
            {
                Con.Close();
            }
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
            CustomerCb.ValueMember = "CustNum";
            CustomerCb.DataSource = dt;
            Con.Close();
        }
        private void BDate_ValueChanged(object sender, EventArgs e)
        {
            SumDaily();
        }
        private void CustomerCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SumByCustomer();
        }
    }
}
