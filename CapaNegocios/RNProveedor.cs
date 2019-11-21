using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//adde
using System.Data;


namespace CapaNegocios
{
    public class RNProveedor:CapaConexion.conexion
    {

        public DataTable traeDatos()
        {
            string sql = "select * from persona p inner join proveedor  pr on pr.id=p.idPersona";
            return (consultar(sql));
        }
    }
}
