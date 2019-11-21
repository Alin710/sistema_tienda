namespace Proyecto_Tienda
{
    partial class Reporte_pivot_venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte_pivot_venta));
            this.consultas_pivot_venta_realizadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cdVenta = new Proyecto_Tienda.cdVenta();
            this.rv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.consultas_pivot_venta_realizadasTableAdapter = new Proyecto_Tienda.cdVentaTableAdapters.consultas_pivot_venta_realizadasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.consultas_pivot_venta_realizadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // consultas_pivot_venta_realizadasBindingSource
            // 
            this.consultas_pivot_venta_realizadasBindingSource.DataMember = "consultas_pivot_venta_realizadas";
            this.consultas_pivot_venta_realizadasBindingSource.DataSource = this.cdVenta;
            // 
            // cdVenta
            // 
            this.cdVenta.DataSetName = "cdVenta";
            this.cdVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rv
            // 
            this.rv.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.consultas_pivot_venta_realizadasBindingSource;
            this.rv.LocalReport.DataSources.Add(reportDataSource1);
            this.rv.LocalReport.ReportEmbeddedResource = "Proyecto_Tienda.Reporte_pivot_venta.rdlc";
            this.rv.Location = new System.Drawing.Point(0, 0);
            this.rv.Name = "rv";
            this.rv.Size = new System.Drawing.Size(1276, 437);
            this.rv.TabIndex = 0;
            // 
            // consultas_pivot_venta_realizadasTableAdapter
            // 
            this.consultas_pivot_venta_realizadasTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_pivot_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 437);
            this.Controls.Add(this.rv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reporte_pivot_venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE DE VENTA CLIENTE";
            this.Load += new System.EventHandler(this.Reporte_pivot_venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultas_pivot_venta_realizadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv;
        private System.Windows.Forms.BindingSource consultas_pivot_venta_realizadasBindingSource;
        private cdVenta cdVenta;
        private cdVentaTableAdapters.consultas_pivot_venta_realizadasTableAdapter consultas_pivot_venta_realizadasTableAdapter;
    }
}