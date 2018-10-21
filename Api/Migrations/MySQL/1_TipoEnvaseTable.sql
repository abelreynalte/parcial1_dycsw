CREATE TABLE Tipoenvase(
  id int identity(1,1) primary key,
  descripcion varchar(50) NOT NULL,
  activo bit default(1)
)

INSERT INTO Tipoenvase(descripcion) VALUES('Tarro');
INSERT INTO Tipoenvase(descripcion) VALUES('Botella Plastico');
INSERT INTO Tipoenvase(descripcion) VALUES('Bolsa');
INSERT INTO Tipoenvase(descripcion) VALUES('Caja');
INSERT INTO Tipoenvase(descripcion) VALUES('Galón');
