using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//adde
using System.Data;

namespace CapaNegocios
{
    public class RNDetalle_Lote_Entrega:CapaConexion.conexion
    {
        public string codigoEntrega = "";
        public string codiProducto = "";
        public string cantidad = "";
        public string precioV = "";

        public int insertar()
        {
            string sql = "insert into detalle_lote_entrega values(" + "'" + codigoEntrega + "','" + codiProducto + "','" + cantidad + "','" + precioV + "'" + ")";
            return (ejecutar(sql));
        }
        //traer productos del detalle_lote_entrega
        public DataTable traerProductosInventario()
        {
            //string sql = "select p.nombre as producto,dt.pg as 'Precio Venta',dt.identrega as 'Nro entrega',p.idproducto as 'codigo' from detalle_lote_entrega  dt inner join producto p on dt.idproducto=p.idproducto";
            string sql = "select  p.idProducto as codigo, p.nombre as producto,p.genero,t.nombre as talla,h.nombre as horma,ma.nombre as marca,mat.nombre as material,pe.nom as proveedor ,pg as 'Precio Venta',dt.identrega as 'Nro entrega',dt.cante as stock from detalle_lote_entrega  dt inner join producto p on dt.idproducto=p.idproducto inner join marca ma on ma.idMarca=p.idMarca inner join material mat on mat.idMaterial=p.idMateria inner join talla t on t.idTalla=p.idTalla inner join horma h on h.idHorma=t.idHorma  inner join proveedor pr on pr.id=p.idProveedor inner join persona pe on pe.idPersona=pr.id ";
            return (consultar(sql));
        }

    }
}
