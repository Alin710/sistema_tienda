using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace CapaNegocios
{
    public class RNHorario:CapaConexion.conexion
    {
        public DataSet traerDatosHorario()
        {
            string sql = "select * from horario";
            return (consultarDataset(sql));
        }
    }
}
