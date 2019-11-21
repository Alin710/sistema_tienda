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
    public partial class Consultas_Venta : DevComponents.DotNetBar.Metro.MetroForm
    {
        RNVenta objVenta = new RNVenta();

        public Consultas_Venta()
        {
            InitializeComponent();
            txtN.Visible = false;
            lbC.Visible = false;
        }
        //limpiar
        void limpiar()
        {
            txtCI.Clear();
            txtAño.Clear();
        }
        //boton buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAño.Text.Trim()!= "" && txtCI.Text.Trim()!= "")
                {
                    DataTable dt = objVenta.traer_consulta_pivot_(txtAño.Text, txtCI.Text);
                    dgPivot.DataSource = dt;
                    dtv = dt;
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Completar los Campos!!", "Erro!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
            }
            catch (Exception se)
            {
                MessageBox.Show("Formato Incorrecto!!","Erro!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                limpiar();
            }
        }
        DataTable dtv;
        Reporte_pivot_venta frv;
        bool b = false;
        //btn imprimir
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if ((b == false) || (frv.IsDisposed))
                {
                    frv = new Reporte_pivot_venta(dtv);
                    frv.Show();
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Error!!");
            }
        }
        //------------------------------------------------------------------------------------------------------------
        //btn consulta page2
        private void btnConsulta2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtC.Text.Trim() != "")
                {
                    DataTable dt = objVenta.consulta_fecha_ci_cliente(txtC.Text,fe.Value.ToShortDateString());
                    dg2.DataSource = dt;
                    txtN.Visible = true;
                    lbC.Visible = true;
                }
                else
                {
                    MessageBox.Show("Completar los campos!!", "Erro!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception se)
            {
                MessageBox.Show("Formato Incorrecto!!", "Erro!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //segunda consulta
        private void imageConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtC.Text.Trim() != "" )
                {
                    DataTable dt = objVenta.consulta_fecha_ci_cliente_nro(txtC.Text,fe.Value.ToShortDateString(),txtN.Text);
                    dg2.DataSource = dt;
                    dtvv = dt;//imprimir
                    txtN.Clear();
                }
                else
                {
                    MessageBox.Show("Completar los campos!!", "Erro!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception se)
            {
                MessageBox.Show("Formato Incorrecto!!", "Erro!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        DataTable dtvv;
        Reporte_Venta frvv;
        bool b1 = false;
        //btn imprimir page 2
        private void btnIm_Click(object sender, EventArgs e)
        {

            try
            {
                if ((b1 == false) || (frvv.IsDisposed))
                {
                    frvv = new Reporte_Venta(dtvv);
                    frvv.Show();
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Error!!");
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------
        //btn rango de fechas
        private void btn_rango_fechas_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = objVenta.consulta_ventas_rango_fechas(dtt.Value.ToShortDateString(), dtt1.Value.ToShortDateString());//(txtInicio.Text, txtFinal.Text);
                dg_rango_fechas.DataSource = dt;
                db = dt;
            }
            catch (Exception se)
            {
                MessageBox.Show("Formato Incorrecto!!", "Erro!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        DataTable db;
        Reporte_Venta f;
        bool o = false;
        //btn imprimir rango de fechas
        private void btnImprimir_Rango_Fechas_Click(object sender, EventArgs e)
        {
            try
            {
                if ((o == false) || (f.IsDisposed))
                {
                    f = new Reporte_Venta(db);
                    f.Show();
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Error!!");
            }
        }
        //evento de dg2
        private void dg2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow a = dg2.Rows[e.RowIndex];
            txtN.Text=a.Cells[0].Value.ToString();
        }
    }
}
