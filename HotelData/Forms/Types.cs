using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace HotelData.Forms
{
    public partial class Types : Form
    {
        public Types()
        {
            InitializeComponent();
            Population();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\APEX\source\repos\HotelData\HotelData\DateBaseHotel.mdf;Integrated Security=True;Connect Timeout=30");
        private void Population()
        {
            Con.Open();
            string Query = "SELECT* FROM TypeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TypesDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void FilterStatusTypes()
        {
            Con.Open();
            string Query = "SELECT* FROM TypeTbl where TStatus= N'" + FilterStatusCb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TypesDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void InsertCategories()
        {
            if (TypeNameTb.Text == "" || CostTb.Text == "" || StatusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Пропущена информация !!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into TypeTbl(TypeName,TypeCost,TypeAnyInfo,TypeFromDate,TypeToDate,TStatus) values(@TN,@TC,@TI,@FD,@TD,@TS)", Con);
                    cmd.Parameters.AddWithValue("@TN", TypeNameTb.Text);
                    cmd.Parameters.AddWithValue("@TC", CostTb.Text);
                    cmd.Parameters.AddWithValue("@TI", AnyInfoTb.Text);
                    cmd.Parameters.AddWithValue("@TS", StatusCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@FD", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@TD", dateTimePicker2.Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Новая категория добавлена", "Оповещание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    Population();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void EditCategories()
        {
            if (TypeNameTb.Text == "" || CostTb.Text == "" || StatusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите категорию комнаты из списка ниже !!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE TypeTbl SET TypeName=@TN,TypeCost=@TC,TypeAnyInfo=@TI,TStatus=@TS,TypeFromDate=@FD,TypeToDate=@TD WHERE TypeNum = @TKey", Con);
                    cmd.Parameters.AddWithValue("@TN", TypeNameTb.Text);
                    cmd.Parameters.AddWithValue("@TC", CostTb.Text);
                    cmd.Parameters.AddWithValue("@TI", AnyInfoTb.Text);
                    cmd.Parameters.AddWithValue("@TS", StatusCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@FD", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@TD", dateTimePicker2.Value);
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Выбранная категория комнаты отредактирована", "Оповещание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    Population();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void DeleteCategories()
        {
            if (Key == 0)
            {
                MessageBox.Show("Выберите категорию комнаты из списка ниже !!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM TypeTbl WHERE TypeNum = @TKey", Con);
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Выбранная категория комнаты удалена", "Оповещание", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            EditCategories();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            InsertCategories();
            DataTable dt = new DataTable();
            foreach (DataGridViewTextBoxColumn column in TypesDGV.Columns)
            {
                dt.Columns.Add(column.Name, column.ValueType);
            }
            foreach (DataGridViewRow row in TypesDGV.Rows)
            {
                DataRow dr = dt.NewRow();
                foreach (DataGridViewTextBoxColumn column in TypesDGV.Columns)
                {
                    if (row.Cells[column.Name].Value != null)
                    {
                        dr[column.Name] = row.Cells[column.Name].Value.ToString();
                    }
                }
                dt.Rows.Add(dr);
            }
            string filePath = "C:\\Users\\APEX\\source\\repos\\HotelData\\HotelData\\ResultTypes.txt";
            DataTableToTextFile(dt, filePath);
            //MessageBox.Show("Сохранен в файл");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteCategories();
        }
        int Key = 0;
        private void TypesDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            TypeNameTb.Text = TypesDGV.SelectedRows[0].Cells[1].Value.ToString();
            CostTb.Text = TypesDGV.SelectedRows[0].Cells[2].Value.ToString();
            AnyInfoTb.Text = TypesDGV.SelectedRows[0].Cells[3].Value.ToString();
          
            dateTimePicker1.Text = TypesDGV.SelectedRows[0].Cells[4].Value.ToString();
            dateTimePicker2.Text = TypesDGV.SelectedRows[0].Cells[5].Value.ToString();
            StatusCb.Text = TypesDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (TypeNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(TypesDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void BPrint_Click(object sender, EventArgs e)
        {
            ReportPriceList Obj = new ReportPriceList();
            Obj.Show();
        }

        private void TypeNameTb_Load(object sender, EventArgs e)
        {
            TypeNameTb.Focus();
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

        private void CostTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                MessageBox.Show("Пожалуйста используйте только цифры !", "Оповещание", MessageBoxButtons.OK, MessageBoxIcon.Information);

                e.Handled = true;
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
                FilterStatusTypes();
            }
        }

        private void TSearch_TextChanged(object sender, EventArgs e)
        {
            (TypesDGV.DataSource as DataTable).DefaultView.RowFilter = $"TypeName LIKE '%{TSearch.Text}%'";
        }
    }
}
