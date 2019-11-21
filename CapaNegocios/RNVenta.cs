using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//adde
using System.Data;

namespace CapaNegocios
{
    public class RNVenta:CapaConexion.conexion
    {
        public string[] v = new string[4];
        string tabla = "venta";


        public int insertar(object tr)
        {
            string s = "insert into #tabla values('#v1','#v2','#v3')";
            s = s.Replace("#tabla", tabla);

            s = s.Replace("#v1", v[1]);
            s = s.Replace("#v2", v[2]);
            s = s.Replace("#v3", v[3]);
            return ejecutar(s, tr);
        }
        //traer venta juan
        public DataTable traerLaVenta(string id)
        {
            //string s = "select * from venta inner join detalle_venta on venta.idventa=detalle_venta.idventa where venta.idventa =" + id;
            string s = "select v.idVenta as codigoV,pr.nombre as producto,pe.nom as empleado,perr.nom as cliente,v.fecha,dt.cantv as cantidad from venta v inner join detalle_venta dt on dt.idventa=v.idVenta inner join persona pe on pe.idPersona=v.idEmpleado inner join persona perr on perr.idPersona=v.idCliente inner join producto pr on pr.idProducto=dt.idProducto where v.idventa ='" + id + "'";
            return consultar(s);
        }
        //llave
        public string llave(object tr)
        {
            string s = "select max(idventa) from venta";
            return consultar(s, tr).Rows[0][0].ToString();
        }

        public DataTable ventas()
        {
            string s = "ventas";
            return consultar(s);
        }
        public string idc = "";
        public string ide = "";
        public string fecha = "";

        public int insertar1()
        {
            string s = "insert into venta values(" + "'" + idc + "','" + ide + "','" + fecha + "'" + ")";
            return (ejecutar(s));
        }
        //----------------CONSULTAS JUAN------------------------------------------------------------------------------------------------------------
        public DataTable traer_consulta_pivot_(string a,string ci)
        {
            string sql = "consultas_venta_realizadas #a,#ci";
            sql = sql.Replace("#a",a);
            sql = sql.Replace("#ci", ci);
            return (consultar(sql));
        }
        public DataTable consulta_fecha_ci_cliente(string c, string f)
        {
            string sql = "select v.idVenta as codigoV,pr.nombre as producto,pe.nom as empleado,perr.nom as cliente,v.fecha,dt.cantv as cantidad from venta v inner join detalle_venta dt on dt.idventa=v.idVenta inner join persona pe on pe.idPersona=v.idEmpleado inner join persona perr on perr.idPersona=v.idCliente inner join producto pr on pr.idProducto=dt.idProducto where perr.idPersona ='" + c + "'and v.fecha='" + f + "'";
            return (consultar(sql));
        }
        public DataTable consulta_fecha(string f)
        {
            string sql = "select v.idVenta as codigoV,pr.nombre as producto,pe.nom as empleado,perr.nom as cliente,v.fecha,dt.cantv as cantidad from venta v inner join detalle_venta dt on dt.idventa=v.idVenta inner join persona pe on pe.idPersona=v.idEmpleado inner join persona perr on perr.idPersona=v.idCliente inner join producto pr on pr.idProducto=dt.idProducto where v.fecha='" + f + "'";
            return (consultar(sql));
        }
        public DataTable consulta_fecha_ci_cliente_nro(string c, string f,string n)
        {
            string sql = "select v.idVenta as codigoV,pr.nombre as producto,pe.nom as empleado,perr.nom as cliente,v.fecha,dt.cantv as cantidad from venta v inner join detalle_venta dt on dt.idventa=v.idVenta inner join persona pe on pe.idPersona=v.idEmpleado inner join persona perr on perr.idPersona=v.idCliente inner join producto pr on pr.idProducto=dt.idProducto where perr.idPersona ='" + c + "'and v.fecha='" + f + "'and v.idVenta='" + n + "'";
            return (consultar(sql));
        }
        public DataTable consulta_ventas_rango_fechas(string fi,string ff)
        {
            string sql = "select v.idVenta as codigoV,pr.nombre as producto,pe.nom as empleado,perr.nom as cliente,v.fecha,dt.cantv as cantidad from venta v inner join detalle_venta dt on dt.idventa=v.idVenta inner join persona pe on pe.idPersona=v.idEmpleado inner join persona perr on perr.idPersona=v.idCliente inner join producto pr on pr.idProducto=dt.idProducto where v.fecha between'" + fi + "' and '" + ff + "' order by (v.fecha) asc";
            return (consultar(sql));
        }
        public int eliminar_venta(string cod)
        {
            string sql = "delete from venta  where idVenta='" + cod + "'";
            return(ejecutar(sql));
        }
        public int eliminar_detalle_venta(string cod)
        {
            string sql = "delete from detalle_venta where idventa='" + cod + "'";
            return (ejecutar(sql));
        }
    }
}
