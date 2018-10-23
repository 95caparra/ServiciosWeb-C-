CREATE TABLE [dbo].[evento]
(
	[id_evento] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [solicitud_id_solicitud] BIGINT NULL, 
    [cliente_id_cliente] BIGINT NULL, 
    [tipo_evento] INT NULL, 
    [id_lugar] INT NULL, 
    [cantidad_personas] INT NULL, 
    [cantidad_meseros] INT NULL, 
    [hora_inicio] DATETIME NULL, 
    [hora_fin] DATETIME NULL, 
    [fecha] DATE NULL, 
    [precio] DECIMAL(18, 4) NULL, 
    [observaciones] VARCHAR(MAX) NULL, 
    [estado_evento] INT NULL, 
    CONSTRAINT [FK_evento_ToCliente] FOREIGN KEY (cliente_id_cliente) REFERENCES cliente(id_cliente), 
    CONSTRAINT [FK_evento_ToEstadoEvento] FOREIGN KEY (estado_evento) REFERENCES estado_evento(id_estado_evento), 
    CONSTRAINT [FK_evento_ToLugar] FOREIGN KEY (id_lugar) REFERENCES lugar(id_lugar), 
    CONSTRAINT [FK_evento_ToSolicitud] FOREIGN KEY (solicitud_id_solicitud) REFERENCES Solicitud(id_solicitud), 
    CONSTRAINT [FK_evento_ToTipoEvento] FOREIGN KEY (tipo_evento) REFERENCES tipo_evento(id_tipo_evento)
)
