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
    public partial class Staffs : Form
    {
        public Staffs()
        {
            InitializeComponent();
            Population();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\APEX\source\repos\HotelData\HotelData\DateBaseHotel.mdf;Integrated Security=True;Connect Timeout=30");
        private void Population()
        {
            Con.Open();
            string Query = "SELECT* FROM StaffTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StaffDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void InsertStaffs()
        {
            if (SNameTb.Text == "" || GenderCb.SelectedIndex == -1 || SPhoneTb.Text == "" || SAddressTb.Text == "" || Job.Text == "")
            {
                MessageBox.Show("Пропущена информация !!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();                                                 
                    SqlCommand cmd = new SqlCommand("insert into StaffTbl(StaffName,StaffGender,StaffHomeAddress,StaffDateOfBirth,StaffPhone,StaffJob) values(@SN,@SG,@SH,@SD,@SP,@SJ)", Con);
                    cmd.Parameters.AddWithValue("SN", SNameTb.Text);
                    cmd.Parameters.AddWithValue("@SP", SPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@SG", GenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SH", SAddressTb.Text);
                    cmd.Parameters.AddWithValue("@SD", SDate.Value.Date);
                    cmd.Parameters.AddWithValue("@SJ", Job.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Новая горничная добавлена", "Оповещание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    Population();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void EditStaffs()
        {
            if (SNameTb.Text == "" || GenderCb.SelectedIndex == -1 || SPhoneTb.Text == "" || SAddressTb.Text == "" || Job.Text == "")
            {
                MessageBox.Show("Выберите уборщика из списка ниже !!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE StaffTbl SET StaffName=@SN,StaffPhone=@SP,StaffGender=@SG,StaffHomeAddress=@SH,StaffDateOfBirth=@SD,StaffJob=@SJ WHERE StaffNum = @SKey", Con);
                    cmd.Parameters.AddWithValue("SN", SNameTb.Text);
                    cmd.Parameters.AddWithValue("@SP", SPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@SG", GenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SH", SAddressTb.Text);
                    cmd.Parameters.AddWithValue("@SD", SDate.Value.Date);
                    cmd.Parameters.AddWithValue("@SJ", Job.Text);
                    cmd.Parameters.AddWithValue("@SKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Выбранный уборщик отредактирован", "Оповещание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    Population();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void DeleteStaffs()
        {
            if (Key == 0)
            {
                MessageBox.Show("Выберите клиента из списка ниже !!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM StaffTbl WHERE StaffNum = @SKey", Con);
                    cmd.Parameters.AddWithValue("@SKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Выбранный уборщик удален", "Оповещание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    Population();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditStaffs();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            InsertStaffs();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteStaffs();
        }
        int Key = 0;
        private void MaidsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SNameTb.Text = StaffDGV.SelectedRows[0].Cells[1].Value.ToString();
            GenderCb.Text = StaffDGV.SelectedRows[0].Cells[2].Value.ToString();
            SAddressTb.Text = StaffDGV.SelectedRows[0].Cells[3].Value.ToString();
            SDate.Text = StaffDGV.SelectedRows[0].Cells[4].Value.ToString();
            SPhoneTb.Text = StaffDGV.SelectedRows[0].Cells[5].Value.ToString();
            Job.Text = StaffDGV.SelectedRows[0].Cells[6].Value.ToString();
           
        
            if (SNameTb.Text == "")
            {
               
                Key = 0;
            }
            else
            {
                
                Key = Convert.ToInt32(StaffDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void BPrint_Click(object sender, EventArgs e)
        {
            ReportStaffList Obj = new ReportStaffList();
            Obj.Show();

            Obj.button1_Click(sender, e);
        }
    }
}
