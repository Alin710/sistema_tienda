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
using CapaControl;

namespace Proyecto_Tienda
{
    public partial class FrmVenta : DevComponents.DotNetBar.Metro.MetroForm
    {
        ClaseCT obCT = new ClaseCT();
        RNCliente objCliente = new RNCliente();
        RNEmpleado objEmpleado = new RNEmpleado();
        RNVenta obventa = new RNVenta();
        RNDetalleVenta obdetallev = new RNDetalleVenta();
        RNDetalle_Lote_Entrega objDt = new RNDetalle_Lote_Entrega();
        RNProducto objProducto = new RNProducto();

        DataTable d;
        public FrmVenta(DataTable dx)
        {
            InitializeComponent();
            timer1.Enabled = true;
            groupBox3.Visible = false;
            lb1.Visible = false;
            d = dx;
        }
        void traerProductosInventario()
        {
            DataTable dt = objDt.traerProductosInventario();
            dg_inventario.DataSource = dt;
        }
        //traer prodeuctos del detalle_lote_entrega
        private void ImgBusca_Productos_Click(object sender, EventArgs e)
        {
            traerProductosInventario();
        }
        //evento cell clik de dginventario
        int r = -1;
        private void dg_inventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                double b1 = Convert.ToInt32(dg_inventario.CurrentRow.Cells["cantida"].Value);
                double b2 = Convert.ToInt32(dg_inventario.CurrentRow.Cells["stock"].Value);
                if ((b1 <= b2))
                {
                    //----------------------------------------------------------------------------------
                    if (e.ColumnIndex == 0)
                    {
                        r++;
                        dg_lista.Rows.Add();
                        dg_lista.Rows[r].Cells[0].Value = dg_inventario.CurrentRow.Cells["producto"].Value;
                        dg_lista.Rows[r].Cells[1].Value = dg_inventario.CurrentRow.Cells["Nro entrega"].Value;
                        dg_lista.Rows[r].Cells[2].Value = dg_inventario.CurrentRow.Cells["codigo"].Value;
                        dg_lista.Rows[r].Cells[3].Value = dg_inventario.CurrentRow.Cells["cantida"].Value;
                        dg_lista.Rows[r].Cells[4].Value = dg_inventario.CurrentRow.Cells["stock"].Value;
                    }
                    //---------------------------------------------------------------------------------
                }
                else
                {
                    MessageBox.Show("verifique la cantidad", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception se)
            {
                MessageBox.Show("Formato Incorrecto","Error!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        //btnbuscar_cliente
        private void Btn_buscar_cliente_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
        }
        //fecha y hora
        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_fecha.Text = DateTime.Now.ToString();
        }
        int p = -1;
        //boton registrar venta
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (insertarDatos())
            {
                cargarVentaHecha();
                calcularProductosLiteral();
                dg_lista.Rows.Clear(); p = -1;

            } 
        }
        //cantidad producto Literal
        void calcularProductosLiteral()
        {
            Literal litera = new Literal();
            int acc = 0;
            for (int i = 0; i < dg_ventar.Rows.Count - 1; i++)
            {
                acc += int.Parse(dg_lista.Rows[i].Cells["cantidad"].Value.ToString());
                //acc += int.Parse(dg_ventar.Rows[i].Cells[7].Value.ToString());

            }
            lb1.Visible = true;
            lb1.Text = "Cantidad de Productos Total Vendidos-->> " + litera.convertirLetras(acc);
        }
        //----------------------------------------------------------------
        //cargar venta
        void cargarVentaHecha()
        {
            DataTable dtx = obventa.traerLaVenta(llave);
            dg_ventar.DataSource = dtx;
            dtv = dtx; //imprimir reporte
        }
        bool insertarDatos()
        {
            var tr = obCT.iniTR();
            if (insertarVenta(tr))
                if (insertarDetallev(tr))
                {
                    obCT.finTR(tr);
                    return true;
                }
            return false;
        }
        bool insertarVenta(object tr)
        {
            obventa.v[1] = lb_fecha.Text = DateTime.Now.ToString("d");//"20-04-2016";
            obventa.v[2] = txtCliente.Text;
            obventa.v[3] = cbEmpleado.SelectedValue.ToString();//"1";
            if (obventa.insertar(tr) == 0)
            {
                MessageBox.Show("Error en Venta");
                obCT.deshacerTR(tr);
                return false;
            }
            return true;
        }
        string llave;
        bool insertarDetallev(object tr)
        {
            llave = obventa.llave(tr);
            for (int f = 0; f < dg_lista.Rows.Count - 1; f++)
            {
                obdetallev.v[0] = llave;
                obdetallev.v[1] = dg_lista.Rows[f].Cells[1].Value.ToString();
                obdetallev.v[2] = dg_lista.Rows[f].Cells[2].Value.ToString();
                obdetallev.v[3] = dg_lista.Rows[f].Cells[3].Value.ToString();
                if (obdetallev.insertar(tr) == 0)
                {
                    MessageBox.Show("Error en Detalle Venta");
                    obCT.deshacerTR(tr);
                    return false;
                }
            }
            return true;
        }
        DataTable dtv;
        Reporte_Venta frv;
        bool b = false;
        //boton imprimir
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if ((b == false) || (frv.IsDisposed))
                {
                    frv = new Reporte_Venta(dtv);
                    frv.Show();
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Error!!");
            }
        }
        //btn buscar cliente
        private void btn1_Click(object sender, EventArgs e)
        {
            DataTable dt = objCliente.buscarPorNombre(txtBuscarCE.Text);
            dgBuscarCE.DataSource = dt;
            txtBuscarCE.Clear();
        }
        //evento de dgBuscarCE
        private void dgBuscarCE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow a = dgBuscarCE.Rows[e.RowIndex];
            txtCliente.Text = a.Cells[1].Value.ToString();
        }
        //cargar combo empleado
        void cargarCombo_empleado()
        {
            DataTable dt = objEmpleado.traerDatos_solo_cajeros();
            cbEmpleado.DataSource = dt;
            cbEmpleado.DisplayMember = "cajero";
            cbEmpleado.ValueMember = "ci";
        }
        void per(bool v)
        {
            //btn_imprimir.Visible = v;
            //btn_guardar.Visible = v;
        }
        private void FrmVenta_Load(object sender, EventArgs e)
        {
            if (d.Columns[2].ColumnName == "idempleado")
            {
                per(true);
                Lb_usuario.Text = "Vendedor/a : " + d.Rows[0][1].ToString();
            }
            cargarCombo_empleado();
        }
        //buscar producto pot codigo
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = objProducto.buscar_producto_codigo(txtBuscar.Text);
                dg_inventario.DataSource = dt;
                txtBuscar.Clear();
            }
            catch (Exception se)
            {
                MessageBox.Show("formato incorrecto!!");
                txtBuscar.Clear();
            }
        }
        //buscar por nombre
        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = objProducto.buscar_producto_nombre(txtBuscar.Text);
                dg_inventario.DataSource = dt;
                txtBuscar.Clear();
            }
            catch (Exception se)
            {
                MessageBox.Show("formato incorrecto!!");
                txtBuscar.Clear();
            }
        }
        //-------------------------------------------------------------------------------
        //evento 
        private void dg_lista_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double x = gx;
            if (Convert.ToDouble(dg_lista.CurrentRow.Cells["cantidad"].Value) > Convert.ToDouble(dg_lista.CurrentRow.Cells["cantidad_stock"].Value))
            {
                dg_lista.CurrentRow.Cells["cantidad"].Value = x;
            }
        }
        //-------------------------------------------------------------------------------
        double gx;
        private void dg_lista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gx = Convert.ToDouble(dg_lista.CurrentRow.Cells["cantidad"].Value);
            //dg_lista.CurrentRow.Cells["cantidad"].Value = Convert.ToInt32(dg_lista.CurrentRow.Cells["cantidad"].Value) + Convert.ToInt32(dg_lista.CurrentRow.Cells["cantidad"].Value);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("DESEA SALIR","SALIR",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)==System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }

        }



        
    }
}
