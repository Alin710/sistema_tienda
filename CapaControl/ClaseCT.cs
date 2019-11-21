using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//adde
using System.Data.OleDb;

namespace CapaControl
{
    public class ClaseCT:CapaConexion.conexion
    {
        public OleDbTransaction iniTR()
        {
            return iniciarTransaccion();
        }
        public void finTR(OleDbTransaction tr)
        {
            tr.Commit();
        }
        public void deshacerTR(object tr)
        {
            ((OleDbTransaction)(tr)).Rollback();
        }

    }
}
