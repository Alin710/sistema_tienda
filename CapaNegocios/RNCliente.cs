using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocios
{
    public class RNCliente:CapaConexion.conexion
    {
        public string id = "";
        public string nt = "";
        public string ru = "";

        public int insertarCliente()
        {
            string sql = "insert into cliente values(" +   "'" + id + "','" + nt + "','" + ru + "'" + ")";
            return (ejecutar(sql));
        }
        public int modificar_cliente()
        {
            string sql = "update cliente set nit='" + nt + "',rubro='" + ru + "' where idCliente='" + id + "'";
            return (ejecutar(sql));
        }
        public int eliminar_cliente(string c)
        {
            string sql = "delete from cliente where idCliente=" + c;
            return (ejecutar(sql));
        }
        public DataTable traerUltimoDato(string  cod)
        {
            string sql = "select p.idPersona as ci,p.nom as cliente,p.apellidos,p.genero,p.telefono,p.fechaN,c.nit,r.nombre as rubro  from persona p inner join cliente c on c.idCliente=p.idPersona inner join rubro r on r.idRubro=c.rubro where p.idPersona='" + cod + "'";
            return (consultar(sql));
        }
        public DataTable traerDatos()
        {
            string sql = "select p.idPersona as ci,p.nom as cliente,p.apellidos,p.genero,p.telefono,p.fechaN,c.nit,r.nombre as rubro  from persona p inner join cliente c on c.idCliente=p.idPersona inner join rubro r on r.idRubro=c.rubro ";
            return (consultar(sql));
        }
        public DataTable buscarPorNombre(string cod)
        {
            cod = "'%" + cod + "%'";
            string s = "select p.idPersona as ci,p.nom as cliente,p.apellidos,p.genero,p.telefono,p.fechaN,c.nit,r.nombre as rubro  from persona p inner join cliente c on c.idCliente=p.idPersona inner join rubro r on r.idRubro=c.rubro where p.nom like " + cod;
            return (consultar(s));
        }
        public DataTable busqueda_cliente_rubro(string r)
        {
            string sql = "select p.idPersona as ci,p.nom  + ' ' +p.apellidos as cliente,DATEDIFF(YEAR,p.fechaN,GETDATE()) as edad,p.genero,p.telefono,r.nombre as rubro  from persona p inner join cliente c on c.idCliente=p.idPersona inner join rubro r on r.idRubro=c.rubro where r.idRubro='" + r + "'";
            return (consultar(sql));
        }
    }
}
