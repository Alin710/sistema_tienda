﻿using System;
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
    public partial class Reporte_Lotes : Form
    {
        DataTable dtx = null;
        public Reporte_Lotes(DataTable dtv)
        {
            InitializeComponent();
            dtx = dtv;
        }

        private void Reporte_Lotes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cdProductos.mostrar_lotes' Puede moverla o quitarla según sea necesario.
            //this.mostrar_lotesTableAdapter.Fill(this.cdProductos.mostrar_lotes);

            this.rv.RefreshReport();
            rv.LocalReport.DataSources.Clear();
            ReportDataSource rd = new ReportDataSource("DataSet1", dtx);
            rv.LocalReport.DataSources.Add(rd);
            this.rv.RefreshReport();
        }
    }
}
