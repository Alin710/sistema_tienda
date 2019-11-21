using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Tienda
{
    public partial class FrmBloquear : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmBloquear()
        {
            InitializeComponent();
        }

        private void FrmBloquear_Load(object sender, EventArgs e)
        {
            //web
            this.webBrowser1.Url = new System.Uri(msc() + "\\bloquear\\slider.html", System.UriKind.Absolute); 
        }

        string msc()
        {
            string dir = Application.StartupPath;
            return dir;

        }
        
    }
}
