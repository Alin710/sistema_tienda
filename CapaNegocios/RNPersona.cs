using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class RNPersona:CapaConexion.conexion
    {
        public string ci = "";
        public string nom = "";
        public string apell = "";
        public string fono = "";
        public string gen = "";
        public string fn = "";

        public int insertarPersona()
        {
            string sql = "insert into persona values(" + "'" + ci + "','" + nom + "','" + apell + "','" + fono + "','" + gen + "','" + fn + "'" + ")";
            return (ejecutar(sql));
        }
        public int modificar_persona()
        {
            string sql = "update persona set nom='" + nom + "',apellidos='" + apell + "',telefono='" + fono + "',genero='" + gen + "',fechaN='" + fn + "' where idPersona='" + ci + "'" ;
            return (ejecutar(sql));
        }
        public int eliminar(string c)
        {
            string sql = "delete from persona where idPersona=" + c;
            return (ejecutar(sql));
        }
    }
}
