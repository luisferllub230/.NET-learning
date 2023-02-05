create database dbprueba
use dbprueba 
go

create table TBL_cliente
(
	CEDULA varchar(30)not null primary key,
	telefono varchar(30),
	celular varchar(30),
	edad varchar(3),
	direcciion varchar(50),
	TipoCliente varchar(20),
	NOMBRE varchar(30) not null,
	APELLIDO varchar(30)not null,
	sexo varchar(15)
)

 go
 SELECT * FROM TBL_cliente

create table TBL_USUARIO
(
	ID_USUARIO int identity(1,1) primary key,
	UNOMBRE varchar(30) not null,
	UAPELLIDO varchar(30) not null,
	UCLAVE varchar(30) not null,
	UNIVEL varchar(30) not null,
)
insert into TBL_USUARIO values
('ale', 'fernandez', 'admin', 'A')

select *
from TBL_USUARIO
go


alter table TBL_cliente
add TiempoRegistro varchar(30)
go

