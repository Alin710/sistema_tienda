use bdCalzados
go
create procedure insertar_pais
@nombre varchar(20)
as
begin
insert into pais values(@nombre)
print 'se registro ' + @nombre
end
go
create procedure insertar_sucursal
@nombre varchar(20),
@telefono varchar(20),
@direccion varchar(20)
as
begin
insert into sucursal values(@nombre,@telefono,@direccion)
end
go
create procedure inserta_rubro
@nombre varchar(20)
as
begin
insert into rubro values(@nombre)
print 'se registro ' +  @nombre
end
go
create procedure insertar_sector
@nombre varchar(20)
as
begin
insert into sector values(@nombre)
print 'se registro ' + @nombre
end
go
create procedure insertar_persona
@ci int,
@nom varchar(50),
@apellidos varchar(50),
@telefono varchar(20),
@genero char,
@fechaN date
as
begin
insert into persona values(@ci,@nom,@apellidos,@telefono,@genero,@fechaN)
print 'se registro ' + @nom
end
go
---------------------------------------------------------------------------------------------------------------
exec insertar_sucursal 'santa martha','6876443','av beni'
exec insertar_sucursal 'santa maria','6876443','av brasil'
exec insertar_sucursal 'san juan','6876443','av santa cruz'
go
exec insertar_pais 'bolivia'
exec insertar_pais 'argentina'
exec insertar_pais 'peru'
exec insertar_pais 'venezuela'
exec insertar_pais 'colombia'
go
exec inserta_rubro 'comerciante'
exec inserta_rubro 'agricultor'
exec inserta_rubro 'vendedor'
go
exec insertar_sector 'caja'
exec insertar_sector 'almacen'
exec insertar_sector 'venta'
go
exec insertar_persona '120','eliana','arias','7686868','f','02/02/1995'
exec insertar_persona '121','fabiola','arias','7686868','f','02/02/1990'
exec insertar_persona '122','betania','arias','7686868','f','02/02/1995'
exec insertar_persona '123','johana','arias','7686868','f','02/02/1985'
exec insertar_persona '124','carla','arias','7686868','f','02/02/1975'
exec insertar_persona '125','maria','arias','7686868','f','02/02/1970'
exec insertar_persona '126','carlos','arias','7686868','m','02/02/1971'
exec insertar_persona '127','juan','arias','7686868','m','02/02/1978'
exec insertar_persona '128','tamara','arias','7686868','f','02/02/1983'
exec insertar_persona '129','carla','arias','7686868','f','02/02/1970'
exec insertar_persona '130','diana','arias','7686868','f','02/02/1977'
exec insertar_persona '131','jimena','arias','7686868','f','02/02/1975'
exec insertar_persona '132','yolanda','arias','7686868','f','02/02/1970'
exec insertar_persona '133','esther','arias','7686868','f','02/02/1985'
exec insertar_persona '134','camila','arias','7686868','f','02/02/1973'
exec insertar_persona '135','rebeca','arias','7686868','f','02/02/1990'
exec insertar_persona '136','sonia','arias','7686868','f','02/02/1969'
exec insertar_persona '137','estefani','arias','7686868','f','02/02/1989'
exec insertar_persona '138','juliana','arias','7686868','f','02/02/1995'
exec insertar_persona '139','lucia','arias','7686868','f','02/02/1995'
exec insertar_persona '140','monica','arias','7686868','f','02/02/1996'

exec insertar_persona '141','Hansa','','3426262','',''
exec insertar_persona '142','TecnoModa','','3222222','',''
exec insertar_persona '143','Umbro','','3445555','',''
exec insertar_persona '144','Adidas','','6554444','',''
exec insertar_persona '145','Tecnovision','','6555444','',''
go
insert into empleado values(120,'asd@gmail.com','aa.jpg')
insert into empleado values(121,'asd@gmail.com','aa.jpg')
insert into empleado values(122,'yu@gmail.com','aa.jpg')
insert into empleado values(123,'awd@gmail.com','aa.jpg')
insert into empleado values(124,'apd@gmail.com','aa.jpg')
insert into empleado values(125,'gtd@gmail.com','aa.jpg')
insert into empleado values(126,'ard@gmail.com','aa.jpg')
insert into empleado values(127,'awd@gmail.com','aa.jpg')
insert into empleado values(128,'aid@gmail.com','aa.jpg')
insert into empleado values(129,'dfd@gmail.com','aa.jpg')
insert into empleado values(130,'dfd@gmail.com','aa.jpg')
go
insert into cliente values(131,'32222',2)
insert into cliente values(132,'2111233',2)
insert into cliente values(133,'4533222',1)
insert into cliente values(134,'56677777',1)
insert into cliente values(135,'87776555',3)
insert into cliente values(136,'453533344',1)
insert into cliente values(137,'9887766',3)
insert into cliente values(138,'3234444',1)
insert into cliente values(139,'3433445',3)
insert into cliente values(140,'3433445',1)
go
insert into horario values('08:00 12:00')
insert into horario values('12:00 18:00')
insert into horario values('14:00 23:00')
go
insert into contrato values(1,'02/09/2011',1,1,120,2000)
insert into contrato values(2,'09/09/2011',2,1,121,1500)
insert into contrato values(3,'10/09/2011',3,1,122,3000)
insert into contrato values(1,'10/09/2012',1,1,123,3500)
insert into contrato values(2,'11/09/2011',2,1,124,5000)
insert into contrato values(3,'12/09/2011',3,1,125,2050)
insert into contrato values(1,'12/09/2011',1,1,126,2500)
insert into contrato values(2,'14/09/2011',2,1,127,1500)
insert into contrato values(3,'15/09/2011',3,2,128,1800)
insert into contrato values(1,'16/09/2011',1,2,129,1900)
insert into contrato values(2,'17/09/2011',2,2,130,1600)
go 
insert into proveedor values(141,'545554',2)
insert into proveedor values(142,'4655533',3)
insert into proveedor values(143,'4535352',3)
insert into proveedor values(144,'2636344',1)
insert into proveedor values(145,'12344433',1)
go
insert into horma values('grande')
insert into horma values('mediana')
insert into horma values('pequeña')
go
insert into talla values('talla1',1)
insert into talla values('talla2',2)
insert into talla values('talla3',3)
go
insert into marca values('marca1',1)
insert into marca values('marca2',2)
insert into marca values('marca3',1)
insert into marca values('marca4',1)
go
insert into  material values('cuero')
insert into  material values('cuerina')
insert into  material values('tela')
go
insert into producto values('bocacin','m',1,1,1,141)
insert into producto values('tenis','f',2,2,1,142)
insert into producto values('sandalia','f',3,2,1,143)
insert into producto values('botas','f',1,4,1,144)
insert into producto values('tacon','m',2,2,2,145)
insert into producto values('cross','m',3,1,1,141)
insert into producto values('chutera','f',1,2,1,142)
insert into producto values('chinela','m',2,3,1,143)
insert into producto values('aspargata','f',3,1,2,145)
insert into producto values('botin','m',1,1,1,145)
insert into producto values('zapatillas','f',2,1,2,141)
insert into producto values('quichutes','m',2,2,1,142)
insert into producto values('tenis','f',2,3,1,143)
insert into producto values('chinela p/ playa','m',3,4,2,144)
insert into producto values('cross','f',1,3,1,145)
go
INSERT [dbo].[usuario] ([idusuario], [nu], [clave]) VALUES (120, N'eliana', N'123')
go
insert into adm values(127,'juan21','1')
INSERT [dbo].[usuario] ([idusuario], [nu], [clave]) VALUES (127, N'juan', N'jj')
go
insert into lote_entrega values(1,120,141,'01/01/2016')
insert into lote_entrega values(2,121,142,'01/01/2016')
go
insert into detalle_lote_entrega values(1,1,40.000,10,4)
insert into detalle_lote_entrega values(1,2,40.000,20,5)
insert into detalle_lote_entrega values(1,3,40.000,15,3)
insert into detalle_lote_entrega values(1,8,30.000,20,4)
insert into detalle_lote_entrega values(1,4,40.000,20,3)

insert into detalle_lote_entrega values(2,5,44,20,3)
insert into detalle_lote_entrega values(2,6,20,20,3)
insert into detalle_lote_entrega values(2,7,4,20,3)
insert into detalle_lote_entrega values(2,8,10,20,3)
insert into detalle_lote_entrega values(2,9,40.000,20,3)
go
insert into venta values('01-01-2016',133,121)
insert into detalle_venta values(1,1,1,2)
--
insert into venta values('01-02-2016',133,120)
insert into detalle_venta values(2,1,2,3)
--
insert into venta values('21-02-2016',133,122)
insert into detalle_venta values(3,1,2,3)
insert into venta values('21-02-2016',133,120)
insert into detalle_venta values(4,1,2,3)
--
insert into venta values('20-03-2016',133,121)
insert into detalle_venta values(5,1,2,3)
insert into venta values('21-03-2016',133,120)
insert into detalle_venta values(6,1,2,3)
insert into venta values('22-03-2016',133,120)
insert into detalle_venta values(7,1,2,3)
insert into venta values('27-03-2016',133,120)
insert into detalle_venta values(8,1,2,3)
insert into venta values('27-03-2016',133,120)
insert into detalle_venta values(9,1,2,3)
insert into venta values('28-03-2016',133,120)
insert into detalle_venta values(10,1,2,3)
insert into venta values('29-03-2016',133,120)
insert into detalle_venta values(11,1,2,3)
insert into venta values('30-03-2016',133,120)
insert into detalle_venta values(12,1,2,3)
insert into venta values('31-03-2016',133,120)
insert into detalle_venta values(13,1,2,3)
insert into venta values('31-03-2016',133,120)
insert into detalle_venta values(14,1,2,3)
--
insert into venta values('21-06-2016',133,120)
insert into detalle_venta values(15,1,2,3)
insert into venta values('22-06-2016',133,122)
insert into detalle_venta values(16,1,2,3)
--
insert into venta values('23-07-2016',133,122)
insert into detalle_venta values(17,1,2,3)
insert into venta values('24-07-2016',133,122)
insert into detalle_venta values(18,1,2,3)
insert into venta values('25-07-2016',135,121)
insert into detalle_venta values(19,1,2,3)
insert into venta values('26-07-2016',135,121)
insert into detalle_venta values(20,1,2,3)
insert into venta values('27-07-2016',135,121)
insert into detalle_venta values(21,1,2,3)
insert into venta values('27-07-2016',133,120)
insert into detalle_venta values(22,1,2,3)
insert into venta values('27-07-2016',133,121)
insert into detalle_venta values(23,1,2,3)
insert into venta values('27-07-2016',133,120)
insert into detalle_venta values(24,1,2,3)
insert into venta values('27-07-2016',133,121)
insert into detalle_venta values(25,1,2,3)
insert into venta values('27-07-2016',135,120)
insert into detalle_venta values(26,1,2,3)
insert into venta values('27-07-2016',135,120)
insert into detalle_venta values(27,1,2,3)
insert into venta values('27-07-2016',135,122)
insert into detalle_venta values(28,1,2,3)
insert into venta values('27-07-2016',133,121)
insert into detalle_venta values(29,1,2,3)
go

--select p.idProducto as codigo,p.nombre as producto,p.genero,t.nombre as talla,m.nombre as marca,mat.nombre as material,pers.nom as proveedor
-- from producto p inner join talla t on t.idTalla=p.idTalla inner join marca m on m.idMarca=p.idMarca inner join material mat
-- on mat.idMaterial=p.idMateria inner join proveedor pro on pro.id=p.idProveedor inner join persona pers on pro.id=pers.idPersona 
-- where pro.id=141 

--insert into grupo_elegancia values(1,'s','aaaa')
---------------------------------------
create view mostrar_clientes
as
select p.idPersona as ci,p.nom,p.apellidos,DATEDIFF(YEAR,p.fechaN,GETDATE()) as edad,p.telefono,c.nit,r.nombre as rubro
 from cliente c inner join persona p on p.idPersona=c.idCliente inner join rubro r on r.idRubro=c.rubro
 go

 create view mostrar_cliente_etapasVida
 as
 select c.*, 'NIÑO' as etapa from mostrar_clientes c where c.edad between '1' and '12'
 UNION
 select c.*, 'ADOLESCENTE' as etapa from mostrar_clientes c where c.edad between '13' and '17'
 UNION
 select c.*, 'JOVEN' as etapa from mostrar_clientes c where c.edad between '19' and '29'
 UNION
 select c.*, 'ADULTO' as etapa from mostrar_clientes c where c.edad between '30' and '40'
 UNION
 select c.*, 'ADULTO MAYOR' as etapa from mostrar_clientes c where c.edad between '41' and '200'

 select * from mostrar_cliente_etapasVida

 --create view clientes_etapas_vida
 --as
 --select c.*,Edad=
 --case 
 --when Edad<=13 then 'NIÑO'
 --when Edad>=14 and Edad<=20 then 'ADOLESCENTE'
 --when Edad>=21 and Edad<=29 then 'JOVEN' 
 --when Edad>=30 and Edad<=40 then 'ADULTO' 
 --when Edad>=41 and Edad<=200 then 'ADULTO MAYOR' 
 --end
 -- from mostrar_clientes c