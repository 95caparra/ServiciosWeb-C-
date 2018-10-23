CREATE TABLE [dbo].[paquete]
(
	[id_paquete] INT NOT NULL PRIMARY KEY IDENTITY, 
    [nombre] VARCHAR(50) NULL, 
    [clasificacion_id_clasificacion] INT NULL, 
    [descripcion] VARCHAR(200) NULL, 
    [id_lugar] INT NULL, 
    [cantidad_personas] INT NULL, 
    [precio] DECIMAL(18, 4) NULL, 
    [pdf] VARCHAR(50) NULL, 
    [foto] VARCHAR(50) NULL, 
    [estado] VARCHAR(50) NULL, 
    CONSTRAINT [FK_paquete_ToClasificacion] FOREIGN KEY ([clasificacion_id_clasificacion]) REFERENCES clasificacion(id_clasificacion), 
    CONSTRAINT [FK_paquete_ToLugar] FOREIGN KEY ([id_lugar]) REFERENCES Lugar(id_lugar)
)
