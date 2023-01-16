using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace HotelData.Forms
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            Population();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\APEX\source\repos\HotelData\HotelData\DateBaseHotel.mdf;Integrated Security=True;Connect Timeout=30");

        private void Population()
        {
            Con.Open();
            string Query = "SELECT* FROM CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustomersDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void InsertCustomers()
        {
            if (CNameTb.Text == "" || GenderCb.SelectedIndex == -1 || PhoneTb.Text == "")
            {
                MessageBox.Show("Пропущена информация !!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CustomerTbl(CustName,CustPhone,CustGender,CustMail,CustHomeAddress,CustPassport,CustDateOfBirth,CustAnyInfo,CStatus) values(@CN,@CP,@CG,@CM,@CH,@CPas,@CD,@CAI,@CS)", Con);
                    cmd.Parameters.AddWithValue("@CN", CNameTb.Text);
                    cmd.Parameters.AddWithValue("@CP", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@CG", GenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CM", CustMailTb.Text);
                    cmd.Parameters.AddWithValue("@CH", CustAddressTb.Text);
                    cmd.Parameters.AddWithValue("@CPas", CustPassportTb.Text);
                    cmd.Parameters.AddWithValue("@CD", CustDate.Value.Date);
                    cmd.Parameters.AddWithValue("@CAI", AnyInfoTb.Text);
                    cmd.Parameters.AddWithValue("@CS", StatusCb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Новый клиент добавлен", "Оповещание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    Population();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void EditCustomers()
        {
            if (CNameTb.Text == "" || GenderCb.SelectedIndex == -1 || PhoneTb.Text == "")
            {
                MessageBox.Show("Выберите клиента из списка ниже !!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE CustomerTbl SET CustName=@CN,CustPhone=@CP,CustGender=@CG,CustMail=@CM,CustHomeAddress=@CH,CustPassport=@CPas,CustDateOfBirth=@CD,CustAnyInfo=@CAI,CStatus=@CS WHERE CustNum = @CKey", Con);
                    cmd.Parameters.AddWithValue("@CN", CNameTb.Text);
                    cmd.Parameters.AddWithValue("@CP", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@CG", GenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CM", CustMailTb.Text);
                    cmd.Parameters.AddWithValue("@CH", CustAddressTb.Text);
                    cmd.Parameters.AddWithValue("@CPas", CustPassportTb.Text);
                    cmd.Parameters.AddWithValue("@CD", CustDate.Value.Date);
                    cmd.Parameters.AddWithValue("@CAI", AnyInfoTb.Text);
                    cmd.Parameters.AddWithValue("@CS", StatusCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Выбранный клиент отредактирован", "Оповещание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    Population();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void DeleteCustomers()
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
                    SqlCommand cmd = new SqlCommand("DELETE FROM CustomerTbl WHERE CustNum = @CKey", Con);
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Выбранный Клиент удален", "Оповещание", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            EditCustomers();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            InsertCustomers();
            DataTable dt = new DataTable();
            foreach (DataGridViewTextBoxColumn column in CustomersDGV.Columns)
            {
                dt.Columns.Add(column.Name, column.ValueType);
            }
            foreach (DataGridViewRow row in CustomersDGV.Rows)
            {
                DataRow dr = dt.NewRow();
                foreach (DataGridViewTextBoxColumn column in CustomersDGV.Columns)
                {
                    if (row.Cells[column.Name].Value != null)
                    {
                        dr[column.Name] = row.Cells[column.Name].Value.ToString();
                    }
                }
                dt.Rows.Add(dr);
            }
            string filePath = "C:\\Users\\APEX\\source\\repos\\HotelData\\HotelData\\ResultCustomers.txt";
            DataTableToTextFile(dt, filePath);
           // MessageBox.Show("Сохранен в файл");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteCustomers();
        }

        private void СustSearch_TextChanged(object sender, EventArgs e)
        {
            (CustomersDGV.DataSource as DataTable).DefaultView.RowFilter = $"CustName LIKE '%{СustSearch.Text}%'";
          
        }
        int Key = 0;
        private void CustomersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
            CNameTb.Text = CustomersDGV.SelectedRows[0].Cells[1].Value.ToString();
            GenderCb.Text = CustomersDGV.SelectedRows[0].Cells[2].Value.ToString();
            CustAddressTb.Text = CustomersDGV.SelectedRows[0].Cells[3].Value.ToString();
            CustDate.Text = CustomersDGV.SelectedRows[0].Cells[4].Value.ToString();
            CustPassportTb.Text = CustomersDGV.SelectedRows[0].Cells[5].Value.ToString();
            PhoneTb.Text = CustomersDGV.SelectedRows[0].Cells[6].Value.ToString();
            CustMailTb.Text = CustomersDGV.SelectedRows[0].Cells[7].Value.ToString();
            AnyInfoTb.Text = CustomersDGV.SelectedRows[0].Cells[8].Value.ToString();
            StatusCb.Text = CustomersDGV.SelectedRows[0].Cells[9].Value.ToString();
            if (CNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {   
                Key = Convert.ToInt32(CustomersDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void CNameTb_Load(object sender, EventArgs e)
        {
            CNameTb.Focus();
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
                    sw.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
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

        private void BPrint_Click(object sender, EventArgs e)
        {
            ReportCustomerList Obj = new ReportCustomerList();
            Obj.Show();

            Obj.button1_Click(sender, e);
        }
    }
}
