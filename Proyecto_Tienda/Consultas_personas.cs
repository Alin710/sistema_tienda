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
    public partial class Consultas_personas : DevComponents.DotNetBar.Metro.MetroForm
    {
        RNHorario objHorario = new RNHorario();
        RNSucursal objSucursal = new RNSucursal();
        RNSector objSector = new RNSector();
        RNEmpleado objEmpleado = new RNEmpleado();
        RNRubro ObjRubro = new RNRubro();
        RNCliente objCliente = new RNCliente();
        
        public Consultas_personas()
        {
            InitializeComponent();
            btnImprimir.Enabled = false;
            btnI.Enabled = false;
        }
        void cargarHorario()
        {
            DataSet dt = objHorario.traerDatosHorario();
            cbHorario.DataSource=dt.Tables[0];
            cbHorario.DisplayMember = "nombre";
            cbHorario.ValueMember = "idHorario";
        }
        void cargarSucursal()
        {
            DataSet dt = objSucursal.traer_Datos_Sucursal();
            cbSucursal.DataSource = dt.Tables[0];
            cbSucursal.DisplayMember = "nombre";
            cbSucursal.ValueMember = "idSucursal";
        }
        void cargarSector()
        {
            DataSet dt = objSector.traer_datos_sector();
            cbSector.DataSource = dt.Tables[0];
            cbSector.DisplayMember = "nombre";
            cbSector.ValueMember = "idSector";
        }
        void cargarRubro()
        {
            DataSet dt = ObjRubro.traerDatosRubro();
            cbRubro.DataSource = dt.Tables[0];
            cbRubro.DisplayMember = "nombre";
            cbRubro.ValueMember = "idRubro";
        }
        private void Consultas_personas_Load(object sender, EventArgs e)
        {
            cargarHorario();
            cargarSucursal();
            cargarSector();
            cargarRubro();
        }
        //buscar
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = objEmpleado.busqueda_su_sec_hor(cbSucursal.SelectedValue.ToString(), cbSector.SelectedValue.ToString(), cbHorario.SelectedValue.ToString());
                dg.DataSource = dt;
                dtv = dt;
                btnImprimir.Enabled = true;
            }
            catch (Exception se)
            {
                MessageBox.Show("error!!");
            }
        }
        DataTable dtv;
        Reporte_empleados_Filtros frv;
        bool b = false;
        //boton imprimir
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if ((b == false) || (frv.IsDisposed))
                {
                    frv = new Reporte_empleados_Filtros(dtv);
                    frv.Show();
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Error!!");
            }
        }
        //btn consultar clientes
        private void btnConsultat_Click(object sender, EventArgs e)
        {
            DataTable dt = objCliente.busqueda_cliente_rubro(cbRubro.SelectedValue.ToString());
            dg1.DataSource = dt;
            btnI.Enabled = true;
        }

        private void btnE_Click(object sender, EventArgs e)
        {

        }
    }
}
