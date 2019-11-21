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
    public partial class FrmUsuario : DevComponents.DotNetBar.Metro.MetroForm
    {

        RNEmpleado objEmpleado = new RNEmpleado();
        RNUsuario objUsuario = new RNUsuario();


        public FrmUsuario()
        {
            InitializeComponent();
            groupBox1.Visible = false;
        }
        //link frm empleado
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmEmpleado o = new FrmEmpleado();
            o.ShowDialog();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }
        //btn buscar empleado solo cajeros
        private void btnBuscarE_Click(object sender, EventArgs e)
        {
            DataTable dt = objEmpleado.buscar_solo_cajeros(txtNombre.Text);
            dgb.DataSource = dt;
            txtNombre.Clear();
        }
        //evento del dg
        private void dgb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow a = dgb.Rows[e.RowIndex];
            txtCI.Text = a.Cells[0].Value.ToString();
        }
        //limpiar
        void limpiar()
        {
            txtCI.Clear();
            txtUsuario.Clear();
            txtPassword.Clear();
        }
        //traer ultimo dato
        void traer_Ultimo_Dato(string c)
        {
            DataTable dt = objUsuario.traer_ultimo_registro(c);
            dg.DataSource = dt;
        }
        //cargar datos
        void cargarDatos()
        {
            objUsuario.id = txtCI.Text;
            objUsuario.usu = txtUsuario.Text;
            objUsuario.cont = txtPassword.Text;
        }

        //boton registrar
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCI.Text.Trim() != "" && txtUsuario.Text.Trim() != "" && txtPassword.Text.Trim() != "")
                {
                    cargarDatos();
                    objUsuario.insertar_datos_usuario();
                    lbEstado.Text = "Registro Exitosamente!!";
                    traer_Ultimo_Dato(txtCI.Text);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("compleatar los campos!!");
                }
            }
            catch (Exception se)
            {
                MessageBox.Show("error!!");
            }
        }

        //buscar por nombre
        private void rb_nombre_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = objUsuario.buscar_usuario_nombre(txtBusar.Text);
                dg.DataSource = dt;
                txtBusar.Clear();
            }
            catch (Exception se)
            {
                MessageBox.Show("error!!");
            }
        }
        //buscar por nombre
        private void btn_buscar_nombre_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = objUsuario.buscar_usuario_nombre(txtBusar.Text);
                dg.DataSource = dt;
                txtBusar.Clear();
            }
            catch (Exception se)
            {
                MessageBox.Show("error!!");
            }
        }
        //buscar por ci
        private void btn_ci_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = objUsuario.buscar_usuario_ci(txtBusar.Text);
                dg.DataSource = dt;
                txtBusar.Clear();
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
            txtCI.Text = a.Cells[0].Value.ToString();
            txtUsuario.Text = a.Cells[2].Value.ToString();
            txtPassword.Text = a.Cells[3].Value.ToString();
        }
        //boton modificar
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCI.Text.Trim() != "" && txtUsuario.Text.Trim() != "" && txtPassword.Text.Trim() != "")
                {
                    cargarDatos();
                    objUsuario.modificar();
                    lbEstado.Text = "Modifico exitosamente!!";
                    traer_Ultimo_Dato(txtCI.Text);
                }
                else
                {
                    MessageBox.Show("compleatar los campos!!");
                }
            }
            catch (Exception se)
            {
                MessageBox.Show("error!!");
            }
        }
        //boton eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCI.Text.Trim() != "" && txtUsuario.Text.Trim() != "" && txtPassword.Text.Trim() != "")
                {
                    cargarDatos();
                    objUsuario.eliminar(txtCI.Text);
                    lbEstado.Text = "Elimino exitosamente!!";
                }
                else
                {
                    MessageBox.Show("compleatar los campos!!");
                }
            }
            catch (Exception se)
            {
                MessageBox.Show("error!!");
            }
        }

    }
}
