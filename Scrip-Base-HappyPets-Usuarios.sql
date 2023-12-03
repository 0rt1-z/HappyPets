create database HappyPets
go
use HappyPets
go
create table Usuarios(
IDUsuarios int identity(1,1) primary key,
NombreLogin nvarchar (100) unique not null,
Contraseña nvarchar (100) not null,
PrimerNombre nvarchar(100) not null,
UltimoNombre nvarchar(100) not null,
Cargo nvarchar (100) not null,
Correo nvarchar(150)not null
) 
insert into Usuarios values ('admin','admin','Ernesto','Ortiz','Administrador','soporte@happypets.com')
insert into Usuarios values ('Saul','abc123456','Saul','Oporto','Soporte','saul@happypets.com')                                                         
insert into Usuarios values ('Lei','abc123456','Leida','Alas','Gerente','KathySmith@happypets.com')

select * from Usuarios

declare @usuario nvarchar(100)='admin'
declare @contraseña nvarchar(100)='admmin'
select *From Usuarios where NombreLogin=@usuario and Contraseña=@contraseña