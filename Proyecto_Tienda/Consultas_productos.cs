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
    public partial class Consultas_productos : DevComponents.DotNetBar.Metro.MetroForm
    {
        RNProveedor objProveedor = new RNProveedor();
        RNMaterial objMaterial = new RNMaterial();
        RNProducto objProducto = new RNProducto();


        public Consultas_productos()
        {
            InitializeComponent();
        }
        //img consultar
        private void ImgConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = objProducto.consulta_proveedor_genero_material(cbProveedor.SelectedValue.ToString(), cbGenero.SelectedText, cbMaterial.SelectedValue.ToString());
                dg.DataSource = dt;
                dtv = dt;
            }
            catch (Exception se)
            {
                MessageBox.Show("Formato Incorrecto!!");
            }
        }
        void cargar_combo_materia()
        {
            DataTable dt = objMaterial.traerDatos();
            cbMaterial.DataSource = dt;
            cbMaterial.DisplayMember = "nombre";
            cbMaterial.ValueMember = "idMaterial";
        }
        //cargar combo proveedor
        void cargar_combo_proveedor()
        {
            DataTable dt = objProveedor.traeDatos();
            cbProveedor.DataSource = dt;
            cbProveedor.DisplayMember = "nom";
            cbProveedor.ValueMember = "idPersona";
        }
        //click en el frm
        private void Consultas_productos_Load(object sender, EventArgs e)
        {
            cargar_combo_proveedor();
            cargar_combo_materia();
        }
        DataTable dtv;
        Reporte_Productos frv;
        bool b = false;
        //boton imprimir
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if ((b == false) || (frv.IsDisposed))
                {
                    frv = new Reporte_Productos(dtv);
                    frv.Show();
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Error!!");
            }
        }
        //link consultar lotes de entrega
        private void Lb_lotes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Consultas_lotes a = new Consultas_lotes();
            a.ShowDialog();
        }
    }
}
