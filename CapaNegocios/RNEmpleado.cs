using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace CapaNegocios
{
    public class RNEmpleado:CapaConexion.conexion
    {
        public string ci = "";
        public string correo = "";
        public string foto = "";

        public int insertar_empleado()
        {
            string sql = "insert into empleado values(" + "'" + ci + "','" + correo + "','" +  foto  + "'" + ")";
            return (ejecutar(sql));
        }
        public int modificar_empeado()
        {
            string sql = "update empleado set correoe='" + correo  + "',foto='" + foto + "' where idempleado='" + ci + "'";
            return (ejecutar(sql));
        }
        public DataTable traerDatos()
        {
            string sql = "select p.idPersona as ci,p.nom as empleado,p.apellidos,p.telefono,p.genero,p.fechaN,e.correoe from persona p inner join empleado e on e.idempleado=p.idPersona ";
            return (consultar(sql));
        }
        public DataTable traerUltimoDato(string cod)
        {
            string sql = "select p.idPersona as ci,p.nom as empleado,p.apellidos,p.telefono,p.genero,p.fechaN,e.correoe from persona p inner join empleado e on e.idempleado=p.idPersona  where p.idPersona='" + cod + "'";
            return (consultar(sql));
        }


        //-------------------------------------------------------------
        public DataTable Buscar_empleadoPorNombre(string cod)
        {
            cod = "'%" + cod + "%'";
            string sql = "select p.idPersona as ci,p.nom as empleado,p.apellidos,p.telefono,p.genero,p.fechaN,e.correoe from persona p inner join empleado e on e.idempleado=p.idPersona  where p.nom like" + cod;
            return (consultar(sql));
        }

        public DataTable busqueda_su_sec_hor(string suc,string sec,string hor)
        {
            string sql = "select p.idPersona as ci,(p.nom + ' ' + p.apellidos) as empleado,p.telefono,DATEDIFF(YEAR,p.fechaN,GETDATE()) as edad,sucu.nombre as sucursal,sec.nombre as sector,ho.nombre as horario,c.fechaIngreso as fechaI,DATEDIFF(YEAR,c.fechaIngreso,GETDATE()) as antiguedad,c.sueldo from contrato c inner join persona p on p.idPersona=c.idEmpleado inner join sucursal sucu on sucu.idSucursal=c.idSucursal inner join sector  sec on sec.idSector=c.idSector inner join horario ho on ho.idHorario=c.idHorario where sucu.idSucursal='" + suc + "' and sec.idSector='" + sec + "'and ho.idHorario='" + hor + "'";
            return (consultar(sql));
        }
        public DataTable traerDatos_solo_cajeros()
        {
            string sql = "select e.idPersona as ci,e.nom as cajero,suc.nombre as sucursal from persona e inner join contrato c on c.idEmpleado=e.idPersona inner join sector s on s.idSector=c.idSector inner join sucursal suc on suc.idSucursal=c.idSucursal where s.nombre='caja' and suc.idSucursal=1";
            return (consultar(sql));
        }
        public DataTable buscar_solo_cajeros(string cod)
        {
            cod = "'%" + cod + "%'";
            string sql = "select e.idPersona as ci,e.nom as cajero,suc.nombre as sucursal from persona e inner join contrato c on c.idEmpleado=e.idPersona inner join sector s on s.idSector=c.idSector inner join sucursal suc on suc.idSucursal=c.idSucursal where s.nombre='caja' and suc.idSucursal=1 and e.nom like" + cod;
            return (consultar(sql));
        }
    }
}
