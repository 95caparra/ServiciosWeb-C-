CREATE TABLE [dbo].[detalle_proveedor]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [proveedor_id_proveedor] INT NULL, 
    [producto_id_suministro] INT NULL, 
    [estado] VARCHAR(50) NULL, 
    CONSTRAINT [FK_detalle_proveedor_ToProveedor] FOREIGN KEY (proveedor_id_proveedor) REFERENCES proveedor(id_proveedor), 
    CONSTRAINT [FK_detalle_proveedor_ToSuministro] FOREIGN KEY ([producto_id_suministro]) REFERENCES suministro(id_suministro)
)
