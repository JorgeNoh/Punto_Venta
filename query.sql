create database ventas;
Go
use ventas;
GO
CREATE TABLE Registros (
    Id int IDENTITY(1,1) PRIMARY KEY,
    Producto varchar(255) NOT NULL,
    Cantidad int NOT NULL,
    Total int NOT NULL,
	Fecha varchar(255) NOT NULL
);
GO

CREATE TABLE RegistrosTotales (
    Id int IDENTITY(1,1) PRIMARY KEY,
    Producto varchar(255) NOT NULL,
    Cantidad int NOT NULL,
    Total int NOT NULL,
	Fecha varchar(255) NOT NULL
);
GO

SELECT * FROM RegistrosTotales;


SELECT * FROM Registros;
GO

SELECT * FROM Users;
GO

Drop table Registros
Go

CREATE TABLE Productos (
    Folio Int IDENTITY(1,1) PRIMARY KEY,
    Producto varchar(255) NOT NULL,
    Precio Int,
	Stock Int
);
GO

CREATE TABLE Users (
    Id Int IDENTITY(1,1) PRIMARY KEY,
    LoginName varchar(100) unique NOT NULL,
	Pass varchar(100) NOT NULL,
	Nombre varchar(100) NOT NULL,
	Apellido varchar(100) NOT NULL,
	Puesto varchar(100) NOT NULL
);
GO

SELECT * FROM Productos;
GO
SELECT * FROM Users;
GO

INSERT INTO Productos (Producto, Precio, Stock)
VALUES ('Coca-Cola', '10', '50');
GO

INSERT INTO Productos (Producto, Precio, Stock)
VALUES ('Sabrita', '8', '10');
GO
INSERT INTO Productos (Producto, Precio, Stock)
VALUES ('Galleta', '11', '50');
GO
/* PRUEBA*/
/*
CREATE TABLE Tabla1 (
    Id int IDENTITY(1,1) PRIMARY KEY,
    Nombre varchar(255) NOT NULL,
    Apellido varchar(255) NOT NULL
);
GO

INSERT INTO Tabla1(Nombre, Apellido) VALUES ('Miguel', 'Simón'), ('Juan', 'Lopez')
GO
SELECT * FROM Tabla1;
*/
 SELECT Producto FROM Productos;
 GO
 UPDATE Productos SET Stock = Stock - 4;
 SELECT * FROM Productos;

INSERT INTO Users (LoginName, Pass, Nombre, Apellido, Puesto)
VALUES ('admin', 'admin', 'Jorge', 'Noh', 'Dueño');
GO

INSERT INTO Users (LoginName, Pass, Nombre, Apellido, Puesto)
VALUES ('Jorge', '245678', 'Jorge', 'Noh', 'Empleado');
GO
