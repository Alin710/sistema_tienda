using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//adde
using System.Data;

namespace CapaNegocios
{
    public class RNProducto:CapaConexion.conexion
    {
        public DataTable consulta_proveedor_genero_material(string p, string g, string m)
        {
            string sql = "select p.idProducto as codigoP,p.nombre as producto,p.genero,ta.nombre as talla,m.nombre as marca,mat.nombre as material,per.nom as proveedor from producto p inner join marca m on m.idMarca=p.idMarca inner join talla ta on ta.idTalla=p.idTalla inner join material mat on mat.idMaterial=p.idMateria  inner join proveedor pr on pr.id=p.idProveedor inner join persona per on per.idPersona=pr.id where pr.id='" + p + "'and p.genero='" + g + "'and mat.idMaterial='" + m + "'";
            return (consultar(sql));
        }
        //busqueda de producto por codigo
        public DataTable buscar_producto_codigo(string cod)
        {
            string sql = "select  p.idProducto as codigo, p.nombre as producto,p.genero,t.nombre as talla,h.nombre as horma,ma.nombre as marca,mat.nombre as material,pe.nom as proveedor ,pg as 'Precio Venta',dt.identrega as 'Nro entrega',dt.cante as stock from detalle_lote_entrega  dt inner join producto p on dt.idproducto=p.idproducto inner join marca ma on ma.idMarca=p.idMarca inner join material mat on mat.idMaterial=p.idMateria inner join talla t on t.idTalla=p.idTalla inner join horma h on h.idHorma=t.idHorma  inner join proveedor pr on pr.id=p.idProveedor inner join persona pe on pe.idPersona=pr.id where p.idProducto=" + cod;
            return (consultar(sql));
        }
        //busqueda de producto por nombre
        public DataTable buscar_producto_nombre(string cod)
        {
            cod = "'%" + cod + "%'";
            string sql = "select  p.idProducto as codigo, p.nombre as producto,p.genero,t.nombre as talla,h.nombre as horma,ma.nombre as marca,mat.nombre as material,pe.nom as proveedor ,pg as 'Precio Venta',dt.identrega as 'Nro entrega',dt.cante as stock from detalle_lote_entrega  dt inner join producto p on dt.idproducto=p.idproducto inner join marca ma on ma.idMarca=p.idMarca inner join material mat on mat.idMaterial=p.idMateria inner join talla t on t.idTalla=p.idTalla inner join horma h on h.idHorma=t.idHorma  inner join proveedor pr on pr.id=p.idProveedor inner join persona pe on pe.idPersona=pr.id where p.nombre like" + cod;
            return (consultar(sql));
        }
        //busqueda de lotes de entrega
        public DataTable buscar_lotes(string f)
        {
            string sql = "select l.identrega as codigo,l.fecha,pro.nombre as producto,pro.genero,mat.nombre as materialta,ta.nombre as talla,ma.nombre as marca,per.nom as proveedor,per1.nom as empleado,dt.cante as cantidad,dt.pc,dt.pg  from lote_entrega l inner join detalle_lote_entrega dt on dt.identrega=l.identrega  inner join producto pro on pro.idProducto=dt.idproducto inner join proveedor p on p.id=l.idproveedor inner join persona per on per.idPersona=p.id inner join empleado e on e.idempleado=l.idempleado  inner join persona per1 on per1.idPersona=e.idempleado inner join material mat on mat.idMaterial=pro.idMateria inner join talla ta on ta.idTalla=pro.idTalla inner join marca ma on ma.idMarca=pro.idMarca  where l.fecha='" + f + "'";
            return (consultar(sql));
        }
    }
}
