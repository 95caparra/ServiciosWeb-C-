CREATE TABLE [dbo].[pedido]
(
	[id_pedido] INT NOT NULL PRIMARY KEY IDENTITY, 
    [producto_id_producto] INT NULL, 
    [proveedor_id_proveedor] INT NULL, 
    [fecha_pedido] DATETIME NULL, 
    [cantidad] INT NULL, 
    [id_medida_producto] INT NULL, 
    [observaciones] VARCHAR(150) NULL, 
    [fecha_sugerida] VARCHAR(150) NULL, 
    [estado] VARCHAR(10) NULL, 
    CONSTRAINT [FK_pedido_ToMedidaProducto] FOREIGN KEY (id_medida_producto) REFERENCES medida_producto(id_medida), 
    CONSTRAINT [FK_pedido_ToProducto] FOREIGN KEY (producto_id_producto) REFERENCES producto(id_producto), 
    CONSTRAINT [FK_pedido_ToProveedor] FOREIGN KEY (proveedor_id_proveedor) REFERENCES proveedor(id_proveedor)
)
