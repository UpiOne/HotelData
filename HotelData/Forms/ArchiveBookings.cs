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
    public partial class ArchiveBookings : Form
    {
        public ArchiveBookings()
        {
            InitializeComponent();
            ArchivePopulation();
            GetRooms();
            GetCustomers();
            GetAdditionalServices();
            listBox1.SetSelected(0, false);
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\APEX\source\repos\HotelData\HotelData\DateBaseHotel.mdf;Integrated Security=True;Connect Timeout=30");

        private void ArchivePopulation()
        {
            Con.Open();
            string Query = "SELECT* FROM ArchiveBookingsTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookingsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void GetRooms()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT* FROM RoomTbl where RStatus = N'свободна'", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RNum", typeof(int));
            dt.Load(rdr);
            RoomCb.ValueMember = "RNum";
            RoomCb.DataSource = dt;
            Con.Close();
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
        private void GetAdditionalServices()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT* FROM AdditionalServicesTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ServicesNum", typeof(int));
            dt.Load(rdr);
            listBox1.ValueMember = "ServicesNum";
            listBox1.DataSource = dt;
            Con.Close();
        }
        private void DeleteArhiveBooking()
        {
            if (Key == 0)
            {
                MessageBox.Show("Выберите архивная запись из списка ниже !!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM ArchiveBookingsTbl WHERE BookNum1 = @BKey", Con);
                    cmd.Parameters.AddWithValue("@BKey", Key);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Выбранная архивная запись удалена", "Оповещание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    ArchivePopulation();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int Key = 0;
        private void BookingsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            listBox1.Text = BookingsDGV.SelectedRows[0].Cells[1].Value.ToString();
            RoomCb.Text = BookingsDGV.SelectedRows[0].Cells[2].Value.ToString();
            CustomerCb.Text = BookingsDGV.SelectedRows[0].Cells[3].Value.ToString();
            BDate.Text = BookingsDGV.SelectedRows[0].Cells[4].Value.ToString();
            DurationTb.Text = BookingsDGV.SelectedRows[0].Cells[5].Value.ToString();
            AmountTb.Text = BookingsDGV.SelectedRows[0].Cells[6].Value.ToString();
            StatusCb.Text = BookingsDGV.SelectedRows[0].Cells[7].Value.ToString();
            if (DurationTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(BookingsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DeleteArhiveBooking();
        }
        private void BPrint_Click(object sender, EventArgs e)
        {
            ReportBookingsList Obj = new ReportBookingsList();
            Obj.Show();
        }
    }
}
