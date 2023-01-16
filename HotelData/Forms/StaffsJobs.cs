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
    public partial class StaffsJobs : Form
    {
        public StaffsJobs()
        {
            InitializeComponent();
            Population();
            GetRooms();
            GetStaffs();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\APEX\source\repos\HotelData\HotelData\DateBaseHotel.mdf;Integrated Security=True;Connect Timeout=30");
        private void Population()
        {
            Con.Open();
            string Query = "SELECT* FROM StaffsJobsTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StaffsJobsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void GetRooms()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT* FROM RoomTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RNum", typeof(int));
            dt.Load(rdr);
            RoomCb.ValueMember = "RNum";
            RoomCb.DataSource = dt;
            Con.Close();
        }
        private void GetStaffs()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT* FROM StaffTbl where StaffJob = N'горничная'", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StaffName", typeof(string));
            dt.Load(rdr);
            StaffCb.ValueMember = "StaffName";
            StaffCb.DataSource = dt;
            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (StaffCb.SelectedIndex == -1 || RoomCb.SelectedIndex == -1 || StatusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Пропущенна информация !!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO StaffsJobsTbl(Room,Staff,StaffJobsDate,StaffJobsStatus) values(@R,@S,@SD,@SS )", Con);
                    cmd.Parameters.AddWithValue("@R", RoomCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@S", StaffCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@SD", SDate.Value);
                    cmd.Parameters.AddWithValue("@SS", StatusCb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Новая задача добавлена !");

                    Con.Close();
                    Population();
                    GetRooms();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (StaffCb.SelectedIndex == -1 || RoomCb.SelectedIndex == -1 || StatusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите персонал из списка ниже !!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();                                  

                    SqlCommand cmd = new SqlCommand("UPDATE StaffsJobsTbl SET Room=@R,Staff=@S,StaffJobsDate=@SD,StaffJobsStatus=@SS WHERE StaffsJobNum = @SJKey", Con);
                    cmd.Parameters.AddWithValue("@R", RoomCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@S", StaffCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@SD", SDate.Value);
                    cmd.Parameters.AddWithValue("@SS", StatusCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SJKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Выбранный персонал отредактирован", "Оповещание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    Population();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int Key = 0;
        private void StaffsJobsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RoomCb.Text = StaffsJobsDGV.SelectedRows[0].Cells[1].Value.ToString();
            StaffCb.Text = StaffsJobsDGV.SelectedRows[0].Cells[2].Value.ToString();
            SDate.Text = StaffsJobsDGV.SelectedRows[0].Cells[3].Value.ToString();
            StatusCb.Text = StaffsJobsDGV.SelectedRows[0].Cells[4].Value.ToString();
           
            if (RoomCb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(StaffsJobsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Выберите комнату из списка ниже !!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM StaffsJobsTbl WHERE StaffsJobNum = @SJKey", Con);
                    cmd.Parameters.AddWithValue("@SJKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Выбранная Комната удалена", "Оповещание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    Population();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BPrint_Click(object sender, EventArgs e)
        {
            ReportStaffJobsList Obj = new ReportStaffJobsList();
            Obj.Show();

            Obj.button1_Click(sender, e);
        }
    }
}
