# Registros-de-usuarios

Este es un proyecto en ASP.NET C# utilizando MVC y LINQ para obtener datos de una base de datos en SQL Server

Query para crear la base de datos

CREATE DATABASE userRecords

Query para crear la tabla

CREATE TABLE Users (<br/>
	IdUser int IDENTITY(1,1) PRIMARY KEY NOT NULL, <br/>
	Name varchar (50) NULL, <br/>
	LastName varchar (50) NULL, <br/>
	UserName varchar (50) NULL, <br/>
	Email varchar (50) NULL, <br/>
	Password varchar (50) NULL <br/>
)
