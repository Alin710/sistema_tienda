namespace Proyecto_Tienda
{
    partial class Reporte_Lotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte_Lotes));
            this.mostrar_lotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cdProductos = new Proyecto_Tienda.cdProductos();
            this.rv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mostrar_lotesTableAdapter = new Proyecto_Tienda.cdProductosTableAdapters.mostrar_lotesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mostrar_lotesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // mostrar_lotesBindingSource
            // 
            this.mostrar_lotesBindingSource.DataMember = "mostrar_lotes";
            this.mostrar_lotesBindingSource.DataSource = this.cdProductos;
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
            reportDataSource1.Value = this.mostrar_lotesBindingSource;
            this.rv.LocalReport.DataSources.Add(reportDataSource1);
            this.rv.LocalReport.ReportEmbeddedResource = "Proyecto_Tienda.Reporte_Lotes.rdlc";
            this.rv.Location = new System.Drawing.Point(0, 0);
            this.rv.Name = "rv";
            this.rv.Size = new System.Drawing.Size(1241, 465);
            this.rv.TabIndex = 0;
            // 
            // mostrar_lotesTableAdapter
            // 
            this.mostrar_lotesTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_Lotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 465);
            this.Controls.Add(this.rv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reporte_Lotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE DE LOTES DE ENTREGA";
            this.Load += new System.EventHandler(this.Reporte_Lotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostrar_lotesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv;
        private System.Windows.Forms.BindingSource mostrar_lotesBindingSource;
        private cdProductos cdProductos;
        private cdProductosTableAdapters.mostrar_lotesTableAdapter mostrar_lotesTableAdapter;
    }
}