# Registros-de-usuarios

Este es un proyecto en ASP.NET C# utilizando MVC y LINQ para obtener datos de una base de datos en SQL Server

Query para crear la base de datos

CREATE DATABASE userRecords

Query para crear la tabla

CREATE TABLE Users (
	IdUser int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Name varchar (50) NULL,	
	LastName varchar (50) NULL,
	UserName varchar (50) NULL,
	Email varchar (50) NULL,
	Password varchar (50) NULL,	
)
