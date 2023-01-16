using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HotelData.Forms
{
    public partial class Bookings : Form
    {
        public Bookings()
        {
            InitializeComponent();
            ArchivePopulation();
            Population();
            GetRooms();
            GetCustomers();
            GetAdditionalServices();
            listBox1.SetSelected(0,false);
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
        private void Population()
        {
            Con.Open();
            string Query = "SELECT* FROM BookingTbl";
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

        int Price = 0;
        int PriceServices = 0;
        private void FetchCostServices()
        {
            if (listBox1.SelectedItems.Count == 0)
                return;

            string format = "SELECT SUM(ServicesCost) FROM AdditionalServicesTbl WHERE ServicesNum in ({0})";
            string values = string.Join(",", listBox1.SelectedItems.OfType<DataRowView>().Select(row => row[0]));
            string query = string.Format(format, values);

            using (var con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\APEX\source\repos\HotelData\HotelData\DateBaseHotel.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                con.Open();
                using (var cmd = new SqlCommand(query, con))
                {
                    PriceServices = (int)cmd.ExecuteScalar();
                }
            }
        }
        private void fetchCostRooms()
        {
            Con.Open();
            string Query = "SELECT TypeCost FROM RoomTbl join TypeTbl on RType=TypeNum where RNum=" + RoomCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Price = Convert.ToInt32(dr["TypeCost"].ToString());
            }
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
        private void ArchiveBookings()
        {
            if (CustomerCb.SelectedIndex == -1 || RoomCb.SelectedIndex == -1 || AmountTb.Text == "" || DurationTb.Text == "" )
            {
                MessageBox.Show("Пропущенна информация !!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO ArchiveBookingsTbl(BookDateExit,Services1,Room1,Customer1,BookDate1,Duration1,Cost1,Status1) values(@Time,@Se,@R,@C,@BD,@Dura,@Cost,@Status)", Con);
                    
                    if (dateTimePicker1.Value == null)
                    {
                        cmd.Parameters.AddWithValue("@Time", dateTimePicker1.Value == null);

                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Time", dateTimePicker1.Value == null);

                    }
                    cmd.Parameters.AddWithValue("@Se", listBox1.Text);
                    cmd.Parameters.AddWithValue("@R", RoomCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@C", CustomerCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@BD", BDate.Value.Date);
                    cmd.Parameters.AddWithValue("@Dura", DurationTb.Text);
                    cmd.Parameters.AddWithValue("@Cost", AmountTb.Text);
                    cmd.Parameters.AddWithValue("@Status", StatusCb.SelectedItem.ToString());
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Комната в архиве");

                    Con.Close();
                    ArchivePopulation();
                    Population();
                   
                    GetRooms();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void TimeArchiveBookingExit()
        {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO ArchiveBookingsTbl(BookDateExit,Services1,Room1,Customer1,BookDate1,Duration1,Cost1,Status1) values(@Time,@Se,@R,@C,@BD,@Dura,@Cost,@Status)", Con);
                if (listBox1.SelectedItems.Count == 0)
                {
                    cmd.Parameters.AddWithValue("@Se", listBox1 == null);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Se", listBox1.SelectedValue.ToString());

                }
                cmd.Parameters.AddWithValue("@R", RoomCb.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@C", CustomerCb.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@BD", BDate.Value.Date);
                cmd.Parameters.AddWithValue("@Dura", DurationTb.Text);
                cmd.Parameters.AddWithValue("@Cost", AmountTb.Text);
                cmd.Parameters.AddWithValue("@Status", StatusCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Time", dateTimePicker1.Value);

                cmd.ExecuteNonQuery();
                    MessageBox.Show("Комната в архиве");
                    Con.Close();
                    ArchivePopulation();
                    Population();
                    GetRooms();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }
        private void BookBtn_Click(object sender, EventArgs e)
        {
            if (CustomerCb.SelectedIndex == -1 || AmountTb.Text == "" || DurationTb.Text == ""||StatusCb.SelectedIndex==-1 )
            {
                MessageBox.Show("Пропущенна информация !!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO BookingTbl(Services,Room,Customer,BookDate,Duration,Cost,Status) values(@Se,@R,@C,@BD,@Dura,@Cost,@Status)", Con);

                    if (listBox1.SelectedItems.Count == 0)
                    {
                        cmd.Parameters.AddWithValue("@Se", listBox1 == null);
                       

                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Se", listBox1.SelectedValue.ToString());
                      
                    }
                   

                    cmd.Parameters.AddWithValue("@R", RoomCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@C", CustomerCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@BD", BDate.Value.Date);
                    cmd.Parameters.AddWithValue("@Dura", DurationTb.Text);
                    cmd.Parameters.AddWithValue("@Cost", AmountTb.Text); 
                    cmd.Parameters.AddWithValue("@Status", StatusCb.SelectedItem.ToString());
                  
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Комната забронирована");
                  
                    Con.Close();

                    ArchiveBookings();
                    Population();
                    setBooked();
                    GetRooms();

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            DataTable dt = new DataTable();
            foreach (DataGridViewTextBoxColumn column in BookingsDGV.Columns)
            {
                dt.Columns.Add(column.Name, column.ValueType);
            }
            foreach (DataGridViewRow row in BookingsDGV.Rows)
            {
                DataRow dr = dt.NewRow();
                foreach (DataGridViewTextBoxColumn column in BookingsDGV.Columns)
                {
                    if (row.Cells[column.Name].Value != null)
                    {
                        dr[column.Name] = row.Cells[column.Name].Value.ToString();
                    }
                }
                dt.Rows.Add(dr);
            }
            string filePath = "C:\\Users\\APEX\\source\\repos\\HotelData\\HotelData\\ResultBookings.txt";
            DataTableToTextFile(dt, filePath);
            //MessageBox.Show("Сохранен в файл");
        }
        private void CancelBooking()
        {
            if (Key == 0)
            {
                MessageBox.Show("Выберите бронирование из списка ниже !!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM BookingTbl WHERE BookNum = @BKey", Con);
                    
                    
                    cmd.Parameters.AddWithValue("@BKey", Key);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Выбранное бронирование отменено", "Оповещание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                  
                    Population();
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void DurationTb_TextChanged(object sender, EventArgs e)
        {
            if (AmountTb.Text == "")
            {
                AmountTb.Text = " 0";
            }
            else
            {
                try
                {

                    int Total =Price* Convert.ToInt32(DurationTb.Text) + PriceServices * Convert.ToInt32(DurationTb.Text);
                    AmountTb.Text = "" + Total;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            CancelBooking();
            setAvaible();
            GetRooms();
            TimeArchiveBookingExit();
        }
        private void setBooked()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE RoomTbl SET RStatus=@RS where RNum = @RKey", Con);
                //cmd.Parameters.AddWithValue("@RS", "бронь");
                cmd.Parameters.AddWithValue("@RS", StatusCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@RKey", RoomCb.SelectedValue.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Статус комнаты изменен на бронь");
                Con.Close();
                Population();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void setAvaible()
        {

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE RoomTbl SET RStatus=@RS where RNum = @RKey", Con);
                cmd.Parameters.AddWithValue("@RS", "свободна");
                cmd.Parameters.AddWithValue("@RKey", RoomCb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Статус комнаты изменен на свободна");

                Con.Close();
                Population();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        private void BPrint_Click(object sender, EventArgs e)
        {
            ReportBookingsList Obj = new ReportBookingsList();
            Obj.Show();

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
                        }
                    }
                    sw.WriteLine();
                }
                sw.Close();
            }
        }
        private void DurationTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                MessageBox.Show("Пожалуйста используйте только цифры !", "Оповещание", MessageBoxButtons.OK, MessageBoxIcon.Information);

                e.Handled = true;
            }
        }
        private void RoomCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchCostRooms();
        }

        private void listBox1_EnabledChanged(object sender, EventArgs e)
        {
          
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                PriceServices = 0;
            }
            if (listBox1.SelectedIndex == 1 || listBox1.SelectedIndex ==0)
            {
                FetchCostServices();
            }
           
        }
    }
}
