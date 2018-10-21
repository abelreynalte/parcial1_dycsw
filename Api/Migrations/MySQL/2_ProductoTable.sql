CREATE TABLE Producto(
  id bigint identity(1,1) primary key,
  descripcion varchar(50) NOT NULL,
  precio decimal(18,2) NOT NULL,
  currency varchar(3) NOT NULL,
  tipoenvaseid int foreign key references Tipoenvase(id),
  activo bit default(1)
)

INSERT INTO Producto(descripcion, precio, currency, tipoenvaseid) VALUES('Leche Gloria Deslactosada 400gm', 3.20, 'PEN', 1);
INSERT INTO Producto(descripcion, precio, currency, tipoenvaseid) VALUES('Arroz Costeño x 1kg', 2.70, 'PEN', 3);
INSERT INTO Producto(descripcion, precio, currency, tipoenvaseid) VALUES('Aceite Primor Premium x 1L', 7.00, 'PEN', 2);