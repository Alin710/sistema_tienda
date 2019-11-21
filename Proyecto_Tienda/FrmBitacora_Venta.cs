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
    public partial class FrmBitacora_Venta : DevComponents.DotNetBar.Metro.MetroForm
    {
        RNBitacora_Venta objBitacora = new RNBitacora_Venta();

        public FrmBitacora_Venta()
        {
            InitializeComponent();
        }
        //btn conultar
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAño.Text.Trim() != "")
                {
                    DataTable dt = objBitacora.consultar_bitacora_venta(txtAño.Text, cbMes.Text, cbDia.Text);
                    dg.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("completar los campos!!");
                }
            }
            catch (Exception se)
            {
                MessageBox.Show("error!!");
                txtAño.Clear();
            }
        }
    }
}
