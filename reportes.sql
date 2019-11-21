 --REPORTES--
 go
 create procedure mostrar_Reporte_Cliente
 as
 begin
 select p.idPersona as ci,p.nom as cliente,p.apellidos,p.genero,p.telefono,p.fechaN,c.nit,r.nombre as rubro
 from persona p inner join cliente c on c.idCliente=p.idPersona inner join rubro r on r.idRubro=c.rubro
 end
 go

go
----------------------------------------------------------------------------------------------------------------------------------
create procedure mostrar_reporte_empleado
as
begin
select p.idPersona as ci,p.nom as empleado,p.apellidos,p.telefono,p.genero,p.fechaN,e.correoe 
from persona p inner join empleado e on e.idempleado=p.idPersona
end
go
 exec mostrar_reporte_empleado
 go
 ----------------------------------------------------------------------------------------------------------------------------------
create procedure mostrar_Reporte_contrato
as
begin
select c.idContrato as codigo,p.idPersona as ci,p.nom as empleado,se.nombre as sector,s.nombre as sucursal,c.sueldo,h.nombre as horario,c.fechaIngreso
from contrato c inner join horario h on h.idHorario=c.idHorario inner join sucursal s  on s.idSucursal=c.idSucursal inner join sector se on se.idSector=c.idSector
inner join empleado e on e.idempleado=c.idEmpleado  inner join persona p on p.idPersona=e.idempleado 
end
go

create procedure mostrar_reporte_empleados_filtros
as
begin
select p.idPersona as ci,(p.nom + ' ' + p.apellidos) as empleado,p.telefono,DATEDIFF(YEAR,p.fechaN,GETDATE()) as edad,sucu.nombre as sucursal,sec.nombre as sector,ho.nombre as horario,c.fechaIngreso as fechaI,DATEDIFF(YEAR,c.fechaIngreso,GETDATE()) as antiguedad,c.sueldo 
from contrato c inner join persona p on p.idPersona=c.idEmpleado inner join sucursal sucu on sucu.idSucursal=c.idSucursal inner join sector  sec on sec.idSector=c.idSector inner join horario ho on ho.idHorario=c.idHorario 
end
go
exec mostrar_reporte_empleados_filtros
--------------------------------------
go
create procedure busqueda_cliente_rubro
as
begin
select p.idPersona as ci,p.nom  + ' ' +p.apellidos as cliente,DATEDIFF(YEAR,p.fechaN,GETDATE()) as edad,p.genero,p.telefono,r.nombre as rubro
 from persona p inner join cliente c on c.idCliente=p.idPersona inner join rubro r on r.idRubro=c.rubro 
end
go
exec busqueda_cliente_rubro
--------------------------------------
go
create procedure mostrar_venta
as
begin
select v.idVenta as codigoV,pr.nombre as producto,pe.nom as empleado,perr.nom as cliente,v.fecha,dt.cantv as cantidad 
from venta v inner join detalle_venta dt on dt.idventa=v.idVenta inner join persona pe on pe.idPersona=v.idEmpleado 
inner join persona perr on perr.idPersona=v.idCliente inner join producto pr on pr.idProducto=dt.idProducto
 end
 go

 exec mostrar_venta
 -----------------------------------------
 create procedure mostrar_productos
as
begin
select p.idProducto as codigoP,p.nombre as producto,p.genero,ta.nombre as talla,m.nombre as marca,mat.nombre as material,per.nom as proveedor 
from producto p inner join marca m on m.idMarca=p.idMarca inner join talla ta on ta.idTalla=p.idTalla inner join material mat on mat.idMaterial=p.idMateria  
inner join proveedor pr on pr.id=p.idProveedor inner join persona per on per.idPersona=pr.id 
end
go
--------------------------------------------
create procedure mostrar_lotes
as
begin
select l.identrega as codigo,l.fecha,pro.nombre as producto,pro.genero,mat.nombre as materialta,ta.nombre as talla,ma.nombre as marca,per.nom as proveedor,per1.nom as empleado,dt.cante as cantidad,dt.pc,dt.pg  from lote_entrega l inner join detalle_lote_entrega dt on dt.identrega=l.identrega  inner join producto pro on pro.idProducto=dt.idproducto inner join proveedor p on p.id=l.idproveedor inner join persona per on per.idPersona=p.id inner join empleado e on e.idempleado=l.idempleado  inner join persona per1 on per1.idPersona=e.idempleado inner join material mat on mat.idMaterial=pro.idMateria inner join talla ta on ta.idTalla=pro.idTalla inner join marca ma on ma.idMarca=pro.idMarca 

end
go
 ------------------------------------------
go
create procedure consultas_pivot_venta_realizadas
as
begin
select 
CI,CLIENTE,
Case when ENERO is not null then ENERO else 0 end as ENERO,
Case when FEBRERO is not null then FEBRERO else 0 end as FEBRERO,
Case when MARZO is not null then MARZO else 0 end as MARZO,
Case when ABRIL is not null then ABRIL else 0 end as ABRIL,
Case when MAYO is not null then MAYO else 0 end as MAYO,
Case when JUNIO is not null then JUNIO else 0 end as JUNIO,
Case when JULIO is not null then JULIO else 0 end as JULIO,
Case when AGOSTO is not null then AGOSTO else 0 end as AGOSTO,
Case when SEPTIEMBRE is not null then SEPTIEMBRE else 0 end as SEPTIEMBRE,
Case when OCTUBRE is not null then OCTUBRE else 0 end as OCTUBRE,
Case when NOVIEMBRE is not null then NOVIEMBRE else 0 end as NOVIEMBRE,
Case when DICIEMBRE is not null then DICIEMBRE else 0 end as DICIEMBRE

from

(
select p.idPersona as CI,p.nom as cliente,DATENAME(MONTH,v.fecha) as MES,v.idVenta TOTAL
 from persona p inner join cliente c on c.idCliente=p.idPersona inner join venta v on v.idCliente=c.idCliente
 inner join detalle_venta dt on dt.idventa=v.idVenta 
 group by p.idPersona,p.nom,v.fecha,v.idVenta
 )T
 PIVOT (count(T.TOTAL) FOR T.MES IN
 ([ENERO],[FEBRERO],[MARZO],[ABRIL],[MAYO],[JUNIO],
 [JULIO],[AGOSTO],[SEPTIEMBRE],[OCTUBRE],[NOVIEMBRE],[DICIEMBRE]))PVT
 end
 GO
 exec consultas_pivot_venta_realizadas
 ---///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////------
go
create procedure consultas_venta_realizadas
@año int,
@cliente int
as
begin
select 
CI,CLIENTE,
Case when ENERO is not null then ENERO else 0 end as ENERO,
Case when FEBRERO is not null then FEBRERO else 0 end as FEBRERO,
Case when MARZO is not null then MARZO else 0 end as MARZO,
Case when ABRIL is not null then ABRIL else 0 end as ABRIL,
Case when MAYO is not null then MAYO else 0 end as MAYO,
Case when JUNIO is not null then JUNIO else 0 end as JUNIO,
Case when JULIO is not null then JULIO else 0 end as JULIO,
Case when AGOSTO is not null then AGOSTO else 0 end as AGOSTO,
Case when SEPTIEMBRE is not null then SEPTIEMBRE else 0 end as SEPTIEMBRE,
Case when OCTUBRE is not null then OCTUBRE else 0 end as OCTUBRE,
Case when NOVIEMBRE is not null then NOVIEMBRE else 0 end as NOVIEMBRE,
Case when DICIEMBRE is not null then DICIEMBRE else 0 end as DICIEMBRE

from

(
select p.idPersona as CI,p.nom as cliente,DATENAME(MONTH,v.fecha) as MES,v.idVenta TOTAL
 from persona p inner join cliente c on c.idCliente=p.idPersona inner join venta v on v.idCliente=c.idCliente
 inner join detalle_venta dt on dt.idventa=v.idVenta 
 where YEAR(v.fecha)=@año and c.idCliente=@cliente
 group by p.idPersona,p.nom,v.fecha,v.idVenta
 )T
 PIVOT (count(T.TOTAL) FOR T.MES IN
 ([ENERO],[FEBRERO],[MARZO],[ABRIL],[MAYO],[JUNIO],
 [JULIO],[AGOSTO],[SEPTIEMBRE],[OCTUBRE],[NOVIEMBRE],[DICIEMBRE]))PVT
 end
 GO
  exec consultas_venta_realizadas '2016','133'
  --------------------------------------------------------------------------
create table bitacoraVenta(
idBitacora int primary key identity,
operacion varchar(50) default null,
usuario varchar(50) default null,
host varchar(50) default null,
fecha datetime default null,
tabla varchar(20) default null
 )
go
--trigger de insercion de venta
create trigger tr_InsercionVenta
on venta 
after insert
as
begin
insert into bitacoraVenta  (host, usuario, operacion, fecha, tabla)
		values (@@SERVERNAME,SUSER_NAME(),'Registro',GETDATE(),'venta')
end
go
--trigger de eliminacion de venta
create trigger tr_EliminarVenta
on venta 
after delete
as
begin
insert into bitacoraVenta  (host, usuario, operacion, fecha, tabla)
		values (@@SERVERNAME,SUSER_NAME(),'Eliminado',GETDATE(),'venta')
end


