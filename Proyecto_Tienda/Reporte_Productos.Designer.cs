namespace Proyecto_Tienda
{
    partial class Reporte_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte_Productos));
            this.mostrar_productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cdProductos = new Proyecto_Tienda.cdProductos();
            this.rv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mostrar_productosTableAdapter = new Proyecto_Tienda.cdProductosTableAdapters.mostrar_productosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mostrar_productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // mostrar_productosBindingSource
            // 
            this.mostrar_productosBindingSource.DataMember = "mostrar_productos";
            this.mostrar_productosBindingSource.DataSource = this.cdProductos;
            // 
            // cdProductos
            // 
            this.cdProductos.DataSetName = "cdProductos";
            this.cdProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rv
            // 
            this.rv.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.mostrar_productosBindingSource;
            this.rv.LocalReport.DataSources.Add(reportDataSource1);
            this.rv.LocalReport.ReportEmbeddedResource = "Proyecto_Tienda.Reporte_Productos.rdlc";
            this.rv.Location = new System.Drawing.Point(0, 0);
            this.rv.Name = "rv";
            this.rv.Size = new System.Drawing.Size(959, 443);
            this.rv.TabIndex = 0;
            // 
            // mostrar_productosTableAdapter
            // 
            this.mostrar_productosTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 443);
            this.Controls.Add(this.rv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reporte_Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE DE PRODUCTOS";
            this.Load += new System.EventHandler(this.Reporte_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostrar_productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv;
        private System.Windows.Forms.BindingSource mostrar_productosBindingSource;
        private cdProductos cdProductos;
        private cdProductosTableAdapters.mostrar_productosTableAdapter mostrar_productosTableAdapter;
    }
}