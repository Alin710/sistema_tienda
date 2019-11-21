using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//adde
using System.Data;

namespace CapaNegocios
{
    public class RNUsuario:CapaConexion.conexion
    {

        //ADM
        public DataTable datosADM(string nu, string clave,string t = "adm")
        {
            string s = "select persona.idPersona,persona.nom,adm.idempleado,adm.correoe,usuario.nu,usuario.clave from persona inner join adm on persona.idpersona=adm.idempleado inner join usuario on  persona.idpersona=usuario.idusuario where usuario.nu='#d1#' and usuario.clave='#d2#'";
            s = s.Replace("#d1#", nu);
            s = s.Replace("#d2#", clave);
            s = s.Replace("#tabla#", t);
            return consultar(s);
        }
        //empleado
        public DataTable datos(string nu, string clave, string t = "empleado")
        {
            string s = "select persona.idPersona,persona.nom,empleado.idempleado,empleado.correoe,usuario.nu,usuario.clave  from persona inner join empleado on persona.idpersona=empleado.idempleado inner join usuario on persona.idpersona=usuario.idusuario where usuario.nu='#d1#' and usuario.clave='#d2#'";
            s = s.Replace("#d1#", nu);
            s = s.Replace("#d2#", clave);
            s = s.Replace("#tabla#", t);
            return consultar(s);
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //ingresar como adm
        public DataTable pdatosADM(string nu, string clave)
        {
            DataTable d = null;
            d = datosADM(nu, clave);
            if (d.Rows.Count > 0)
                return d;
            d = datosADM(nu, clave, "empleado");
            return d;
        }
        //ingresar como empleado
        public DataTable pdatos(string nu, string clave)
        {
            DataTable d = null;
            d = datos(nu, clave);
            if (d.Rows.Count > 0)
                return d;
            d = datos(nu, clave, "cliente");
            return d;
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string id = "";
        public string usu = "";
        public string cont = "";

        //insertar datos en la tabla usuario
        public int insertar_datos_usuario()
        {
            string sql = "insert into usuario values(" + "'" + id + "','" + usu + "','" + cont + "'" + ")";
            return (ejecutar(sql));
        }
        public int eliminar(string cod)
        {
            string sql = "delete from usuario where idUsuario=" + cod;
            return (ejecutar(sql));
        }
        public int modificar()
        {
            string sql = "update usuario set nu='" + usu + "',clave='" + cont + "' where idusuario='" + id + "'";
            return (ejecutar(sql));
        }
        public DataTable traer_ultimo_registro(string cod)
        {
            string sql = "select u.idusuario as ci,u.nu as usuario,u.clave as contraseña from usuario u  where u.idusuario=" + cod;
            return (consultar(sql));
        }
        public DataTable buscar_usuario_ci(string cod)
        {
            string sql = "select p.idPersona as ci,(p.nom + ' ' + p.apellidos) as empleado,u.nu as usuario,u.clave as contraseña  from persona p inner join usuario u on u.idusuario=p.idPersona where u.idusuario=" + cod;
            return (consultar(sql));
        }
        public DataTable buscar_usuario_nombre(string cod)
        {
            cod = "'%" + cod + "%'";
            string sql = "select p.idPersona as ci,(p.nom + ' ' + p.apellidos) as empleado,u.nu as usuario,u.clave as contraseña  from persona p inner join usuario u on u.idusuario=p.idPersona where p.nom like" + cod;
            return (consultar(sql));
        }
    }
}
