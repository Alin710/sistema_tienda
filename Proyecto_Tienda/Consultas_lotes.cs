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
using CapaNegocios;
namespace Proyecto_Tienda
{
    public partial class Consultas_lotes : DevComponents.DotNetBar.Metro.MetroForm
    {
        RNProducto objProducto = new RNProducto();

        public Consultas_lotes()
        {
            InitializeComponent();
        }
        //boton buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable b = objProducto.buscar_lotes(fecha.Value.ToShortDateString());
            dg.DataSource = b;
            dtv = b;
        }
        DataTable dtv;
        Reporte_Lotes frv;
        bool b = false;
        //boton imprimir
        private void lbImprimir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if ((b == false) || (frv.IsDisposed))
                {
                    frv = new Reporte_Lotes(dtv);
                    frv.Show();
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Error!!");
            }
        }
    }
}
