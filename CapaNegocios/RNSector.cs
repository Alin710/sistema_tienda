using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocios
{
    public class RNSector:CapaConexion.conexion
    {
        public DataSet traer_datos_sector()
        {
            string sql = "select * from sector";
            return (consultarDataset(sql));
        }
    }
}
