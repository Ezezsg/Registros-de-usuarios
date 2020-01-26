# Registros-de-usuarios

Este es un proyecto en ASP.NET C# utilizando MVC y LINQ para obtener datos de una base de datos en SQL Server

Query para crear la base de datos

CREATE DATABASE userRecords

Query para crear la tabla

CREATE TABLE Users (<br/>
&emsp;&emsp;&emsp;&emsp;	IdUser int IDENTITY(1,1) PRIMARY KEY NOT NULL, <br/>
&emsp;&emsp;&emsp;&emsp;	Name varchar (50) NULL, <br/>
&emsp;&emsp;&emsp;&emsp;	LastName varchar (50) NULL, <br/>
&emsp;&emsp;&emsp;&emsp;	UserName varchar (50) NULL, <br/>
&emsp;&emsp;&emsp;&emsp;	Email varchar (50) NULL, <br/>
&emsp;&emsp;&emsp;&emsp;	Password varchar (50) NULL, <br/>
)
