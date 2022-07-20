namespace QL_VTXD
{
    partial class frm_rphodon
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
            this.QUANLYKHODataSet4 = new QL_VTXD.QUANLYKHODataSet4();
            this.rp_HODONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rp_HODONTableAdapter = new QL_VTXD.QUANLYKHODataSet4TableAdapters.rp_HODONTableAdapter();
            this.cbo_mahang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYKHODataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rp_HODONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.rp_HODONBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL_VTXD.RP_HOADON.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 94);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(828, 330);
            this.reportViewer1.TabIndex = 1;
            // 
            // QUANLYKHODataSet4
            // 
            this.QUANLYKHODataSet4.DataSetName = "QUANLYKHODataSet4";
            this.QUANLYKHODataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rp_HODONBindingSource
            // 
            this.rp_HODONBindingSource.DataMember = "rp_HODON";
            this.rp_HODONBindingSource.DataSource = this.QUANLYKHODataSet4;
            // 
            // rp_HODONTableAdapter
            // 
            this.rp_HODONTableAdapter.ClearBeforeFill = true;
            // 
            // cbo_mahang
            // 
            this.cbo_mahang.FormattingEnabled = true;
            this.cbo_mahang.Location = new System.Drawing.Point(317, 24);
            this.cbo_mahang.Name = "cbo_mahang";
            this.cbo_mahang.Size = new System.Drawing.Size(245, 37);
            this.cbo_mahang.TabIndex = 0;
            this.cbo_mahang.SelectedIndexChanged += new System.EventHandler(this.cbo_mahang_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã hàng:";
            // 
            // frm_rphodon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cbo_mahang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frm_rphodon";
            this.Text = "frm_rphodon";
            this.Load += new System.EventHandler(this.frm_rphodon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYKHODataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rp_HODONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rp_HODONBindingSource;
        private QUANLYKHODataSet4 QUANLYKHODataSet4;
        private QUANLYKHODataSet4TableAdapters.rp_HODONTableAdapter rp_HODONTableAdapter;
        private System.Windows.Forms.ComboBox cbo_mahang;
        private System.Windows.Forms.Label label1;
    }
}