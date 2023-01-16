
namespace HotelData.Forms
{
    partial class ReportBookingsList
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bookingTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateBaseHotelDataSet1 = new HotelData.DateBaseHotelDataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.FilterStatusCb = new System.Windows.Forms.ComboBox();
            this.customerTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bookingTblTableAdapter = new HotelData.DateBaseHotelDataSet1TableAdapters.BookingTblTableAdapter();
            this.customerTblTableAdapter = new HotelData.DateBaseHotelDataSet1TableAdapters.CustomerTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaseHotelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bookingTblBindingSource
            // 
            this.bookingTblBindingSource.DataMember = "BookingTbl";
            this.bookingTblBindingSource.DataSource = this.dateBaseHotelDataSet1;
            // 
            // dateBaseHotelDataSet1
            // 
            this.dateBaseHotelDataSet1.DataSetName = "DateBaseHotelDataSet1";
            this.dateBaseHotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(520, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 21);
            this.label4.TabIndex = 59;
            this.label4.Text = "Выбор клиента";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterStatusCb
            // 
            this.FilterStatusCb.AccessibleName = "";
            this.FilterStatusCb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FilterStatusCb.DataSource = this.customerTblBindingSource;
            this.FilterStatusCb.DisplayMember = "CustName";
            this.FilterStatusCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterStatusCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterStatusCb.FormattingEnabled = true;
            this.FilterStatusCb.Location = new System.Drawing.Point(436, 109);
            this.FilterStatusCb.Name = "FilterStatusCb";
            this.FilterStatusCb.Size = new System.Drawing.Size(313, 33);
            this.FilterStatusCb.TabIndex = 58;
            this.FilterStatusCb.SelectedIndexChanged += new System.EventHandler(this.FilterStatusCb_SelectedIndexChanged);
            // 
            // customerTblBindingSource
            // 
            this.customerTblBindingSource.DataMember = "CustomerTbl";
            this.customerTblBindingSource.DataSource = this.dateBaseHotelDataSet1;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bookingTblBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HotelData.Reports.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(76, 150);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1075, 584);
            this.reportViewer1.TabIndex = 60;
            // 
            // bookingTblTableAdapter
            // 
            this.bookingTblTableAdapter.ClearBeforeFill = true;
            // 
            // customerTblTableAdapter
            // 
            this.customerTblTableAdapter.ClearBeforeFill = true;
            // 
            // ReportBookingsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 723);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FilterStatusCb);
            this.Name = "ReportBookingsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет общей статистики бронирования/счет клиенту";
            this.Load += new System.EventHandler(this.ReportBookingsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaseHotelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox FilterStatusCb;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DateBaseHotelDataSet1 dateBaseHotelDataSet1;
        private System.Windows.Forms.BindingSource bookingTblBindingSource;
        private DateBaseHotelDataSet1TableAdapters.BookingTblTableAdapter bookingTblTableAdapter;
        private System.Windows.Forms.BindingSource customerTblBindingSource;
        private DateBaseHotelDataSet1TableAdapters.CustomerTblTableAdapter customerTblTableAdapter;
    }
}