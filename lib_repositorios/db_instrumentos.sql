CREATE DATABASE db_instrumentos;
GO
USE db_instrumentos;
GO

CREATE TABLE [Clientes] (
	[Id] BIGINT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Documento] INT NOT NULL ,
	[Nombre] NVARCHAR(50) NOT NULL);

CREATE TABLE [Admin] (
	[Id] BIGINT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Documento] INT NOT NULL ,
	[Nombre] NVARCHAR(50) NOT NULL);

CREATE TABLE [Lutiers] (
	[Id] BIGINT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Documento] INT NOT NULL ,
	[Nombre] NVARCHAR(50) NOT NULL,
	[Especialidad] NVARCHAR(50) NOT NULL);

CREATE TABLE [Ciudades] (
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Nombre] NVARCHAR(50) NOT NULL,
	[Departamento] NVARCHAR(50) NOT NULL,
	[Pais] NVARCHAR(50) NOT NULL
	);

CREATE TABLE [Sucursales] (
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Nombre] NVARCHAR(50) NOT NULL,
	[Ciudad] INT NOT NULL,
	FOREIGN KEY ([Ciudad]) REFERENCES [Ciudades]([Id]));

CREATE TABLE [Asesores] (
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Nombre] NVARCHAR(50) NOT NULL,
	[Sucursal] INT NOT NULL,
	FOREIGN KEY ([Sucursal]) REFERENCES [Sucursales] ([Id]));

CREATE TABLE [Facturas](
	[Id] INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
	[Fecha] SMALLDATETIME NOT NULL,
	[Cliente] BIGINT NOT NULL,
	[Asesor] INT NOT NULL,
	FOREIGN KEY ([Cliente]) REFERENCES [Clientes] ([Id]),
	FOREIGN KEY ([Asesor]) REFERENCES [Asesores] ([Id])
	);

CREATE TABLE [Empleado] (
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Nombre] NVARCHAR(50) NOT NULL,
	[Cargo] NVARCHAR(50) NOT NULL,
	[Sucursal] INT NOT NULL,
	FOREIGN KEY ([Sucursal]) REFERENCES [Sucursales] ([Id]));



CREATE TABLE [Categorias] (
	[Id] INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
	[Nombre] NVARCHAR (50) NOT NULL,
	[Descripcion] NVARCHAR (200) NOT NULL,
	);

CREATE TABLE [Instrumentos] (
	[Id] INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
	[Nombre] NVARCHAR (50) NOT NULL,
	[Marca] NVARCHAR (100) NOT NULL,
	[Modelo] NVARCHAR (100) NOT NULL,
	[Precio]  DECIMAL (10,2) NOT NULL,
	[Categoria] INT NOT NULL,
	FOREIGN KEY ([Categoria]) REFERENCES [Categorias] ([Id])
	);

CREATE TABLE [Accesorios] (
	[Id] INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
	[Nombre] NVARCHAR (50)  NOT NULL,
	[Marca] NVARCHAR (100),
	[Precio] DECIMAL(10,2) NOT NULL,
	[Categoria] INT NOT NULL,
	FOREIGN KEY ([Categoria]) REFERENCES [Categorias]([Id]));

CREATE TABLE [Instrumentos_Accesorios] (
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Instrumento] INT NOT NULL,
	[Accesorio] INT NOT NULL,
	FOREIGN KEY ([Instrumento]) REFERENCES [Instrumentos] ([Id]),
	FOREIGN KEY ([Accesorio]) REFERENCES [Accesorios] ([Id])
	);

CREATE TABLE [Instrumentos_Facturas] (
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Instrumento] INT NOT NULL,
	[Factura] INT NOT NULL,
	[Cantidad] INT NOT NULL,
	[Subtotal] DECIMAL (10,2) NOT NULL,
	FOREIGN KEY ([Instrumento]) REFERENCES [Instrumentos] ([Id]),
	FOREIGN KEY ([Factura]) REFERENCES [Facturas] ([Id])
	);


CREATE TABLE [Clientes_Instrumentos] (
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Instrumento] INT NOT NULL,
	[Cliente] BIGINT NOT NULL,
	[Fecha_Compra] DATETIME NOT NULL,
	[Estado] NVARCHAR(20) NOT NULL CHECK ([Estado] IN ('Vendido', 'Devuelto', 'Garantía')),
	FOREIGN KEY ([Instrumento]) REFERENCES [Instrumentos] ([Id]),
	FOREIGN KEY ([Cliente]) REFERENCES [Clientes] ([Id])
	);

