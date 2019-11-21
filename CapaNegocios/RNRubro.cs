using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocios
{
    public class RNRubro:CapaConexion.conexion
    {

        public DataSet traerDatosRubro()
        {
            string sql = "select * from rubro";
            return (consultarDataset(sql));
        }
    }
}
