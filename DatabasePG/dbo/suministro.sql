CREATE TABLE [dbo].[suministro]
(
	[id_suministro] INT NOT NULL PRIMARY KEY  IDENTITY, 
    [nombre] VARCHAR(50) NULL, 
    [foto] NCHAR(10) NULL, 
    [cantidad] INT NULL, 
    [cantidad_minima] INT NULL, 
    [medida] INT NULL, 
    [precio_unidad] DECIMAL NULL, 
    [observaciones] VARCHAR(200) NULL, 
    [estado] VARCHAR(50) NULL, 
    CONSTRAINT [FK_suministro_ToMedidaProducto] FOREIGN KEY (medida) REFERENCES medida_producto(id_medida)
)
