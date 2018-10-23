CREATE TABLE [dbo].[solicitud]
(
	[id_solicitud] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [nombre_cliente] VARCHAR(50) NULL, 
    [cantidad_personas] INT NULL, 
    [telefono] VARCHAR(20) NULL, 
    [email] VARCHAR(50) NULL, 
    [id_tipo_evento] INT NULL, 
    [hora] VARCHAR(50) NULL, 
    [fecha] DATETIME NULL, 
    [observaciones] VARCHAR(150) NULL, 
    [estado] VARCHAR(10) NULL, 
    [visto] BIT NULL, 
    CONSTRAINT [FK_solicitud_ToTipoEvento] FOREIGN KEY (id_tipo_evento) REFERENCES tipo_evento(id_tipo_evento)
)
