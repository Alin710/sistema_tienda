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
    public partial class FrmLogin : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        RNUsuario obu = new RNUsuario();
        //limpiar
        void limpiar()
        {
            txtRegistro.Clear();
            txtContraseña.Clear();
        }

        //adm
        FrmPrincipal_ADM f1;
        bool b2 = false;
        //empleado
        FrmPrincipal_Empleado f2;
        bool b1 = false;

        //boton adm
        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Trim() != "" && txtRegistro.Text.Trim() != "")
            {
                DataTable d = obu.pdatosADM(txtRegistro.Text, txtContraseña.Text);
                if (d.Rows.Count > 0)
                {
                    if ((b2 == false) || (f1.IsDisposed))
                    {
                        f1 = new FrmPrincipal_ADM(d);
                        f1.Show();
                        b2 = true;
                    }
                }
                limpiar();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Completar los campos", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //---------------------------------------------------------------------------------
        }
        //boton empleado
        private void bt2_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Trim() != "" && txtRegistro.Text.Trim() != "")
            {
                DataTable d = obu.pdatos(txtRegistro.Text, txtContraseña.Text);
                if (d.Rows.Count > 0)
                {
                    if ((b1 == false) || (f2.IsDisposed))
                    {
                        f2 = new FrmPrincipal_Empleado(d);
                        f2.Show();
                        b1 = true;
                    }
                }
                limpiar();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Completar los campos", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //evento key press del boton adm
        private void btn1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //    if ((int)e.KeyChar == (int)Keys.Enter)
            //    {
            //        if (txtContraseña.Text.Trim() != "" && txtRegistro.Text.Trim() != "")
            //        {
            //            DataTable d = obu.pdatosADM(txtRegistro.Text, txtContraseña.Text);
            //            if (d.Rows.Count > 0)
            //            {
            //                if ((b2 == false) || (f1.IsDisposed))
            //                {
            //                    f1 = new FrmPrincipal_ADM(d);
            //                    f1.Show();
            //                    b2 = true;
            //                }
            //            }
            //            limpiar();
            //            this.Hide();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Completar los campos", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //    }
            //}


        }


    }
}
