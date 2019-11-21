using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace CapaNegocios
{
   public class RNSucursal:CapaConexion.conexion
    {

       public DataSet traer_Datos_Sucursal()
       {
           string sql = "select * from sucursal ";
           return (consultarDataset(sql));
       }
    }
}
