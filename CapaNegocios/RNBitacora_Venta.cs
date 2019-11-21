using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace CapaNegocios
{
    public class RNBitacora_Venta:CapaConexion.conexion
    {
        public DataTable consultar_bitacora_venta(string a,string m,string d)
        {
            string sql = "select b.idBitacora as codigo,b.tabla,b.operacion,b.fecha,b.usuario,b.host from bitacoraVenta b where year( b.fecha)='" + a + "' and MONTH(b.fecha)='" + m + "' and DAY(b.fecha)='" + d + "'";
            return(consultar(sql));
        }
    }
}
