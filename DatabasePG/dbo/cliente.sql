CREATE TABLE [dbo].[cliente]
(
	[id_cliente] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [n_identificacion] VARCHAR(50) NOT NULL, 
    [tipo_documento] INT NOT NULL, 
    [nombre] VARCHAR(50) NULL, 
    [apellido] VARCHAR(50) NULL, 
    [telefono] VARCHAR(20) NULL, 
    [celular] VARCHAR(20) NULL, 
    [direccion] VARCHAR(50) NULL, 
    [ciudad] INT NULL, 
    [correo] VARCHAR(50) NULL, 
    [estado] VARCHAR(20) NULL, 
    CONSTRAINT [FK_cliente_ToCiudad] FOREIGN KEY (ciudad) REFERENCES Ciudad(id_ciudad), 
    CONSTRAINT [FK_cliente_ToTipoDocumento] FOREIGN KEY (tipo_documento) REFERENCES tipo_documento(id_tipo_documento) 
)
