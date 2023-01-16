
namespace HotelData.Forms
{
    partial class ReportPriceList
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.typeTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateBaseHotelDataSet = new HotelData.DateBaseHotelDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FilterStatusCb = new System.Windows.Forms.ComboBox();
            this.typeTblTableAdapter = new HotelData.DateBaseHotelDataSet1TableAdapters.TypeTblTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.typeTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaseHotelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // typeTblBindingSource
            // 
            this.typeTblBindingSource.DataMember = "TypeTbl";
            this.typeTblBindingSource.DataSource = this.dateBaseHotelDataSet;
            // 
            // dateBaseHotelDataSet
            // 
            this.dateBaseHotelDataSet.DataSetName = "DateBaseHotelDataSet";
            this.dateBaseHotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.typeTblBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HotelData.Reports.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, 150);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1153, 584);
            this.reportViewer1.TabIndex = 60;
            // 
            // FilterStatusCb
            // 
            this.FilterStatusCb.AccessibleName = "";
            this.FilterStatusCb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FilterStatusCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterStatusCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterStatusCb.Items.AddRange(new object[] {
            "высокий сезон",
            "межсезонье",
            "низкий сезон"});
            this.FilterStatusCb.Location = new System.Drawing.Point(529, 101);
            this.FilterStatusCb.Margin = new System.Windows.Forms.Padding(2);
            this.FilterStatusCb.Name = "FilterStatusCb";
            this.FilterStatusCb.Size = new System.Drawing.Size(163, 33);
            this.FilterStatusCb.TabIndex = 22;
            this.FilterStatusCb.SelectedIndexChanged += new System.EventHandler(this.FilterStatusCb_SelectedIndexChanged);
            // 
            // typeTblTableAdapter
            // 
            this.typeTblTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(552, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 21);
            this.label4.TabIndex = 57;
            this.label4.Text = "Выбор сезона";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReportPriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 723);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FilterStatusCb);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Name = "ReportPriceList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет стоимость комнат";
            this.Load += new System.EventHandler(this.ReportPriceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typeTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaseHotelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DateBaseHotelDataSet1 dateBaseHotelDataSet;
        private System.Windows.Forms.BindingSource typeTblBindingSource;
        private DateBaseHotelDataSet1TableAdapters.TypeTblTableAdapter typeTblTableAdapter;
        private System.Windows.Forms.ComboBox FilterStatusCb;
        private System.Windows.Forms.Label label4;
    }
}