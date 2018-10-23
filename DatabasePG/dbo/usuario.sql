CREATE TABLE [dbo].[usuario]
(
	[id_usuario] INT NOT NULL PRIMARY KEY IDENTITY, 
    [empleado_id_empleado] BIGINT NULL, 
    [usuario] VARCHAR(200) NULL, 
    [contrasenia] VARCHAR(200) NULL, 
    [estado] VARCHAR(20) NULL, 
    CONSTRAINT [FK_usuario_ToEmpleado] FOREIGN KEY (empleado_id_empleado) REFERENCES empleado(id_empleado)
)
