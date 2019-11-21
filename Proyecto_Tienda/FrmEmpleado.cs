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
    public partial class FrmEmpleado : DevComponents.DotNetBar.Metro.MetroForm
    {
        RNEmpleado objEmpleado = new RNEmpleado();
        RNPersona objPersona = new RNPersona();
        RNSucursal objSucursal = new RNSucursal();

        public FrmEmpleado()
        {
            InitializeComponent();
        }
        //evento
        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow a = dg.Rows[e.RowIndex];
                txtci.Text = a.Cells[0].Value.ToString();
                txtnom.Text = a.Cells[1].Value.ToString();
                txtApp.Text = a.Cells[2].Value.ToString();
                txttel.Text = a.Cells[3].Value.ToString();
                fecha.Text = a.Cells[5].Value.ToString();
                cbGenero.Text = a.Cells[4].Value.ToString();
                txtCorreo.Text = a.Cells[6].Value.ToString();

                btn_Reg.Enabled = false;
                btnModificar.Enabled = true;
                btnImprimir.Enabled = true; ;

            }
            catch (Exception se)
            {
                MessageBox.Show("error!!");
            }
        }
        //boton ver
        private void btnVer_Click(object sender, EventArgs e)
        {
            DataTable dt = objEmpleado.traerDatos();
            dg.DataSource = dt;

            btnImprimir.Enabled = false;
        }
        //traer ultimo dato
        void traerUltimo(string cod)
        {
            DataTable dt = objEmpleado.traerUltimoDato(cod);
            dg.DataSource = dt;
            dtv = dt;
        }
        string refe = "";
        bool activado = false;
        //buscar por ci
        private void button1_Click(object sender, EventArgs e)
        {
            //traerUltimo(txtconsu.Text);
            try
            {
                refe = txtconsu.Text;
                DataTable dat3 = objEmpleado.traerUltimoDato(txtconsu.Text);
                dg.DataSource = dat3;
                dtv = dat3;
                txtconsu.Clear();

                txtci.Text = dat3.Rows[0][0].ToString();
                txtnom.Text = dat3.Rows[0][1].ToString();
                txtApp.Text = dat3.Rows[0][2].ToString();
                txttel.Text = dat3.Rows[0][3].ToString();
                fecha.Text = dat3.Rows[0][5].ToString();
                cbGenero.Text = dat3.Rows[0][4].ToString();
                txtCorreo.Text = dat3.Rows[0][6].ToString();

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

        DataTable dtv;
        ReporteEmpleado frv;
        bool b = false;
        //boton imprimir
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if ((b == false) || (frv.IsDisposed))
                {
                    frv = new ReporteEmpleado(dtv);
                    frv.Show();
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Error!!");
            }
        }
        //limpiar
        void limpiar()
        {
            txtci.Clear();
            txtnom.Clear();
            txtApp.Clear();
            txttel.Clear();
            txtCorreo.Clear();
        }
        //boton limpiar
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            btn_Reg.Enabled = true;
            btnImprimir.Enabled = false;
            btnModificar.Enabled = false;
        }
        //boton cargar img
        private void btncargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (opf2.ShowDialog() == DialogResult.OK)
                {
                    string imagen = opf2.FileName;
                    pcb2.Image = Image.FromFile(imagen);
                    objEmpleado.foto = imagen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
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
        //cragarEmpleado
        void cargarDatosEmpleado()
        {
            objEmpleado.ci = txtci.Text;
            objEmpleado.correo = txtCorreo.Text;

        }
        //boton registrar
        private void btn_Reg_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtci.Text.Trim() != "" && txtnom.Text.Trim() != "" && txtApp.Text.Trim() != "" && txttel.Text.Trim() != "")
                {
                    cargarDatosPersona();
                    cargarDatosEmpleado();
                    objPersona.insertarPersona();
                    objEmpleado.insertar_empleado();
                    lb_mostrar.Text = "Se Registro Exitosamente a !! " + txtnom.Text;
                    traerUltimo(txtci.Text);

                }
                else
                {
                    MessageBox.Show("completar los campos", "error!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception se)
            {
                MessageBox.Show("error!!");
            }
        }

        //boton modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtci.Text.Trim() != "" && txtnom.Text.Trim() != "" && txtApp.Text.Trim() != "" && txttel.Text.Trim() != "")
                {
                    cargarDatosPersona();
                    cargarDatosEmpleado();
                    objPersona.modificar_persona();
                    objEmpleado.modificar_empeado();
                    lb_mostrar.Text = "Se Modificò Exitosamente a !! " + txtnom.Text;
                    traerUltimo(txtci.Text);
                }
                else
                {
                    MessageBox.Show("completar los campos", "error!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception se)
            {
                MessageBox.Show("error!!");
            }
        }
        //boton buscar por nombre
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = objEmpleado.Buscar_empleadoPorNombre(txtconsu.Text);
                dg.DataSource = dt;
                txtconsu.Clear();
                dtv = dt;
            }
            catch (Exception se)
            {
                MessageBox.Show("error!!");
            }
        }

    
    }
}
