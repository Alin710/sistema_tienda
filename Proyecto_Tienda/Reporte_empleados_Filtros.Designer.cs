namespace Proyecto_Tienda
{
    partial class Reporte_empleados_Filtros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte_empleados_Filtros));
            this.mostrar_reporte_empleados_filtrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cdPersona = new Proyecto_Tienda.cdPersona();
            this.rv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mostrar_reporte_empleados_filtrosTableAdapter = new Proyecto_Tienda.cdPersonaTableAdapters.mostrar_reporte_empleados_filtrosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mostrar_reporte_empleados_filtrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // mostrar_reporte_empleados_filtrosBindingSource
            // 
            this.mostrar_reporte_empleados_filtrosBindingSource.DataMember = "mostrar_reporte_empleados_filtros";
            this.mostrar_reporte_empleados_filtrosBindingSource.DataSource = this.cdPersona;
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
            reportDataSource1.Value = this.mostrar_reporte_empleados_filtrosBindingSource;
            this.rv.LocalReport.DataSources.Add(reportDataSource1);
            this.rv.LocalReport.ReportEmbeddedResource = "Proyecto_Tienda.Reporte_Empleados_Filtros.rdlc";
            this.rv.Location = new System.Drawing.Point(0, 0);
            this.rv.Name = "rv";
            this.rv.Size = new System.Drawing.Size(1062, 427);
            this.rv.TabIndex = 0;
            // 
            // mostrar_reporte_empleados_filtrosTableAdapter
            // 
            this.mostrar_reporte_empleados_filtrosTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_empleados_Filtros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 427);
            this.Controls.Add(this.rv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reporte_empleados_Filtros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE";
            this.Load += new System.EventHandler(this.Reporte_empleados_Filtros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostrar_reporte_empleados_filtrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdPersona)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv;
        private System.Windows.Forms.BindingSource mostrar_reporte_empleados_filtrosBindingSource;
        private cdPersona cdPersona;
        private cdPersonaTableAdapters.mostrar_reporte_empleados_filtrosTableAdapter mostrar_reporte_empleados_filtrosTableAdapter;
    }
}