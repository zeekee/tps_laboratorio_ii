------ CREACION DE TABLAS ------

--- PROVEEDORES ---
if not exists (select * from sysobjects where name='Proveedores' and xtype='U')
CREATE TABLE Proveedores (
    Id int IDENTITY(1,1) PRIMARY KEY,
    Name varchar(255),
    Address varchar(255),
    NumberOne float,
    NumberTwo float,
	Email varchar(255),
    ContactName varchar(255),
	TotalMoneyPaid float,
)
go

--- STOCK ---
if not exists (select * from sysobjects where name='Stock' and xtype='U')
CREATE TABLE Stock (
    Id int IDENTITY(1,1) PRIMARY KEY ,	
    Name varchar(255),
    Brand varchar(255),
    Price float,
    Amount float,
	IdProveedor int FOREIGN KEY REFERENCES Proveedores(Id),
	Discount float
)
go

--- EGRESOS ---
if not exists (select * from sysobjects where name='Egresos' and xtype='U')
CREATE TABLE Egresos (
    Id int IDENTITY(1,1) PRIMARY KEY,
	TotalCash float,
	IdProveedor int FOREIGN KEY REFERENCES Proveedores(Id),
	Created_at DATE DEFAULT CURRENT_TIMESTAMP
)
go

--- VENTAS ---
if not exists (select * from sysobjects where name='Ventas' and xtype='U')
CREATE TABLE Ventas (
    Id int IDENTITY(1,1) PRIMARY KEY,
	TotalSale float,
	Created_at DATE DEFAULT CURRENT_TIMESTAMP
)
go

------ CARGA DATOS DE PRUEBA ------

--- PROVEEDORES ---
INSERT INTO Proveedores (Name, Address, NumberOne, NumberTwo, Email, contactName, TotalMoneyPaid)
VALUES ('La campañola', 'Calle false 123', 0, 0, 'test@gmail.com', 'Mr Test', 0)
go

--- STOCK ---
INSERT INTO Stock (Name, Brand, Price, Amount, IdProveedor, Discount)
VALUES ('Atun', 'La campañola', 105.3, 300, 1, 0)
go

INSERT INTO Stock (Name, Brand, Price, Amount, IdProveedor, Discount)
VALUES ('Cerveza', 'Quilmes', 200, 500, 1, 15)
go


select * from stock
select * from proveedores
select * from Egresos
select * from Ventas

--drop table Egresos
--drop table Stock
--drop table Proveedores
--drop table Ventas
