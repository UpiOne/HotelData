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
    public partial class Additional_services : Form
    {
        public Additional_services()
        {
            InitializeComponent();
            Population();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\APEX\source\repos\HotelData\HotelData\DateBaseHotel.mdf;Integrated Security=True;Connect Timeout=30");
        private void Population()
        {
            Con.Open();
            string Query = "SELECT* FROM AdditionalServicesTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AdditionalServicesDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void InsertAdditionalServices()
        {
            if (ServicesNameTb.Text == "" || CostTb.Text == "" || AnyInfoTb.Text == "")
            {
                MessageBox.Show("Пропущена информация !!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AdditionalServicesTbl(ServicesName,ServicesCost,ServicesAnyInfo) values(@SN,@SC,@SI)", Con);
                    cmd.Parameters.AddWithValue("@SN", ServicesNameTb.Text);
                    cmd.Parameters.AddWithValue("@SC", CostTb.Text);
                    cmd.Parameters.AddWithValue("@SI", AnyInfoTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Новая услуга добавлена", "Оповещание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    Population();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void EditAdditionalServices()
        {
            if (ServicesNameTb.Text == "" || CostTb.Text == "" || AnyInfoTb.Text == "")
            {
                MessageBox.Show("Выберите категорию комнаты из списка ниже !!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE AdditionalServicesTbl SET ServicesName=@SN,ServicesCost=@SC,ServicesAnyInfo=@SI WHERE ServicesNum = @SeKey", Con);
                    cmd.Parameters.AddWithValue("@SN", ServicesNameTb.Text);
                    cmd.Parameters.AddWithValue("@SC", CostTb.Text);
                    cmd.Parameters.AddWithValue("@SI", AnyInfoTb.Text);
                    cmd.Parameters.AddWithValue("@SeKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Выбранная услуга отредактирована", "Оповещание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    Population();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void DeleteAdditionalServices()
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
                    SqlCommand cmd = new SqlCommand("DELETE FROM AdditionalServicesTbl WHERE ServicesNum = @SeKey", Con);
                    cmd.Parameters.AddWithValue("@SeKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Выбранная услуга удалена", "Оповещание", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            EditAdditionalServices();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            InsertAdditionalServices();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteAdditionalServices();
        }
        int Key = 0;
        private void AdditionalServicesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ServicesNameTb.Text = AdditionalServicesDGV.SelectedRows[0].Cells[1].Value.ToString();
            CostTb.Text = AdditionalServicesDGV.SelectedRows[0].Cells[2].Value.ToString();
            AnyInfoTb.Text = AdditionalServicesDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (ServicesNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(AdditionalServicesDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void ServicesNameTb_Load(object sender, EventArgs e)
        {
            ServicesNameTb.Focus();
        }

        private void BPrint_Click(object sender, EventArgs e)
        {
            ReportServiceList Obj = new ReportServiceList();
            Obj.Show();

            Obj.button1_Click(sender, e);
        }
    }
}
