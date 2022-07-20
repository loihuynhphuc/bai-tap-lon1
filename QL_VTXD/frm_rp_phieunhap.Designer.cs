namespace QL_VTXD
{
    partial class frm_rp_phieunhap
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
            this.QUANLYKHODataSet3 = new QL_VTXD.QUANLYKHODataSet3();
            this.rp_phieuthuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rp_phieuthuTableAdapter = new QL_VTXD.QUANLYKHODataSet3TableAdapters.rp_phieuthuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYKHODataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rp_phieuthuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_phieunhap";
            reportDataSource1.Value = this.rp_phieuthuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL_VTXD.Rp_Phieunhap.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(805, 428);
            this.reportViewer1.TabIndex = 0;
            // 
            // QUANLYKHODataSet3
            // 
            this.QUANLYKHODataSet3.DataSetName = "QUANLYKHODataSet3";
            this.QUANLYKHODataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rp_phieuthuBindingSource
            // 
            this.rp_phieuthuBindingSource.DataMember = "rp_phieuthu";
            this.rp_phieuthuBindingSource.DataSource = this.QUANLYKHODataSet3;
            // 
            // rp_phieuthuTableAdapter
            // 
            this.rp_phieuthuTableAdapter.ClearBeforeFill = true;
            // 
            // frm_rp_phieunhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 428);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_rp_phieunhap";
            this.Text = "frm_rp_phieunhap";
            this.Load += new System.EventHandler(this.frm_rp_phieunhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYKHODataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rp_phieuthuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rp_phieuthuBindingSource;
        private QUANLYKHODataSet3 QUANLYKHODataSet3;
        private QUANLYKHODataSet3TableAdapters.rp_phieuthuTableAdapter rp_phieuthuTableAdapter;
    }
}