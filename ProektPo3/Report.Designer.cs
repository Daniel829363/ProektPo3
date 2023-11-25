namespace ProektPo3
{
    partial class Report
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
            this.zakupkasyriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mebelDataSet = new ProektPo3.MebelDataSet();
            this.syrieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakupkaViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakupka_syriaTableAdapter = new ProektPo3.MebelDataSetTableAdapters.Zakupka_syriaTableAdapter();
            this.zakupkaViewTableAdapter = new ProektPo3.MebelDataSetTableAdapters.ZakupkaViewTableAdapter();
            this.syrieTableAdapter = new ProektPo3.MebelDataSetTableAdapters.SyrieTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.zakupkasyriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syrieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupkaViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet3";
            reportDataSource1.Value = this.zakupkaViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProektPo3.Proiz.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(788, 418);
            this.reportViewer1.TabIndex = 0;
            // 
            // zakupkasyriaBindingSource
            // 
            this.zakupkasyriaBindingSource.DataMember = "Zakupka_syria";
            this.zakupkasyriaBindingSource.DataSource = this.mebelDataSet;
            // 
            // mebelDataSet
            // 
            this.mebelDataSet.DataSetName = "MebelDataSet";
            this.mebelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // syrieBindingSource
            // 
            this.syrieBindingSource.DataMember = "Syrie";
            this.syrieBindingSource.DataSource = this.mebelDataSet;
            // 
            // zakupkaViewBindingSource
            // 
            this.zakupkaViewBindingSource.DataMember = "ZakupkaView";
            this.zakupkaViewBindingSource.DataSource = this.mebelDataSet;
            // 
            // zakupka_syriaTableAdapter
            // 
            this.zakupka_syriaTableAdapter.ClearBeforeFill = true;
            // 
            // zakupkaViewTableAdapter
            // 
            this.zakupkaViewTableAdapter.ClearBeforeFill = true;
            // 
            // syrieTableAdapter
            // 
            this.syrieTableAdapter.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 422);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zakupkasyriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syrieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupkaViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MebelDataSet mebelDataSet;
        private System.Windows.Forms.BindingSource zakupkasyriaBindingSource;
        private MebelDataSetTableAdapters.Zakupka_syriaTableAdapter zakupka_syriaTableAdapter;
        private System.Windows.Forms.BindingSource zakupkaViewBindingSource;
        private MebelDataSetTableAdapters.ZakupkaViewTableAdapter zakupkaViewTableAdapter;
        private System.Windows.Forms.BindingSource syrieBindingSource;
        private MebelDataSetTableAdapters.SyrieTableAdapter syrieTableAdapter;
    }
}