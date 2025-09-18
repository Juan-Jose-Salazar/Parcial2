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
	[Nombre] NVARCHAR(50)NOT NULL);

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
	[Estado] NVARCHAR(20) NOT NULL CHECK ([Estado] IN ('Vendido', 'Devuelto', 'Garant�a')),
	FOREIGN KEY ([Instrumento]) REFERENCES [Instrumentos] ([Id]),
	FOREIGN KEY ([Cliente]) REFERENCES [Clientes] ([Id])
	);





INSERT INTO Clientes (Documento, Nombre) VALUES
(1001, 'Juan P�rez'),
(1002, 'Mar�a L�pez'),
(1003, 'Carlos G�mez'),
(1004, 'Ana Mart�nez'),
(1005, 'Luis Fern�ndez');


INSERT INTO Admin (Documento, Nombre) VALUES
(2001, 'Admin1'),
(2002, 'Admin2'),
(2003, 'Admin3'),
(2004, 'Admin4'),
(2005, 'Admin5');




INSERT INTO Lutiers (Documento, Nombre, Especialidad) VALUES
(3001, 'Pedro Luthier', 'Guitarras'),
(3002, 'Marta Luthier', 'Pianos'),
(3003, 'Jos� Luthier', 'Bater�as'),
(3004, 'Luc�a Luthier', 'Violines'),
(3005, 'Andr�s Luthier', 'Metales');


INSERT INTO Ciudades (Nombre, Departamento, Pais) VALUES
('Bogot�', 'Cundinamarca', 'Colombia'),
('Medell�n', 'Antioquia', 'Colombia'),
('Cali', 'Valle del Cauca', 'Colombia'),
('Barranquilla', 'Atl�ntico', 'Colombia'),
('Cartagena', 'Bol�var', 'Colombia');


INSERT INTO Sucursales (Nombre, Ciudad) VALUES
('Sucursal Centro', 1),
('Sucursal Norte', 2),
('Sucursal Sur', 3),
('Sucursal Costa', 4),
('Sucursal Caribe', 5);


INSERT INTO Asesores (Nombre, Sucursal) VALUES
('Andrea Torres', 1),
('Felipe Castro', 2),
('Sof�a Ruiz', 3),
('Daniel G�mez', 4),
('Laura M�ndez', 5);


INSERT INTO Facturas (Fecha, Cliente, Asesor) VALUES
('2025-01-10', 1, 1),
('2025-01-15', 2, 2),
('2025-02-01', 3, 3),
('2025-02-05', 4, 4),
('2025-02-10', 5, 5);



INSERT INTO Empleado (Nombre, Cargo, Sucursal) VALUES
('Mario Su�rez', 'Vendedor', 1),
('Luc�a Moreno', 'Cajera', 2),
('Camilo D�az', 'Gerente', 3),
('Paula Vargas', 'Vendedor', 4),
('Andr�s Torres', 'Auxiliar', 5);




INSERT INTO Categorias (Nombre, Descripcion) VALUES
('Cuerdas', 'Instrumentos de cuerdas como guitarras y bajos'),
('Percusi�n', 'Instrumentos de percusi�n como tambores y bater�as'),
('Viento', 'Instrumentos de viento como saxofones y flautas'),
('Teclados', 'Instrumentos de teclado como pianos y sintetizadores'),
('Accesorios', 'Accesorios para instrumentos');




INSERT INTO Instrumentos (Nombre, Marca, Modelo, Precio, Categoria) VALUES
('Guitarra Ac�stica', 'Yamaha', 'F310', 550000, 1),
('Bater�a', 'Pearl', 'Roadshow', 2500000, 2),
('Saxof�n Alto', 'Selmer', 'AS400', 3500000, 3),
('Piano Digital', 'Casio', 'PX-160', 2200000, 4),
('Bajo El�ctrico', 'Fender', 'Jazz Bass', 2800000, 1);




INSERT INTO Accesorios (Nombre, Marca, Precio, Categoria) VALUES
('Cuerda Guitarra', 'DAddario', 35000, 5),
('Baquetas', 'Vic Firth', 45000, 2),
('Boquilla Saxof�n', 'Yamaha', 120000, 3),
('Pedal Sustain', 'Casio', 95000, 4),
('Soporte Guitarra', 'Hercules', 80000, 5);





INSERT INTO Instrumentos_Accesorios (Instrumento, Accesorio) VALUES
(1, 1),
(1, 5),
(2, 2),
(3, 3),
(4, 4);


INSERT INTO Instrumentos_Facturas (Instrumento, Factura, Cantidad, Subtotal) VALUES
(1, 1, 1, 550000),
(2, 2, 1, 2500000),
(3, 3, 1, 3500000),
(4, 4, 1, 2200000),
(5, 5, 1, 2800000);



INSERT INTO Clientes_Instrumentos (Instrumento, Cliente, Fecha_Compra, Estado) VALUES
(1, 1, '2025-01-10', 'Vendido'),
(2, 2, '2025-01-15', 'Garant�a'),
(3, 3, '2025-02-01', 'Devuelto'),
(4, 4, '2025-02-05', 'Vendido'),
(5, 5, '2025-02-10', 'Vendido');

