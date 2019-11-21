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
    public partial class FrmCliente : DevComponents.DotNetBar.Metro.MetroForm
    {
        RNPersona objPersona = new RNPersona();
        RNCliente objCliente = new RNCliente();
        RNRubro objRubro = new RNRubro();

        public FrmCliente()
        {
            InitializeComponent();
            bloquear();
        }
        void bloquear()
        {
            btn_Reg.Enabled = false;
            btnImprimir.Enabled = false;
        }
        void desbloquear()
        {
            btn_Reg.Enabled = true;
            btnImprimir.Enabled = true;
        }
        //cargar cliente
        void cargarCliente()
        {
            objCliente.id = txtci.Text;
            objCliente.nt = txtNit.Text;
            objCliente.ru = cbRubro.SelectedValue.ToString();
        }
        //cargarPersona
        void cargarDatosPersona()
        {
            objPersona.ci = txtci.Text;
            objPersona.nom = txtnom.Text;
            objPersona.apell = txtApp.Text;
            objPersona.fono = txttel.Text;
            objPersona.gen = cbGenero.Text;
            objPersona.fn = fecha.Text;
        }

        //boton registrar
        private void btn_Reg_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtci.Text.Trim() != "" && txtnom.Text.Trim() != "" && txtApp.Text.Trim() != "" && txttel.Text.Trim() != "" && txtNit.Text.Trim() != "")
                {
                    cargarDatosPersona();
                    cargarCliente();
                    objPersona.insertarPersona();
                    objCliente.insertarCliente();
                    lb_mostrar.Text = "Registro existosamente al cliente: " + txtnom.Text;
                    traerUltimoDato(txtci.Text);
                }
                else
                {
                    MessageBox.Show("completar los campos!!", "error!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception se)
            {
                MessageBox.Show("error!!");
                lb_mostrar.Text = "";
                limpiar();
            }
        }
        //cargar combo
        void cargarComboR()
        {
            DataSet dt = objRubro.traerDatosRubro();
            cbRubro.DataSource=dt.Tables[0];
            cbRubro.DisplayMember = "nombre";
            cbRubro.ValueMember = "idRubro";
        }
        //clik frm
        private void groupb1_Enter(object sender, EventArgs e)
        {
            cargarComboR();
        }
        void limpiar()
        {
            txtci.Clear();
            txtnom.Clear();
            txtApp.Clear();
            txttel.Clear();
            txtNit.Clear();

        }
        //boton nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            desbloquear();
        }
        //boton ver
        private void btnVer_Click(object sender, EventArgs e)
        {
            DataTable dt = objCliente.traerDatos();
            dg.DataSource=dt;
            //dtv = dt;
            bloquear();
        }
        //traer ultimo dato
        public void traerUltimoDato(string c)
        {
            DataTable dt = objCliente.traerUltimoDato(c);
            dg.DataSource = dt;
            dtv = dt;
        }
        DataTable dtv;
        ReporteCliente frv;
        bool b = false;
        //boton imprimir
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if ((b == false) || (frv.IsDisposed))
                {
                    frv = new ReporteCliente(dtv);
                    frv.Show();
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Error!!");
            }
        }
        //evento del dataGrid
        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow a = dg.Rows[e.RowIndex];
                txtci.Text = a.Cells[0].Value.ToString();
                txtnom.Text = a.Cells[1].Value.ToString();
                txtApp.Text = a.Cells[2].Value.ToString();
                cbGenero.Text = a.Cells[3].Value.ToString();
                fecha.Text = a.Cells[5].Value.ToString();
                txttel.Text = a.Cells[4].Value.ToString();
                txtNit.Text = a.Cells[6].Value.ToString();
                cbRubro.Text = a.Cells[7].Value.ToString();

                bloquear();
                txtci.Enabled = false;
            }
            catch (Exception s)
            {
                MessageBox.Show("error");
            }
        }

        //boton buscar por ci
        string refe = "";
        bool activado = false;
        private void button1_Click(object sender, EventArgs e)
        {
            //.........................................................
            try
            {
                refe = txtconsu.Text;
                DataTable dat3 = objCliente.traerUltimoDato(txtconsu.Text);
                dg.DataSource = dat3;
                dtv = dat3;
                txtconsu.Clear();

                txtci.Text = dat3.Rows[0][0].ToString();
                txtnom.Text = dat3.Rows[0][1].ToString();
                txtApp.Text = dat3.Rows[0][2].ToString();
                txttel.Text = dat3.Rows[0][4].ToString();
                fecha.Text = dat3.Rows[0][5].ToString();
                cbGenero.Text = dat3.Rows[0][3].ToString();
                txtNit.Text = dat3.Rows[0][6].ToString();
                cbRubro.Text = dat3.Rows[0][7].ToString();

                btn_Reg.Enabled = true;
                btnImprimir.Enabled = true;
                txtci.Enabled = false;
            }
            catch (Exception se)
            {
                MessageBox.Show("Formato Incorrecto!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtconsu.Clear();
            }
        }
        //boton buscar por nombre
        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = objCliente.buscarPorNombre(txtconsu.Text);
            dg.DataSource = dt;
            txtconsu.Clear();
        }
        //boton modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtci.Text.Trim() != "" && txtnom.Text.Trim() != "" && txtApp.Text.Trim() != "" && txttel.Text.Trim() != "" && txtNit.Text.Trim() != "")
            {
                cargarDatosPersona();
                cargarCliente();
                objPersona.modificar_persona();
                objCliente.modificar_cliente();
                lb_mostrar.Text = "Modifico exitosamente!!";
                traerUltimoDato(txtci.Text);
                btnImprimir.Enabled = true;
            }
            else
            {
                MessageBox.Show("completar los campos!!", "error!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //boton eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                cargarDatosPersona();
                cargarCliente();
                objCliente.eliminar_cliente(txtci.Text);
                objPersona.eliminar(txtci.Text);
                lb_mostrar.Text = "Elimino exitosamente!!";
                limpiar();
            }
             catch(Exception se)
            {
            MessageBox.Show("error !!");
            }
        }
    }
}
