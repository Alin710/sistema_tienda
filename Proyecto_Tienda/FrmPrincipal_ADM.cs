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
using Microsoft.VisualBasic;

namespace Proyecto_Tienda
{
    public partial class FrmPrincipal_ADM : DevComponents.DotNetBar.Metro.MetroForm
    {
        private int childFormNumber = 0;

        DataTable d;
        public FrmPrincipal_ADM(DataTable dx)
        {
            InitializeComponent();
            timer1.Enabled = true;
            d = dx;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            //Form childForm = new Form();
            //childForm.MdiParent = this;
            //childForm.Text = "Ventana " + childFormNumber++;
            //childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        //frm cliente
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente childForm = new FrmCliente();
            childForm.MdiParent = this;
            childForm.Show();
        }
        //frm empleado
        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleado childForm = new FrmEmpleado();
            childForm.MdiParent = this;
            childForm.Show();
        }
        //fecha y hora
        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_fecha.Text = DateTime.Now.ToString();
        }
        void per(bool v)
        {
            //btn_imprimir.Visible = v;
            //btn_guardar.Visible = v;
        }
        //clik frm
        private void FrmPrincipal_Load(object sender, EventArgs e)
            {
                if (d.Columns[2].ColumnName == "idempleado")
                {
                    per(true);
                    Lb_usuario.Text = "Bienvenido señor/a ADM: " + d.Rows[0][1].ToString();
                }
            
            //web
            this.webBrowser1.Url = new System.Uri(msc() + "\\web\\bienvenidos.html", System.UriKind.Absolute); 
        }
        string msc()
        {
            string dir = Application.StartupPath;
            return dir;

        }
        //frm contrato
        private void contratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContrato childForm = new FrmContrato();
            childForm.MdiParent = this;
            childForm.Show();
        }
        //FrmConsultasContrato
        private void contratoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultasContrato childForm = new ConsultasContrato();
            childForm.MdiParent = this;
            childForm.Show();
        }
        //frm consultas persona
        private void personaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas_personas childForm = new Consultas_personas();
            childForm.MdiParent = this;
            childForm.Show();
        }
        //frm usuario
        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario childForm = new FrmUsuario();
            childForm.MdiParent = this;
            childForm.Show();
        }
        //frm venta
        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVenta childForm = new FrmVenta(d);
            childForm.MdiParent = this;
            childForm.Show();
        }
        //consultas de ventas
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas_Venta childForm = new Consultas_Venta();
            childForm.MdiParent = this;
            childForm.Show();
        }
       // Consultas_productos
        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas_productos childForm = new Consultas_productos();
            childForm.MdiParent = this;
            childForm.Show();
        }
        //FrmBitacora_Venta
        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBitacora_Venta childForm = new FrmBitacora_Venta();
            childForm.MdiParent = this;
            childForm.Show();
        }
        //FrmCancelar_Venta
        private void eliminarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCancelar_Venta childForm = new FrmCancelar_Venta();
            childForm.MdiParent = this;
            childForm.Show();
        }
        //salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEA CONTINUAR!!", "IR AL LOGIN", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                FrmLogin a = new FrmLogin();
                a.ShowDialog();

            }
        }
        //regresar al login
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("DESEA CONTINUAR!!", "IR AL LOGIN", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                FrmLogin a = new FrmLogin();
                a.ShowDialog();

            }
        }
        //ir a notepad
        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interaction.Shell(@"C:\Users\juand\Desktop\Proyecto_Tienda\Proyecto_Tienda\bin\Debug\web\a.bat");
        }
        //bloquear
        private void bloquearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBloquear childForm = new FrmBloquear();
            childForm.MdiParent = this;
            childForm.Show();

            menuStrip.Enabled = false;
            toolStrip.Enabled = false;
        }
        //desbloquear
        private void symbolBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin a = new FrmLogin();
            a.ShowDialog();
            menuStrip.Enabled = true;
            toolStrip.Enabled = true;
        }


    }
}
