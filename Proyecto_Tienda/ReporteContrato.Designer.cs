namespace Proyecto_Tienda
{
    partial class ReporteContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteContrato));
            this.mostrar_Reporte_contratoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cdPersona = new Proyecto_Tienda.cdPersona();
            this.rv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mostrar_Reporte_contratoTableAdapter = new Proyecto_Tienda.cdPersonaTableAdapters.mostrar_Reporte_contratoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mostrar_Reporte_contratoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // mostrar_Reporte_contratoBindingSource
            // 
            this.mostrar_Reporte_contratoBindingSource.DataMember = "mostrar_Reporte_contrato";
            this.mostrar_Reporte_contratoBindingSource.DataSource = this.cdPersona;
            // 
            // cdPersona
            // 
            this.cdPersona.DataSetName = "cdPersona";
            this.cdPersona.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rv
            // 
            this.rv.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.mostrar_Reporte_contratoBindingSource;
            this.rv.LocalReport.DataSources.Add(reportDataSource1);
            this.rv.LocalReport.ReportEmbeddedResource = "Proyecto_Tienda.Reporte_contrato.rdlc";
            this.rv.Location = new System.Drawing.Point(0, 0);
            this.rv.Name = "rv";
            this.rv.Size = new System.Drawing.Size(939, 419);
            this.rv.TabIndex = 0;
            // 
            // mostrar_Reporte_contratoTableAdapter
            // 
            this.mostrar_Reporte_contratoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 419);
            this.Controls.Add(this.rv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTRATO";
            this.Load += new System.EventHandler(this.FrmReporteContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostrar_Reporte_contratoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdPersona)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv;
        private System.Windows.Forms.BindingSource mostrar_Reporte_contratoBindingSource;
        private cdPersona cdPersona;
        private cdPersonaTableAdapters.mostrar_Reporte_contratoTableAdapter mostrar_Reporte_contratoTableAdapter;
    }
}