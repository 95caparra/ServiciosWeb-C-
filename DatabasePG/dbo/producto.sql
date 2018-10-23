CREATE TABLE [dbo].[producto]
(
	[id_producto] INT NOT NULL PRIMARY KEY IDENTITY, 
    [nombre] VARCHAR(50) NULL, 
    [foto] VARCHAR(50) NULL, 
    [tipo] INT NULL, 
    [cantidad_minima] INT NULL, 
    [medida] INT NULL, 
    [precio_unidad] DECIMAL NULL, 
    [observaciones] VARCHAR(MAX) NULL, 
    [estado] VARCHAR(50) NULL, 
    CONSTRAINT [FK_producto_ToMedidaProducto] FOREIGN KEY (medida) REFERENCES medida_producto(id_medida), 
    CONSTRAINT [FK_producto_ToTipoProducto] FOREIGN KEY (tipo) REFERENCES tipo_producto(id_tipo_producto)
)
