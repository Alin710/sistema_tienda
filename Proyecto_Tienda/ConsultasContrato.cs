using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace Proyecto_Tienda
{
    public partial class ConsultasContrato : DevComponents.DotNetBar.Metro.MetroForm
    {
        RNSucursal objSucursal = new RNSucursal();
        RNContrato objContrato = new RNContrato();


        public ConsultasContrato()
        {
            InitializeComponent();
            groupBox2.Visible = false;
        }
        //cargar combo sucursal
        void cargarComboSucursal()
        {
            DataSet dt = objSucursal.traer_Datos_Sucursal();
            cbSucursal.DataSource=dt.Tables[0];
            cbSucursal.DisplayMember = "nombre";
            cbSucursal.ValueMember = "idSucursal";
        }
        //limpiar
        void limpiar()
        {
            txtAño.Clear();
            txtCi.Clear();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            cargarComboSucursal();
        }
        //boton consultar
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = objContrato.consulta_rango_fechas(cbSucursal.SelectedValue.ToString(), d1.Value.ToShortDateString(), d2.Value.ToShortDateString());
                dg.DataSource = dt;
                dtv = dt;
                limpiar();
            }
            catch (Exception se)
            {
                MessageBox.Show("Formato Incorrecto!!","error!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }
        //año y mes
        private void r1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = objContrato.consulta_año_mes(txtAño.Text, cbMes.Text);
                dg.DataSource = dt;
                dtv = dt;
            }
            catch (Exception se)
            {
                MessageBox.Show("Formato Incorrecto!!", "error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //consulta por dia,mes y año
        private void r2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = objContrato.consulta_año_mes_dia(txtAño.Text, cbMes.Text,cbDia.Text);
                dg.DataSource = dt;
                dtv = dt;
            }
            catch (Exception se)
            {
                MessageBox.Show("Formato Incorrecto!!", "error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //consulta por ci
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
            DataTable dt = objContrato.traerUltimoDato(txtCi.Text);
            dg.DataSource = dt;
            dtv = dt;

            limpiar();
            }
            catch (Exception se)
            {
                MessageBox.Show("Formato Incorrecto!!", "error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        DataTable dtv;
        ReporteContrato frv;
        bool b = false;
        //btn imprimir
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((b == false) || (frv.IsDisposed))
                {
                    frv = new ReporteContrato(dtv);
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
