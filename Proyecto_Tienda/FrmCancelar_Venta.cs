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
    public partial class FrmCancelar_Venta : DevComponents.DotNetBar.Metro.MetroForm
    {
        RNVenta objVenta = new RNVenta();

        public FrmCancelar_Venta()
        {
            InitializeComponent();
            ELIMINAR.Visible = false;
            lb_mostrar.Visible = false;
        }
        void buscar(string t)
        {
            DataTable dt = objVenta.consulta_fecha(t);
            dg.DataSource = dt;
        }
        //boton buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                buscar(dt.Value.ToShortDateString());
            }
            catch (Exception se)
            {
                MessageBox.Show("error!!");
            }
        }
        //evento del dg
        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow a = dg.Rows[e.RowIndex];
            txtNumeroV.Text = a.Cells[0].Value.ToString();
            ELIMINAR.Visible = true;
        }
   
        //boton eliminar
        private void ELIMINAR_Click(object sender, EventArgs e)
        {
            try
            {
                objVenta.eliminar_detalle_venta(txtNumeroV.Text);
                objVenta.eliminar_venta(txtNumeroV.Text);
                lb_mostrar.Visible = true;
                lb_mostrar.Text = "Eliminò Correctamente!! la venta-->> " + txtNumeroV.Text;
                txtNumeroV.Clear();
            }
            catch (Exception se)
            {
                MessageBox.Show("error!!");
            }
        }

    }
}
