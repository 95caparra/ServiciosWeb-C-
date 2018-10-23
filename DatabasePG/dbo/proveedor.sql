CREATE TABLE [dbo].[proveedor]
(
	[id_proveedor] INT NOT NULL PRIMARY KEY IDENTITY, 
    [razon_social] VARCHAR(50) NULL, 
    [direccion] VARCHAR(50) NULL, 
    [telefono] VARCHAR(50) NULL, 
    [correo] VARCHAR(50) NULL, 
    [estado] VARCHAR(50) NULL
)
