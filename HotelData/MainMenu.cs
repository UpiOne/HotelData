using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HotelData
{
   
    public partial class MainMenu : Form
    {
        private bool isCollapsed;
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public MainMenu()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            CheakID();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void CheakID()
        {
            
            loginID.Text = LoginSaveID.ulogin;
            if (LoginSaveID.ulogin !=null)
            {
                panel5.Visible = false;
                btnUsers.Visible = false;
                btnStaffs.Visible = false;
                btnArchiveBookings.Visible = false;
            }
            if(LoginSaveID.ulogin =="admin")
            {
                panel5.Visible = true;
                btnUsers.Visible = true;
                btnStaffs.Visible = true;
                btnArchiveBookings.Visible = true;
            }
        }
        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Times New Roman", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel3.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 90);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
            foreach (Control previousBtn in panel4.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 90);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
            foreach (Control previousBtn in panel5.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 90);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDekstopPane.Controls.Add(childForm);
            this.panelDekstopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        private void btnRooms_Click_1(object sender, EventArgs e)
        {
            
            OpenChildForm(new Forms.Rooms(), sender);
        }

        private void btnTypes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Types(), sender);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Users(), sender);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Customers(), sender);
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Bookings(), sender);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Dashboard(), sender);
        }
        private void Exit_Click_1(object sender, EventArgs e)
        {
            Forms.Login Obj = new Forms.Login();
            Obj.Show();
            this.Hide();
        }

        private void BtnCloseChildrenForms_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "Система управления гостиницы";
            panelTitleBar.BackColor = Color.FromArgb(47, 116, 153);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
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

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath("Resources/addd.ico"));
            notifyIcon1.Text = "Отель";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = "Отель";
            notifyIcon1.BalloonTipText = "Приложение было свернуто";
            notifyIcon1.ShowBalloonTip(100);
        }

        private void MainMenu_Load_1(object sender, EventArgs e)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            string dataNow = DateTime.Now.ToString("dd MMMM yyyy");
            label3.Text = "" + dataNow;
           
        }
        //вывод 
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            circularProgressBar1.Invoke((MethodInvoker)delegate
            {
                circularProgressBar1.Text = DateTime.Now.ToString("HH:mm:ss");
                circularProgressBar1.Value = Convert.ToInt32(DateTime.Now.Second);
            });
        }

        private void btnStaffs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Staffs(), sender);
        }

        private void btnStaffsJobs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.StaffsJobs(), sender);
        }

        private void btnAdditionalServices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Additional_services(), sender);
        }

        private void btnArchiveBookings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ArchiveBookings(), sender);
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                pictureBox2.Image = HotelData.Properties.Resources.Collapse_Arrow_20px;
             
                panel3.Height += 10;
              
                if (panel3.Size == panel3.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
           
            }
            else
            {
                pictureBox2.Image = HotelData.Properties.Resources.Expand_Arrow_20px;
                panel3.Height -= 10;
                if (panel3.Size == panel3.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
             
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnTypes_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Types(), sender);
        }

        private void btnCustomers_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Customers(), sender);
        }

        private void btnAdditionalServices_Click_1(object sender, EventArgs e)
        {

            OpenChildForm(new Forms.Additional_services(), sender);
        }

        private void btnStaffsJobs_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.StaffsJobs(), sender);
        }

        private void btnStaffs_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Staffs(), sender);
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Dashboard(), sender);
        }

        private void btnStaffsJobs_Click_2(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.StaffsJobs(), sender);
        }

        private void btnBookings_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Bookings(), sender);
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Rooms(), sender);
        }

        private void btnUsers_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Users(), sender);
        }

        private void btnArchiveBookings_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ArchiveBookings(), sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer2.Start();
           

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (isCollapsed)
            {
                pictureBox3.Image = HotelData.Properties.Resources.Collapse_Arrow_20px;

                panel4.Height += 10;

                if (panel4.Size == panel4.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }

            }
            else
            {
                pictureBox3.Image = HotelData.Properties.Resources.Expand_Arrow_20px;
                panel4.Height -= 10;
                if (panel4.Size == panel4.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            if (isCollapsed)
            {
                pictureBox4.Image = HotelData.Properties.Resources.Collapse_Arrow_20px;

                panel5.Height += 10;

                if (panel5.Size == panel5.MaximumSize)
                {
                    timer3.Stop();
                    isCollapsed = false;
                }

            }
            else
            {
                pictureBox4.Image = HotelData.Properties.Resources.Expand_Arrow_20px;
                panel5.Height -= 10;
                if (panel5.Size == panel5.MinimumSize)
                {
                    timer3.Stop();
                    isCollapsed = true;
                }

            }
        }

        private void btnStaffs_Click_2(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Staffs(), sender);
        }
    }
}
