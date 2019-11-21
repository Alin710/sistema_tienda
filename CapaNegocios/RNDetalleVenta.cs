using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class RNDetalleVenta:CapaConexion.conexion
    {
        public string[] v = new string[4];
        string tabla = "detalle_venta";

        public int insertar(object tr)
        {
            string s = "Insert into #tabla values('#v0','#v1','#v2','#v3')";
            s = s.Replace("#tabla", tabla);
            s = s.Replace("#v0", v[0]);
            s = s.Replace("#v1", v[1]);
            s = s.Replace("#v2", v[2]);
            s = s.Replace("#v3", v[3]);
            return ejecutar(s, tr);
        }
        //public int eliminar(string cod)
        //{
        //    string sql = "delete from detalle_venta where idVenta=" + cod;
        //    return (ejecutar(sql));
        //}

    }
}
