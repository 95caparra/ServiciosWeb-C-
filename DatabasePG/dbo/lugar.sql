CREATE TABLE [dbo].[lugar]
(
	[id_lugar] INT NOT NULL PRIMARY KEY IDENTITY, 
    [nombre] VARCHAR(50) NULL, 
    [descripcion] VARCHAR(200) NULL, 
    [cantidad_persona_max] INT NULL, 
    [direccion] VARCHAR(200) NULL, 
    [ubicacion] VARCHAR(200) NULL, 
    [contacto] VARCHAR(100) NULL, 
    [telefono_contacto] VARCHAR(50) NULL, 
    [id_ciudad] INT NULL, 
    CONSTRAINT [FK_lugar_ToCiudad] FOREIGN KEY (id_ciudad) REFERENCES ciudad(id_ciudad)
)
