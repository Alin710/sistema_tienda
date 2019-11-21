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
    public partial class Reporte_empleados_Filtros : Form
    {
        DataTable dtx = null;
        public Reporte_empleados_Filtros(DataTable dtv)
        {
            InitializeComponent();
            dtx = dtv;
        }

        private void Reporte_empleados_Filtros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cdPersona.mostrar_reporte_empleados_filtros' Puede moverla o quitarla según sea necesario.
            //this.mostrar_reporte_empleados_filtrosTableAdapter.Fill(this.cdPersona.mostrar_reporte_empleados_filtros);

            this.rv.RefreshReport();
            rv.LocalReport.DataSources.Clear();
            ReportDataSource rd = new ReportDataSource("DataSet1", dtx);
            rv.LocalReport.DataSources.Add(rd);
            this.rv.RefreshReport();
        }
    }
}
