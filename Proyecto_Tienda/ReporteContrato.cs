using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//adde
using Microsoft.Reporting.WinForms;

namespace Proyecto_Tienda
{
    public partial class ReporteContrato : Form
    {
        DataTable dtx = null;

        public ReporteContrato(DataTable dt)
        {
            InitializeComponent();
            dtx = dt;
        }

        private void FrmReporteContrato_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cdPersona.mostrar_Reporte_contrato' Puede moverla o quitarla según sea necesario.
            //this.mostrar_Reporte_contratoTableAdapter.Fill(this.cdPersona.mostrar_Reporte_contrato);

            this.rv.RefreshReport();
            rv.LocalReport.DataSources.Clear();
            ReportDataSource rd = new ReportDataSource("DataSet1", dtx);
            rv.LocalReport.DataSources.Add(rd);
            this.rv.RefreshReport(); 
        }
    }
}
