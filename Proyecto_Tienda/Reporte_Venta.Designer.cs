namespace Proyecto_Tienda
{
    partial class Reporte_Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte_Venta));
            this.mostrar_ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cdVenta = new Proyecto_Tienda.cdVenta();
            this.rv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mostrar_ventaTableAdapter = new Proyecto_Tienda.cdVentaTableAdapters.mostrar_ventaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mostrar_ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // mostrar_ventaBindingSource
            // 
            this.mostrar_ventaBindingSource.DataMember = "mostrar_venta";
            this.mostrar_ventaBindingSource.DataSource = this.cdVenta;
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
            reportDataSource1.Value = this.mostrar_ventaBindingSource;
            this.rv.LocalReport.DataSources.Add(reportDataSource1);
            this.rv.LocalReport.ReportEmbeddedResource = "Proyecto_Tienda.Reporte_Venta.rdlc";
            this.rv.Location = new System.Drawing.Point(0, 0);
            this.rv.Name = "rv";
            this.rv.Size = new System.Drawing.Size(920, 456);
            this.rv.TabIndex = 0;
            // 
            // mostrar_ventaTableAdapter
            // 
            this.mostrar_ventaTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 456);
            this.Controls.Add(this.rv);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reporte_Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMPROBANTE DE VENTA";
            this.Load += new System.EventHandler(this.Reporte_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostrar_ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv;
        private System.Windows.Forms.BindingSource mostrar_ventaBindingSource;
        private cdVenta cdVenta;
        private cdVentaTableAdapters.mostrar_ventaTableAdapter mostrar_ventaTableAdapter;
    }
}