using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//adde
using System.Data;


namespace CapaNegocios
{
    public class RNMaterial:CapaConexion.conexion
    {

        public DataTable traerDatos()
        {
            string sql = "select * from material";
            return (consultar(sql));
        }

    }
}
