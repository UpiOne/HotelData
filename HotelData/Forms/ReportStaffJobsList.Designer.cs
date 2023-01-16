
namespace HotelData.Forms
{
    partial class ReportStaffJobsList
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateBaseHotelDataSet = new HotelData.DateBaseHotelDataSet1();
            this.staffsJobsTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffsJobsTblTableAdapter = new HotelData.DateBaseHotelDataSet1TableAdapters.StaffsJobsTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaseHotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsJobsTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.staffsJobsTblBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HotelData.Reports.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1182, 656);
            this.reportViewer1.TabIndex = 2;
            // 
            // dateBaseHotelDataSet
            // 
            this.dateBaseHotelDataSet.DataSetName = "DateBaseHotelDataSet";
            this.dateBaseHotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffsJobsTblBindingSource
            // 
            this.staffsJobsTblBindingSource.DataMember = "StaffsJobsTbl";
            this.staffsJobsTblBindingSource.DataSource = this.dateBaseHotelDataSet;
            // 
            // staffsJobsTblTableAdapter
            // 
            this.staffsJobsTblTableAdapter.ClearBeforeFill = true;
            // 
            // ReportStaffJobsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 656);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportStaffJobsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет контроля персонала";
            this.Load += new System.EventHandler(this.ReportStaffJobsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateBaseHotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsJobsTblBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DateBaseHotelDataSet1 dateBaseHotelDataSet;
        private System.Windows.Forms.BindingSource staffsJobsTblBindingSource;
        private DateBaseHotelDataSet1TableAdapters.StaffsJobsTblTableAdapter staffsJobsTblTableAdapter;
    }
}