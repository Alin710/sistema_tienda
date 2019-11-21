using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//adde
using System.Data;

namespace CapaNegocios
{
    public class RNContrato:CapaConexion.conexion
    {
        public string codig = "";
        public string hor = "";
        public string f = "";
        public string sect = "";
        public string sucu = "";
        public string empl = "";
        public string suel = "";

        public int insertar_contrato()
        {
            string sql = "insert into contrato values(" + "'" + hor + "','" + f + "','" + sect + "','" + sucu + "','" +  empl + "','" + suel + "'" + ")";
            return (ejecutar(sql));
        }
        public int eliminar(string cod)
        {
            string sql = "delete from contrato where idContrato='" + cod + "'";
            return (ejecutar(sql));
        }
        public int modificar()
        {
            string sql = "update contrato set idHorario='" + hor + "',fechaIngreso='" + f + "',idSector='" + sect  + "',idSucursal='" + sucu +  "',idEmpleado='" + empl + "',sueldo='" + suel + "' where idContrato='" + codig + "'";
            return (ejecutar(sql));
        }
        public DataTable traerDatos()
        {
            string sql = "select c.idContrato as codigo,(per.nom  + ' ' + per.apellidos)  as empleado,per.idPersona as ci,c.fechaIngreso,h.nombre as horario,se.nombre as sector,suc.nombre as sucursal,c.sueldo from contrato c inner join horario h on h.idHorario=c.idHorario inner join sector se on se.idSector=c.idSector inner join persona per on per.idPersona=c.idEmpleado inner join sucursal suc on suc.idSucursal=c.idSucursal";
            return (consultar(sql));
        }
        public DataTable traerUltimoDato(string cod)
        {
            string sql = "select c.idContrato as codigo,(per.nom  + ' ' + per.apellidos)  as empleado,per.idPersona as ci,c.fechaIngreso,h.nombre as horario,se.nombre as sector,suc.nombre as sucursal,c.sueldo  from contrato c inner join horario h on h.idHorario=c.idHorario inner join sector se on se.idSector=c.idSector inner join persona per on per.idPersona=c.idEmpleado inner join sucursal suc on suc.idSucursal=c.idSucursal where per.idPersona='" + cod + "'";
            return (consultar(sql));
        }

        public DataTable consulta_rango_fechas(string a, string FI,string FF)
        {
            string sql = "select c.idContrato as codigo,(per.nom  + ' ' + per.apellidos)  as empleado,per.idPersona as ci,c.fechaIngreso,h.nombre as horario,se.nombre as sector,suc.nombre as sucursal,c.sueldo  from contrato c inner join horario h on h.idHorario=c.idHorario inner join sector se on se.idSector=c.idSector inner join persona per on per.idPersona=c.idEmpleado inner join sucursal suc on suc.idSucursal=c.idSucursal  where suc.idSucursal='" + a + "' and  c.fechaIngreso  between  '" + FI + "' and '" + FF + "'";
            return (consultar(sql));
        }
        public DataTable consulta_año_mes(string a, string m)
        {
            string sql = "select c.idContrato as codigo,(per.nom  + ' ' + per.apellidos)  as empleado,per.idPersona as ci,c.fechaIngreso,h.nombre as horario,se.nombre as sector,suc.nombre as sucursal,c.sueldo  from contrato c inner join horario h on h.idHorario=c.idHorario inner join sector se on se.idSector=c.idSector inner join persona per on per.idPersona=c.idEmpleado  inner join sucursal suc on suc.idSucursal=c.idSucursal where YEAR(c.fechaIngreso)='" + a + "'and MONTH(c.fechaIngreso)='" + m + "'";
            return (consultar(sql));
        }
        public DataTable consulta_año_mes_dia(string a, string m, string d)
        {
            string sql = "select c.idContrato as codigo,(per.nom  + ' ' + per.apellidos)  as empleado,per.idPersona as ci,c.fechaIngreso,h.nombre as horario,se.nombre as sector,suc.nombre as sucursal,c.sueldo from contrato c inner join horario h on h.idHorario=c.idHorario inner join sector se on se.idSector=c.idSector inner join persona per on per.idPersona=c.idEmpleado inner join sucursal suc on suc.idSucursal=c.idSucursal where YEAR(c.fechaIngreso)='" + a + "'and MONTH(c.fechaIngreso)='" + m + "' and DAY(c.fechaIngreso)='" + d + "'";
            return (consultar(sql));
        }
    }
}
