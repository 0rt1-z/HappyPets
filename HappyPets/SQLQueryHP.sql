CREATE DATABASE HappyPets
USE HappyPets

CREATE TABLE Usuario (Id_usuario int not null primary key identity (1,1), Nombre varchar(40) not null, Telefono varchar(10) not null,
Correo varchar(250) not null, Contraseña varchar(250) not null);

CREATE TABLE Mascota (Id_mascota int not null primary key identity (1,1), Nombre varchar(20) not null, Edad varchar(3) not null,
Raza varchar(40) not null, Tipo varchar(20) not null, Color varchar(20) not null, Altura decimal(5,2) not null, Peso decimal(5,2) not null,
Id_usuario int foreign key references Usuario);

CREATE TABLE Cuidado (Id_cuidado int not null primary key identity (1,1), Nombre varchar(20) not null, Raza varchar(40) not null, 
Edad varchar(3) not null, Genero varchar(6) not null, Servicio varchar(20) not null, Observacion varchar(100) not null,
Id_usuario int foreign key references Usuario);

CREATE TABLE Consulta (Id_consulta int not null primary key identity (1,1), Nombre varchar(20) not null, Edad varchar(3) not null,
Peso decimal(5,2) not null, Motivo_Consulta varchar(100) not null, Id_usuario int foreign key references Usuario);

CREATE TABLE Cita (Id_vacunacion int not null primary key identity (1,1), Nombre varchar(20) not null, Raza varchar(40) not null, 
Edad varchar(3) not null, Peso decimal(5,2) not null, Tipo_Vacuna varchar(40) not null, Fecha date not null,
Id_usuario int foreign key references Usuario);

CREATE TABLE Publicacion (Id_publicacion int not null primary key identity (1,1), Texto varchar(290), Foto image not null, 
Id_usuario int foreign key references Usuario);


CREATE PROCEDURE AgregarMascota
@Nombre varchar(20), 
@Edad varchar(3),
@Raza varchar(40), 
@Tipo varchar(20), 
@Color varchar(20), 
@Altura decimal(5,2), 
@Peso decimal(5,2),
@Id_usuario int
AS
INSERT INTO Mascota(Nombre,Edad,Raza,Tipo,Color,Altura,Peso,Id_usuario) 
VALUES (@Nombre,@Edad,@Raza,@Tipo,@Color,@Altura,@Peso,@Id_usuario)

CREATE PROCEDURE AgregarUsuario
@Nombre varchar(40), 
@Telefono varchar(10),
@Correo varchar(200), 
@Contraseña varchar(20) 
AS
INSERT INTO Usuario(Nombre,Telefono,Correo,Contraseña) 
VALUES (@Nombre,@Telefono,@Correo,@Contraseña)
