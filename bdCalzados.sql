create database bdCalzados
use bdCalzados
go
create table sucursal(
idSucursal int identity primary key,
nombre varchar(20),
telefono varchar(20),
direccion varchar(20)
)
go
create table rubro(
idRubro int primary key identity,
nombre varchar(20)
)
create table sector(
idSector int primary key identity,
nombre varchar(20)
)
create table persona( 
idPersona int primary key ,
--ci int,
nom varchar(50),
apellidos varchar(50),
telefono varchar(20),
genero char,
fechaN date
)
create table usuario(
idusuario int references persona,
nu varchar(50) NULL,
clave varchar(50) NULL
)

create table adm(
idempleado int references persona,
correoe varchar(50),
idSector int references sector
)
create table empleado(
idempleado int references persona,
correoe varchar(50),
--idSucursal int references sucursal,
foto varchar(100)
)
create table cliente(
idCliente int references persona,
nit int,
rubro int references rubro
)
create table horario(
idHorario int primary key identity,
nombre varchar(50)
)
create table contrato(
idContrato int primary key identity,
idHorario int references horario,
fechaIngreso date,
idSector int references sector,
idSucursal int references sucursal,
idEmpleado int references persona,
sueldo float
)

--create table detalleContrato(
--idContrato int references contrato,
--idEmpleado int references persona,
--primary key(idContrato,idEmpleado),
--fechaInicio date,
--fechaFin date,
--sueldo float)

go
---PRODUCTO--------------------------------
create table pais(
idPais int primary key identity,
nombre varchar(20)
)
create table marca(
idMarca int primary key identity,
nombre varchar(20),
idPais int references pais
)
create table horma(
idHorma int primary key identity,
nombre varchar(50),
)
create table talla(
idTalla int primary key identity,
nombre varchar(50),
idHorma int references horma
)
create table material(
idMaterial int primary key identity,
nombre varchar(20)
)
create table proveedor(
id int primary key references persona,
nit int,
idPais int references pais
)
create table producto(
idProducto int primary key identity,
nombre varchar(50),
genero char,
--temporada char,
idTalla int references talla,
idMarca int references marca,
idMateria int references material,
idProveedor int references proveedor
)
-------------------------------------
--create table compra(
--idCompra int primary key identity,
--fecha date,
--idEmpleado int references persona
--)
--create table DetalleCompra(
--idCompra int references compra,
--idProducto int references producto,
--primary key(idCompra,idProducto),
--fechaCompra date,
--cantidad int,
--precioCompra float,
--precioUnitario float
--)
-----------------------------------
create table grupo_casual(
idCasual int primary key references producto,
observacion varchar(20)
)
create table grupo_sandalia(
idSandalia int primary key references producto,
cararcteristicas varchar(20)
)
create table tipoBotas(
id int primary key identity,
peso int,
circunsatncia varchar(20)
)
create table grupo_bota(
idBota int primary key references producto,
idTipoBota int references tipoBotas
)
create table grupo_deportivo(
id int primary key references producto,
tipoCampo varchar(50) 
)
create table grupo_elegancia(
id int  references producto,
ortopedico char,
observacion varchar(20)
)
create table tipo_tacon(
id int primary key identity,
tamaño float
)
create table grupo_tacon(
id int primary key references producto,
idTipo int references tipo_tacon

)

create table lote_entrega(
identrega int primary key ,
idempleado int references persona,
idproveedor int references persona,
fecha date
)
create table detalle_lote_entrega(
identrega int not null references lote_entrega(identrega),
idproducto int not null references producto(idproducto),
constraint llaveDoble primary key(identrega,idproducto),
cante numeric(18,3),
pc numeric(18,3),
pg int
)
create table venta(
idVenta int primary key identity,
fecha date,
idCliente int references persona,
idEmpleado int references persona,
)
create table detalle_venta(
idventa int not null references venta(idVenta),
identrega int not null,
idProducto int not null,
constraint llaveTriple primary key(idventa,identrega,idproducto),
constraint llevaDetalle_lote_entrega foreign key(identrega,idproducto) references detalle_lote_entrega(identrega,idproducto),
cantv numeric(18,3)
)
go
-------------------------------------------------------------------------------