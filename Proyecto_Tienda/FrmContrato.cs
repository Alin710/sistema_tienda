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
    public partial class FrmContrato : DevComponents.DotNetBar.Metro.MetroForm
    {
        RNSector objSector = new RNSector();
        RNSucursal objSucursal = new RNSucursal();
        RNEmpleado objEmpleado = new RNEmpleado();
        RNContrato objContrato = new RNContrato();
        RNHorario objHorario = new RNHorario();

        public FrmContrato()
        {
            InitializeComponent();
            groupBox2.Visible = false;
            txtCi.Visible = false;
            txtCodigo.Visible = false;
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }
        //cargar combo sector
        void cargarComboSector()
        {
            DataSet dt = objSector.traer_datos_sector();
            cbSector.DataSource=dt.Tables[0];
            cbSector.DisplayMember = "nombre";
            cbSector.ValueMember = "idSector";
        }
        //cargar combo sucursal
        void cargarComboSucursal()
        {
            DataSet dt = objSucursal.traer_Datos_Sucursal();
            cbSucursal.DataSource = dt.Tables[0];
            cbSucursal.DisplayMember = "nombre";
            cbSucursal.ValueMember = "idSucursal";
        }
        //cargar combo horario
        void cargarComboHorario()
        {
            DataSet dt = objHorario.traerDatosHorario();
            cbHorario.DataSource=dt.Tables[0];
            cbHorario.DisplayMember = "nombre";
            cbHorario.ValueMember = "idHorario";
        }
        //click
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            cargarComboSector();
            cargarComboSucursal();
            cargarComboHorario();
        }
        //buscar persona
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = objEmpleado.Buscar_empleadoPorNombre(txtBuscarE.Text);
                dgEmpleado.DataSource = dt;
            }
            catch (Exception se)
            {
                MessageBox.Show("error!!");
            }
        }
        //evento del dgempleado
        private void dgEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow a = dgEmpleado.Rows[e.RowIndex];
            txtEmpleado.Text = a.Cells[0].Value.ToString();
        }
        //cargar datos contrato
        void cargarDatos_Contrato()
        {
            objContrato.hor = cbHorario.SelectedValue.ToString();
            objContrato.f = txtFecha.Text;
            objContrato.sect = cbSector.SelectedValue.ToString();
            objContrato.sucu = cbSucursal.SelectedValue.ToString();
            objContrato.empl = txtEmpleado.Text;
            objContrato.suel = txtSueldo.Text;
        }
        //cargar datos contrato
        void cargarDatos_Contrato1()
        {
            objContrato.hor = cbHorario.SelectedValue.ToString();
            objContrato.f = txtFecha.Text;
            objContrato.sect = cbSector.SelectedValue.ToString();
            objContrato.sucu = cbSucursal.SelectedValue.ToString();
            objContrato.empl = txtCi.Text;
            objContrato.suel = txtSueldo.Text;
        }
        //traer ultimo dato
        void traerUltimoDato(string c)
        {
            DataTable dt = objContrato.traerUltimoDato(c);
            dg.DataSource = dt;
            dtv = dt;

        }
        //boton registrar
        private void btn_Reg_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSueldo.Text.Trim() != "" && txtEmpleado.Text.Trim() != "")
                {
                    cargarDatos_Contrato();
                    objContrato.insertar_contrato();
                    traerUltimoDato(txtEmpleado.Text);
                    lbMostrar.Text = "Se Registrò Exitosamente...!!";
                }
                else
                {
                    MessageBox.Show("completar los campos!!");
                }
            }
            catch (Exception se)
            {
                MessageBox.Show("error!!");
            }
        }
        //boton ver datos
        private void btnVer_Click(object sender, EventArgs e)
        {
            DataTable dt = objContrato.traerDatos();
            dg.DataSource = dt;
            dtv = dt;
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow a = dg.Rows[e.RowIndex];
                txtCodigo.Text = a.Cells[0].Value.ToString();
                txtCi.Text = a.Cells[1].Value.ToString();
                cbHorario.Text = a.Cells[4].Value.ToString();
                txtFecha.Text = a.Cells[3].Value.ToString();
                cbSector.Text = a.Cells[5].Value.ToString();
                cbSucursal.Text = a.Cells[6].Value.ToString();
                txtSueldo.Text = a.Cells[7].Value.ToString();
                txtEmpleado.Text = a.Cells[2].Value.ToString();

                btn_Reg.Enabled = false;
                btnImprimir.Enabled = false;
            }
            catch (Exception se)
            {
                MessageBox.Show("error!!");
            }
        }
        void limpiar()
        {
            txtSueldo.Clear();
            txtEmpleado.Clear();
        }
        //boton eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                cargarDatos_Contrato();
                objContrato.eliminar(txtCodigo.Text);
                lbMostrar.Text = "Se Eliminò Exitosamente!!";
                limpiar();
               
            }
            catch (Exception se)
            {
                MessageBox.Show("Error!!");
            }
        }
        //boton modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSueldo.Text.Trim() != "" && txtEmpleado.Text.Trim() != "")
                {

                    cargarDatos_Contrato1();
                    objContrato.modificar();
                    lbMostrar.Text = "Se Modificò Exitosamente";
                    traerUltimoDato(txtEmpleado.Text);
                }
                else
                {
                    MessageBox.Show("Completar los campos!!");
                }
            }
            catch (Exception se)
            {
                MessageBox.Show("error!!!");
            }
        }
        DataTable dtv;
        ReporteContrato frv;
        bool b = false;
        //btn imprimir
        private void btnImprimir_Click(object sender, EventArgs e)
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultasContrato a = new ConsultasContrato();
            a.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btn_Reg.Enabled = true;
            btnImprimir.Enabled = true;
        }
    }
}
