CREATE TABLE [dbo].[detalle_producto_suministro]
(
	[id_producto] INT NOT NULL , 
    [id_suministro] INT NULL, 
    [cantidad] INT NULL, 
    [estado] INT NULL, 
    [id_producto_suministro] BIGINT NOT NULL IDENTITY, 
    CONSTRAINT [FK_detalle_producto_suministro_ToProducto] FOREIGN KEY (id_producto) REFERENCES producto(id_producto), 
    CONSTRAINT [PK_detalle_producto_suministro] PRIMARY KEY ([id_producto_suministro]), 
    CONSTRAINT [FK_detalle_producto_suministro_ToSuministro] FOREIGN KEY (id_suministro) REFERENCES suministro(id_suministro)
)
