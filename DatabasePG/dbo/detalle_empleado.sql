CREATE TABLE [dbo].[detalle_empleado]
(
	[evento_id_evento] BIGINT NOT NULL , 
    [empleado_id_empleado] BIGINT NULL, 
    [calificacion] FLOAT NULL, 
    [estado] VARCHAR(50) NULL, 
    [id_detalle_empleado] BIGINT NOT NULL IDENTITY, 
    CONSTRAINT [FK_detalle_empleado_ToEmpleado] FOREIGN KEY (empleado_id_empleado) REFERENCES empleado(id_empleado), 
    CONSTRAINT [PK_detalle_empleado] PRIMARY KEY ([id_detalle_empleado]), 
    CONSTRAINT [FK_detalle_empleado_ToEvento] FOREIGN KEY (evento_id_evento) REFERENCES Evento(id_evento)
)
