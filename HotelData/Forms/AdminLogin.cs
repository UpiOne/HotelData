using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelData.Forms
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (PasswordTb.Text == "")
            {
                MessageBox.Show("Введите пароль Администратора !!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (PasswordTb.Text == "admin")
                {
                    MessageBox.Show("Администратор вошел в систему !", "Вход выполнен успешно", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    LoginSaveID.ulogin = PasswordTb.Text;
                    MainMenu Obj = new MainMenu();
                    Obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверный пароль администратора !!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PasswordTb.Clear();


                    PasswordTb.Focus();

                }
            }
        }
        private void closePic_Click_1(object sender, EventArgs e)
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
        private void CancelLb_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

    }
}
