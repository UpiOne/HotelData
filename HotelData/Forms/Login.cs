using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelData.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\APEX\source\repos\HotelData\HotelData\DateBaseHotel.mdf;Integrated Security=True;Connect Timeout=30");

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            
            ULoginTb.Focus();
            PasswordTb.PasswordChar = '*';
            if (ULoginTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Пропущена информация", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ULoginTb.Focus();
            }
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT count(*) FROM UserTbl where ULogin='" + ULoginTb.Text + "' and UPassword='" + PasswordTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show(LoginSaveID.ulogin = ULoginTb.Text + " вошел(а) в систему", "Вход выполнен успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginSaveID.ulogin = ULoginTb.Text;
                    MainMenu Obj = new MainMenu();
                    Obj.Show();
                    this.Hide();

                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Неверное имя пользователя или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bunifuSnackbar1.Show(this, "ss", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error,1000, "",
                    Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomCenter,
                    Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
                    ULoginTb.Clear();
                    PasswordTb.Clear();
                    ULoginTb.Focus();
                }
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ContinueLb_Click(object sender, EventArgs e)
        {
            Forms.AdminLogin Obj = new Forms.AdminLogin();
            Obj.Show();
            this.Hide();
        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            DialogResult res;
            
            res = MessageBox.Show("Вы точно хотите выйти?", "Выйти", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
           
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
     
    }
}
