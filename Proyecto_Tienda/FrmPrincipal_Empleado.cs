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
    public partial class FrmPrincipal_Empleado : DevComponents.DotNetBar.Metro.MetroForm
    {
        private int childFormNumber = 0;
        DataTable d;
        public FrmPrincipal_Empleado(DataTable dx)
        {
            InitializeComponent();
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
        void per(bool v)
        {
            //btn_imprimir.Visible = v;
            //btn_guardar.Visible = v;
        }
        private void FrmPrincipal_Empleado_Load(object sender, EventArgs e)
        {
            if (d.Columns[2].ColumnName == "idempleado")
            {
                per(true);
                Lb_usuario.Text = "Bienvenido señor/a Empleado: " + d.Rows[0][1].ToString();
            }
        }
        //frm venta
        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVenta childForm = new FrmVenta(d);
            childForm.MdiParent = this;
            childForm.Show();
        }
        //INGRESAR COMO ADM
        private void aDMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ADM SISTEMA","ADM", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                FrmLogin a = new FrmLogin();
                a.ShowDialog();

            }
        }
        //notepad
        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interaction.Shell(@"C:\Users\juand\Desktop\Proyecto_Tienda\Proyecto_Tienda\bin\Debug\web\a.bat");
        }
        //login
        private void symbolBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin a = new FrmLogin();
            a.ShowDialog();
        }
    }
}
