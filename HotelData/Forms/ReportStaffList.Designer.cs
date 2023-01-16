
namespace HotelData.Forms
{
    partial class ReportStaffList
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
            this.staffTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateBaseHotelDataSet = new HotelData.DateBaseHotelDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.staffTblTableAdapter = new HotelData.DateBaseHotelDataSet1TableAdapters.StaffTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.staffTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaseHotelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // staffTblBindingSource
            // 
            this.staffTblBindingSource.DataMember = "StaffTbl";
            this.staffTblBindingSource.DataSource = this.dateBaseHotelDataSet;
            // 
            // dateBaseHotelDataSet
            // 
            this.dateBaseHotelDataSet.DataSetName = "DateBaseHotelDataSet";
            this.dateBaseHotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.staffTblBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HotelData.Reports.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1182, 656);
            this.reportViewer1.TabIndex = 1;
            // 
            // staffTblTableAdapter
            // 
            this.staffTblTableAdapter.ClearBeforeFill = true;
            // 
            // ReportStaffList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 656);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportStaffList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет персонала";
            this.Load += new System.EventHandler(this.RepotStaffList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaseHotelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DateBaseHotelDataSet1 dateBaseHotelDataSet;
        private System.Windows.Forms.BindingSource staffTblBindingSource;
        private DateBaseHotelDataSet1TableAdapters.StaffTblTableAdapter staffTblTableAdapter;
    }
}