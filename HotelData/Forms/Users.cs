using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace HotelData.Forms
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            Population();
            GetStaffs();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\APEX\source\repos\HotelData\HotelData\DateBaseHotel.mdf;Integrated Security=True;Connect Timeout=30");

        private void Population()
        {
            Con.Open();
            string Query = "SELECT * FROM UserTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UsersDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void GetStaffs()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT* FROM StaffTbl where StaffJob = N'Оператор'", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StaffName", typeof(string));
            dt.Load(rdr);
            UStaffCb.ValueMember = "StaffName";
            UStaffCb.DataSource = dt;
            Con.Close();
        }
        private void InsertUsers()
        {
            if (ULoginTb.Text == "" || PasswordTb.Text == "" || UStaffCb.SelectedIndex == -1)
            {
                MessageBox.Show("Пропущена информация !!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into UserTbl(ULogin,UPassword,UStaffName) values(@UL,@UPa,@USN)", Con);
                    cmd.Parameters.AddWithValue("@UL", ULoginTb.Text.Trim());
                    cmd.Parameters.AddWithValue("@UPa", PasswordTb.Text.Trim());
                    cmd.Parameters.AddWithValue("@USN", UStaffCb.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Новый пользователь добавлен", "Оповещание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    Population();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void EditUsers()
        {
            if (ULoginTb.Text == "" || PasswordTb.Text == "" || UStaffCb.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите пользователя из списка ниже !!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open(); 
                    SqlCommand cmd = new SqlCommand("UPDATE  UserTbl SET ULogin=@UL,Upassword=@UPa,UStaffName=@USN WHERE UNum = @UKey", Con);

                    cmd.Parameters.AddWithValue("@UL", ULoginTb.Text);
                    cmd.Parameters.AddWithValue("@UPa", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@USN", UStaffCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@UKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Выбранный пользователь отредактирован", "Оповещание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    Population();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void DeleteUsers()
        {
            if (Key == 0)
            {
                MessageBox.Show("Выберите пользователя из списка ниже !!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM UserTbl WHERE UNum = @UKey", Con);
                    cmd.Parameters.AddWithValue("@UKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Выбранный пользователь удален", "Оповещание", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            EditUsers();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            InsertUsers();
           
            DataTable dt = new DataTable();
            foreach (DataGridViewTextBoxColumn column in UsersDGV.Columns)
            {
                dt.Columns.Add(column.Name, column.ValueType);
            }
            foreach (DataGridViewRow row in UsersDGV.Rows)
            {
                DataRow dr = dt.NewRow();
                foreach (DataGridViewTextBoxColumn column in UsersDGV.Columns)
                {
                    if (row.Cells[column.Name].Value != null)
                    {
                        dr[column.Name] = row.Cells[column.Name].Value.ToString();
                    }
                }
                dt.Rows.Add(dr);
            }
            string filePath = "C:\\Users\\APEX\\source\\repos\\HotelData\\HotelData\\ResultUsers.txt";
            DataTableToTextFile(dt, filePath);
            // MessageBox.Show("Сохранен в файл");
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteUsers();
        }
        int Key = 0;
        private void UsersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ULoginTb.Text = UsersDGV.SelectedRows[0].Cells[1].Value.ToString();
            PasswordTb.Text = UsersDGV.SelectedRows[0].Cells[2].Value.ToString();
            UStaffCb.Text = UsersDGV.SelectedRows[0].Cells[3].Value.ToString();
           
            if (ULoginTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(UsersDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void UNameTb_Load(object sender, EventArgs e)
        {
            ULoginTb.Focus();
        }
        private void DataTableToTextFile(DataTable dt, string outputFilePath)
        {
            int[] maxLengths = new int[dt.Columns.Count];

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                maxLengths[i] = dt.Columns[i].ColumnName.Length;
                foreach (DataRow row in dt.Rows)
                {
                    if (!row.IsNull(i))
                    {
                        int length = row[i].ToString().Length;
                        if (length > maxLengths[i])
                        {
                            maxLengths[i] = length;
                        }
                    }
                }
            }

            using (StreamWriter sw = new StreamWriter(outputFilePath, false))
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    sw.Write("\t" + dt.Columns[i].ColumnName.PadRight(maxLengths[i] + 5) + "\t" + "|");
                }

                sw.WriteLine("");


                foreach (DataRow row in dt.Rows)
                {
                    sw.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {

                        if (!row.IsNull(i))
                        {
                            sw.Write("\t" + row[i].ToString().PadRight(maxLengths[i] + 5) + "\t" + "|");
                        }
                        else
                        {
                            sw.Write(new string(' ', maxLengths[i] + 2));
                        };
                    }
                    sw.WriteLine();
                }

                sw.Close();
            }
        }

    
    }
}
