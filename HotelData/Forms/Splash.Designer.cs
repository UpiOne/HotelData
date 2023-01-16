
namespace HotelData.Forms
{
    partial class Splash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ContinueLb = new System.Windows.Forms.Label();
            this.WaitCircleProgress = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelTitleBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(116)))), ((int)(((byte)(153)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(637, 80);
            this.panelTitleBar.TabIndex = 35;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(104, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(567, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Система управления гостиницей";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(116)))), ((int)(((byte)(153)))));
            this.panel2.Controls.Add(this.ContinueLb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 430);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 80);
            this.panel2.TabIndex = 36;
            // 
            // ContinueLb
            // 
            this.ContinueLb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ContinueLb.AutoSize = true;
            this.ContinueLb.BackColor = System.Drawing.Color.Transparent;
            this.ContinueLb.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueLb.ForeColor = System.Drawing.Color.White;
            this.ContinueLb.Location = new System.Drawing.Point(261, 26);
            this.ContinueLb.Name = "ContinueLb";
            this.ContinueLb.Size = new System.Drawing.Size(0, 31);
            this.ContinueLb.TabIndex = 30;
            this.ContinueLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WaitCircleProgress
            // 
            this.WaitCircleProgress.Animated = false;
            this.WaitCircleProgress.AnimationInterval = 1;
            this.WaitCircleProgress.AnimationSpeed = 1;
            this.WaitCircleProgress.BackColor = System.Drawing.Color.Transparent;
            this.WaitCircleProgress.CircleMargin = 10;
            this.WaitCircleProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.WaitCircleProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(116)))), ((int)(((byte)(153)))));
            this.WaitCircleProgress.IsPercentage = false;
            this.WaitCircleProgress.LineProgressThickness = 10;
            this.WaitCircleProgress.LineThickness = 10;
            this.WaitCircleProgress.Location = new System.Drawing.Point(197, 134);
            this.WaitCircleProgress.Name = "WaitCircleProgress";
            this.WaitCircleProgress.ProgressAnimationSpeed = 200;
            this.WaitCircleProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.WaitCircleProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(116)))), ((int)(((byte)(153)))));
            this.WaitCircleProgress.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.WaitCircleProgress.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.WaitCircleProgress.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.WaitCircleProgress.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.WaitCircleProgress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.WaitCircleProgress.Size = new System.Drawing.Size(229, 229);
            this.WaitCircleProgress.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.WaitCircleProgress.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.WaitCircleProgress.SubScriptText = "";
            this.WaitCircleProgress.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.WaitCircleProgress.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.WaitCircleProgress.SuperScriptText = "";
            this.WaitCircleProgress.TabIndex = 16;
            this.WaitCircleProgress.Text = "30";
            this.WaitCircleProgress.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.WaitCircleProgress.Value = 30;
            this.WaitCircleProgress.ValueByTransition = 30;
            this.WaitCircleProgress.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(120, 105);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(285, 23);
            this.progressBar1.TabIndex = 37;
            this.progressBar1.Visible = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Splash
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(637, 510);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.WaitCircleProgress);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ContinueLb;
        private Bunifu.UI.WinForms.BunifuCircleProgress WaitCircleProgress;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}