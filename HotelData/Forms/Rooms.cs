using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HotelData.Forms
{
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
            Population();
            GetCategories();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\APEX\source\repos\HotelData\HotelData\DateBaseHotel.mdf;Integrated Security=True;Connect Timeout=30");

        private void Population()
        {
            Con.Open();
            string Query = "SELECT* FROM RoomTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            RoomsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void FilterStatusRooms()
        {
            Con.Open();
            string Query = "SELECT* FROM RoomTbl where RStatus= N'" + FilterStatusCb.SelectedItem.ToString()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            RoomsDGV.DataSource = ds.Tables[0];
            Con.Close();
            
        }
        private void GetCategories()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT* FROM TypeTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TypeNum", typeof(int));
            dt.Load(rdr);
            RTypeCb.ValueMember = "TypeNum";
            RTypeCb.DataSource = dt;
            
            Con.Close();
        }
        private void GetCategoriesStatusSeason()
        {

            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT* FROM TypeTbl where TStatus= N'" + TStatus.SelectedItem + "'", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TypeNum", typeof(int));
            dt.Load(rdr);
            RTypeCb.ValueMember = "TypeNum";
            RTypeCb.DataSource = dt;
          
            Con.Close();
        }
        private void EditRooms()
        {
            if (RNameTb.Text == "" || RTypeCb.Text == "" || StatusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите комнату из списка ниже !!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE RoomTbl SET RName=@RN,RType=@RT,RStatus=@RS,TStatus=@TS WHERE RNum = @RKey", Con);
                    cmd.Parameters.AddWithValue("@RN", RNameTb.Text);
                    cmd.Parameters.AddWithValue("@RT", RTypeCb.Text);
                    cmd.Parameters.AddWithValue("@RS", StatusCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TS", TStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Выбранная комната отредактирована", "Оповещание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    Population();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void InsertRooms()
        {
            if (RNameTb.Text == "" || RTypeCb.SelectedIndex == -1 || StatusCb.SelectedIndex == -1 || TStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Пропущена информация", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();


                    SqlCommand cmd = new SqlCommand("insert into RoomTbl(RName,RType,RStatus,TStatus) values(@RN,@RT,@RS,@TS)", Con);
                    cmd.Parameters.AddWithValue("@RN", RNameTb.Text);
                    cmd.Parameters.AddWithValue("@RT", RTypeCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@TS", TStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@RS", "свободна");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Новая комната добавлена","Оповещание",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Con.Close();
                    Population();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void DeleteRooms()
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
                    SqlCommand cmd = new SqlCommand("DELETE FROM RoomTbl WHERE RNum = @RKey", Con);
                    cmd.Parameters.AddWithValue("@RKey", Key);
                   
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

        int Key = 0;
        private void RSearch_TextChanged(object sender, EventArgs e)
        {
            (RoomsDGV.DataSource as DataTable).DefaultView.RowFilter = $"RName LIKE '%{RSearch.Text}%'";
        }

        private void RoomsDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            RNameTb.Text = RoomsDGV.SelectedRows[0].Cells[1].Value.ToString();
            RTypeCb.Text = RoomsDGV.SelectedRows[0].Cells[2].Value.ToString();
            StatusCb.Text = RoomsDGV.SelectedRows[0].Cells[3].Value.ToString();
            TStatus.Text = RoomsDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (StatusCb.Text == "бронь")
            {
                DeleteBtn.Enabled = false;
               
            }
            else
            {
                DeleteBtn.Enabled = true;
               
            }

            if (RNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(RoomsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

          
        }

        private void EditBtn_Click_1(object sender, EventArgs e)
        {
            EditRooms();
        }

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            InsertRooms();

            DataTable dt = new DataTable();
            foreach (DataGridViewTextBoxColumn column in RoomsDGV.Columns)
            {
                dt.Columns.Add(column.Name, column.ValueType);
            }
            foreach (DataGridViewRow row in RoomsDGV.Rows)
            {
                DataRow dr = dt.NewRow();
                foreach (DataGridViewTextBoxColumn column in RoomsDGV.Columns)
                {
                    if (row.Cells[column.Name].Value != null)
                    {
                        dr[column.Name] = row.Cells[column.Name].Value.ToString();
                    }
                }
                dt.Rows.Add(dr);
            }
            string filePath = "C:\\Users\\APEX\\source\\repos\\HotelData\\HotelData\\ResultRooms.txt";
            DataTableToTextFile(dt, filePath);
           // MessageBox.Show("Сохранен в файл");
        }

        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            DeleteRooms();
        }

        private void RNameTb_Load(object sender, EventArgs e)
        {
            RNameTb.Focus();
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

                sw.WriteLine();

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
                        }
                    }
                    sw.WriteLine();
                }
                sw.Close();
            }
        }

        private void FilterStatusCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterStatusCb.Text == "показать всё")
            {
                Population();
            }
            else
            {
                FilterStatusRooms();
            }
           
        }

        private void TStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TStatus.Text == "показать всё")
            {
                GetCategories();
            }
            else
            {
                GetCategoriesStatusSeason();
            }
              
        }
    }
}
