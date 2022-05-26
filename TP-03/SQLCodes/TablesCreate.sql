--- TABLA STOCK ---

CREATE TABLE Stock (
    Code int NOT NULL PRIMARY KEY,
    Name varchar(255),
    Brand varchar(255),
    Price float,
    Stock float,
	Supplier varchar(255),
	Discount float
);


--- TABLA PROVEEDORES ---

CREATE TABLE Proveedores (
    Code int NOT NULL PRIMARY KEY,
    Name varchar(255),
    Address varchar(255),
    NumberOne float,
    NumberTwo float,
	Email varchar(255),
    ContactName varchar(255),
	TotalMoneyPaid float
);

--- TABLA EGRESOS ---

CREATE TABLE Egresos (
    Id int NOT NULL PRIMARY KEY,
    ProveedorName varchar(255),
	totalCash float,
	Code int FOREIGN KEY REFERENCES Proveedores (Code),
	created_at DATE DEFAULT CURRENT_TIMESTAMP
);


select * from stock

select * from proveedores

select * from Egresos

