# API-REST_NET_CORE
API Rest en .NET CORE
Esta esa una API Rest basica realizada en asp.NET Core 

La base de dato es sql server
CREATE DATABASE Noticias
GO
USE Noticias
GO

Create Table Noticia(
	NoticiaID int primary key identity(1,1),
	Titulo varchar(120),
	Descripcion varchar(200),
	Contenido varchar(max),
	Fecha Datetime,
	AutorID int
)
GO
Create Table Autor(
	AutorID int primary key identity(1,1),
	Nombre Varchar(100),
	Apellido Varchar(100)
)


