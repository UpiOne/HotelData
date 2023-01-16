
namespace HotelData.Forms
{
    partial class StaffsJobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffsJobs));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BPrint = new System.Windows.Forms.PictureBox();
            this.EditBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.StaffsJobsDGV = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.SaveBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StatusCb = new System.Windows.Forms.ComboBox();
            this.StaffCb = new System.Windows.Forms.ComboBox();
            this.RoomCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffsJobsDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.StaffsJobsDGV);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 590);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.BPrint);
            this.groupBox2.Location = new System.Drawing.Point(974, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 177);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(34, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 27);
            this.label6.TabIndex = 47;
            this.label6.Text = "Печать";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BPrint
            // 
            this.BPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BPrint.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.BPrint.Image = ((System.Drawing.Image)(resources.GetObject("BPrint.Image")));
            this.BPrint.Location = new System.Drawing.Point(46, 59);
            this.BPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BPrint.Name = "BPrint";
            this.BPrint.Size = new System.Drawing.Size(63, 65);
            this.BPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BPrint.TabIndex = 29;
            this.BPrint.TabStop = false;
            this.BPrint.Click += new System.EventHandler(this.BPrint_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.AllowAnimations = true;
            this.EditBtn.AllowMouseEffects = true;
            this.EditBtn.AllowToggling = false;
            this.EditBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditBtn.AnimationSpeed = 200;
            this.EditBtn.AutoGenerateColors = false;
            this.EditBtn.AutoRoundBorders = false;
            this.EditBtn.AutoSizeLeftIcon = true;
            this.EditBtn.AutoSizeRightIcon = true;
            this.EditBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(119)))), ((int)(((byte)(212)))));
            this.EditBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditBtn.BackgroundImage")));
            this.EditBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EditBtn.ButtonText = "Обновить";
            this.EditBtn.ButtonTextMarginLeft = 0;
            this.EditBtn.ColorContrastOnClick = 45;
            this.EditBtn.ColorContrastOnHover = 45;
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.EditBtn.CustomizableEdges = borderEdges1;
            this.EditBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EditBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.EditBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.EditBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.EditBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.EditBtn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.EditBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.EditBtn.IconMarginLeft = 11;
            this.EditBtn.IconPadding = 10;
            this.EditBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.EditBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.EditBtn.IconSize = 25;
            this.EditBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(119)))), ((int)(((byte)(212)))));
            this.EditBtn.IdleBorderRadius = 30;
            this.EditBtn.IdleBorderThickness = 1;
            this.EditBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(119)))), ((int)(((byte)(212)))));
            this.EditBtn.IdleIconLeftImage = null;
            this.EditBtn.IdleIconRightImage = null;
            this.EditBtn.IndicateFocus = false;
            this.EditBtn.Location = new System.Drawing.Point(613, 237);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.EditBtn.OnDisabledState.BorderRadius = 30;
            this.EditBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EditBtn.OnDisabledState.BorderThickness = 1;
            this.EditBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.EditBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.EditBtn.OnDisabledState.IconLeftImage = null;
            this.EditBtn.OnDisabledState.IconRightImage = null;
            this.EditBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.EditBtn.onHoverState.BorderRadius = 30;
            this.EditBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EditBtn.onHoverState.BorderThickness = 1;
            this.EditBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.EditBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.EditBtn.onHoverState.IconLeftImage = null;
            this.EditBtn.onHoverState.IconRightImage = null;
            this.EditBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(119)))), ((int)(((byte)(212)))));
            this.EditBtn.OnIdleState.BorderRadius = 30;
            this.EditBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EditBtn.OnIdleState.BorderThickness = 1;
            this.EditBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(119)))), ((int)(((byte)(212)))));
            this.EditBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.EditBtn.OnIdleState.IconLeftImage = null;
            this.EditBtn.OnIdleState.IconRightImage = null;
            this.EditBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.EditBtn.OnPressedState.BorderRadius = 30;
            this.EditBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EditBtn.OnPressedState.BorderThickness = 1;
            this.EditBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.EditBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.EditBtn.OnPressedState.IconLeftImage = null;
            this.EditBtn.OnPressedState.IconRightImage = null;
            this.EditBtn.Size = new System.Drawing.Size(150, 50);
            this.EditBtn.TabIndex = 30;
            this.EditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.EditBtn.TextMarginLeft = 0;
            this.EditBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.EditBtn.UseDefaultRadiusAndThickness = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // StaffsJobsDGV
            // 
            this.StaffsJobsDGV.AllowCustomTheming = false;
            this.StaffsJobsDGV.AllowUserToAddRows = false;
            this.StaffsJobsDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.StaffsJobsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StaffsJobsDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StaffsJobsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StaffsJobsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaffsJobsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StaffsJobsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StaffsJobsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StaffsJobsDGV.ColumnHeadersHeight = 40;
            this.StaffsJobsDGV.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.StaffsJobsDGV.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.StaffsJobsDGV.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.StaffsJobsDGV.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.StaffsJobsDGV.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.StaffsJobsDGV.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.StaffsJobsDGV.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.StaffsJobsDGV.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.StaffsJobsDGV.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.StaffsJobsDGV.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StaffsJobsDGV.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.StaffsJobsDGV.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.StaffsJobsDGV.CurrentTheme.Name = null;
            this.StaffsJobsDGV.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.StaffsJobsDGV.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.StaffsJobsDGV.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.StaffsJobsDGV.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.StaffsJobsDGV.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StaffsJobsDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.StaffsJobsDGV.EnableHeadersVisualStyles = false;
            this.StaffsJobsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.StaffsJobsDGV.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.StaffsJobsDGV.HeaderBgColor = System.Drawing.Color.Empty;
            this.StaffsJobsDGV.HeaderForeColor = System.Drawing.Color.White;
            this.StaffsJobsDGV.Location = new System.Drawing.Point(0, 307);
            this.StaffsJobsDGV.Margin = new System.Windows.Forms.Padding(4);
            this.StaffsJobsDGV.Name = "StaffsJobsDGV";
            this.StaffsJobsDGV.ReadOnly = true;
            this.StaffsJobsDGV.RowHeadersVisible = false;
            this.StaffsJobsDGV.RowHeadersWidth = 51;
            this.StaffsJobsDGV.RowTemplate.Height = 40;
            this.StaffsJobsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StaffsJobsDGV.Size = new System.Drawing.Size(1140, 283);
            this.StaffsJobsDGV.TabIndex = 29;
            this.StaffsJobsDGV.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.StaffsJobsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffsJobsDGV_CellContentClick);
            // 
            // SaveBtn
            // 
            this.SaveBtn.AllowAnimations = true;
            this.SaveBtn.AllowMouseEffects = true;
            this.SaveBtn.AllowToggling = false;
            this.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SaveBtn.AnimationSpeed = 200;
            this.SaveBtn.AutoGenerateColors = false;
            this.SaveBtn.AutoRoundBorders = false;
            this.SaveBtn.AutoSizeLeftIcon = true;
            this.SaveBtn.AutoSizeRightIcon = true;
            this.SaveBtn.BackColor = System.Drawing.Color.Transparent;
            this.SaveBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(0)))));
            this.SaveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveBtn.BackgroundImage")));
            this.SaveBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveBtn.ButtonText = "Добавить";
            this.SaveBtn.ButtonTextMarginLeft = 0;
            this.SaveBtn.ColorContrastOnClick = 45;
            this.SaveBtn.ColorContrastOnHover = 45;
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.SaveBtn.CustomizableEdges = borderEdges2;
            this.SaveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SaveBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SaveBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SaveBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.SaveBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SaveBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SaveBtn.IconMarginLeft = 11;
            this.SaveBtn.IconPadding = 10;
            this.SaveBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SaveBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SaveBtn.IconSize = 25;
            this.SaveBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(0)))));
            this.SaveBtn.IdleBorderRadius = 30;
            this.SaveBtn.IdleBorderThickness = 1;
            this.SaveBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(0)))));
            this.SaveBtn.IdleIconLeftImage = null;
            this.SaveBtn.IdleIconRightImage = null;
            this.SaveBtn.IndicateFocus = false;
            this.SaveBtn.Location = new System.Drawing.Point(382, 237);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SaveBtn.OnDisabledState.BorderRadius = 30;
            this.SaveBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveBtn.OnDisabledState.BorderThickness = 1;
            this.SaveBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SaveBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SaveBtn.OnDisabledState.IconLeftImage = null;
            this.SaveBtn.OnDisabledState.IconRightImage = null;
            this.SaveBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.SaveBtn.onHoverState.BorderRadius = 30;
            this.SaveBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveBtn.onHoverState.BorderThickness = 1;
            this.SaveBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.SaveBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.onHoverState.IconLeftImage = null;
            this.SaveBtn.onHoverState.IconRightImage = null;
            this.SaveBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(0)))));
            this.SaveBtn.OnIdleState.BorderRadius = 30;
            this.SaveBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveBtn.OnIdleState.BorderThickness = 1;
            this.SaveBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(0)))));
            this.SaveBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.OnIdleState.IconLeftImage = null;
            this.SaveBtn.OnIdleState.IconRightImage = null;
            this.SaveBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SaveBtn.OnPressedState.BorderRadius = 30;
            this.SaveBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveBtn.OnPressedState.BorderThickness = 1;
            this.SaveBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SaveBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.OnPressedState.IconLeftImage = null;
            this.SaveBtn.OnPressedState.IconRightImage = null;
            this.SaveBtn.Size = new System.Drawing.Size(150, 50);
            this.SaveBtn.TabIndex = 27;
            this.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveBtn.TextMarginLeft = 0;
            this.SaveBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.SaveBtn.UseDefaultRadiusAndThickness = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.SDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.StatusCb);
            this.groupBox1.Controls.Add(this.StaffCb);
            this.groupBox1.Controls.Add(this.RoomCb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.groupBox1.Location = new System.Drawing.Point(28, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(924, 182);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // SDate
            // 
            this.SDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SDate.CustomFormat = "";
            this.SDate.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SDate.Location = new System.Drawing.Point(489, 91);
            this.SDate.Name = "SDate";
            this.SDate.Size = new System.Drawing.Size(144, 34);
            this.SDate.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(696, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 55;
            this.label5.Text = "Выбор работы";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(497, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 54;
            this.label4.Text = "Выбор даты";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(266, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "Выбор ID персонала";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(58, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "Выбор ID комнаты";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusCb
            // 
            this.StatusCb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StatusCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusCb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusCb.FormattingEnabled = true;
            this.StatusCb.Items.AddRange(new object[] {
            "Уборка выполнена",
            "Уборка не выполнена"});
            this.StatusCb.Location = new System.Drawing.Point(680, 91);
            this.StatusCb.Margin = new System.Windows.Forms.Padding(4);
            this.StatusCb.Name = "StatusCb";
            this.StatusCb.Size = new System.Drawing.Size(185, 30);
            this.StatusCb.TabIndex = 51;
            // 
            // StaffCb
            // 
            this.StaffCb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StaffCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StaffCb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffCb.FormattingEnabled = true;
            this.StaffCb.Items.AddRange(new object[] {
            "Booked",
            "Avaible"});
            this.StaffCb.Location = new System.Drawing.Point(271, 91);
            this.StaffCb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StaffCb.Name = "StaffCb";
            this.StaffCb.Size = new System.Drawing.Size(185, 30);
            this.StaffCb.TabIndex = 50;
            // 
            // RoomCb
            // 
            this.RoomCb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RoomCb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomCb.FormattingEnabled = true;
            this.RoomCb.Location = new System.Drawing.Point(54, 91);
            this.RoomCb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RoomCb.Name = "RoomCb";
            this.RoomCb.Size = new System.Drawing.Size(185, 30);
            this.RoomCb.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(509, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 27);
            this.label1.TabIndex = 47;
            this.label1.Text = "Ввод данных";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StaffsJobs
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1140, 590);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffsJobs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Контроль персонала";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffsJobsDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuDataGridView StaffsJobsDGV;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SaveBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StaffCb;
        private System.Windows.Forms.ComboBox RoomCb;
        private System.Windows.Forms.ComboBox StatusCb;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton EditBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker SDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox BPrint;
    }
}