namespace QL_VTXD
{
    partial class frm_HDX
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
            this.cbo_sHD = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QUANLYKHODataSet8 = new QL_VTXD.QUANLYKHODataSet8();
            this.pr_HDXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pr_HDXTableAdapter = new QL_VTXD.QUANLYKHODataSet8TableAdapters.pr_HDXTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYKHODataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pr_HDXBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_sHD
            // 
            this.cbo_sHD.FormattingEnabled = true;
            this.cbo_sHD.Location = new System.Drawing.Point(332, 12);
            this.cbo_sHD.Name = "cbo_sHD";
            this.cbo_sHD.Size = new System.Drawing.Size(262, 28);
            this.cbo_sHD.TabIndex = 0;
            this.cbo_sHD.SelectedIndexChanged += new System.EventHandler(this.cbo_sHD_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pr_HDXBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL_VTXD.Rp_HDX.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 59);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1195, 681);
            this.reportViewer1.TabIndex = 1;
            // 
            // QUANLYKHODataSet8
            // 
            this.QUANLYKHODataSet8.DataSetName = "QUANLYKHODataSet8";
            this.QUANLYKHODataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pr_HDXBindingSource
            // 
            this.pr_HDXBindingSource.DataMember = "pr_HDX";
            this.pr_HDXBindingSource.DataSource = this.QUANLYKHODataSet8;
            // 
            // pr_HDXTableAdapter
            // 
            this.pr_HDXTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số HĐ:";
            // 
            // frm_HDX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 752);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cbo_sHD);
            this.Name = "frm_HDX";
            this.Text = "frm_HDX";
            this.Load += new System.EventHandler(this.frm_HDX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYKHODataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pr_HDXBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_sHD;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pr_HDXBindingSource;
        private QUANLYKHODataSet8 QUANLYKHODataSet8;
        private QUANLYKHODataSet8TableAdapters.pr_HDXTableAdapter pr_HDXTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}