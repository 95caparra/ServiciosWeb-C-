CREATE TABLE [dbo].[empleado]
(
	[Id_empleado] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [n_identificacion] VARCHAR(50) NULL, 
    [id_tipo_documento] INT NULL, 
    [nombre] VARCHAR(50) NULL, 
    [apellido] VARCHAR(50) NULL, 
    [empleado_id_rol] INT NULL, 
    [correo] VARCHAR(50) NULL, 
    [direccion] VARCHAR(50) NULL, 
    [telefono] VARCHAR(50) NULL, 
    [barrio] VARCHAR(50) NULL, 
    [estado] VARCHAR(20) NULL, 
    CONSTRAINT [FK_empleado_ToRol] FOREIGN KEY (empleado_id_rol) REFERENCES Rol(id_rol), 
    CONSTRAINT [FK_empleado_ToTipoDocumento] FOREIGN KEY (id_tipo_documento) REFERENCES tipo_documento(id_tipo_documento)
)
