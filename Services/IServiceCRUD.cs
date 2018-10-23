using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SpartaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceCRUD" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceCRUD
    {
        [OperationContract] string CUDCiudades(int opcion, ciudad ciudad);
        [OperationContract] string CUDClasificacion(int opcion, clasificacion clasificacion);
        [OperationContract] string CUDCliente(int opcion, cliente cliente);
        [OperationContract] string CUDDetalleEmpleado(int opcion, detalle_empleado detalleEmpleado);
        [OperationContract] string CUDDetalleProducto(int opcion, detalle_producto_suministro detalleProducto);
        [OperationContract] string CUDDetalleProveedor(int opcion, detalle_proveedor detalleProveedor);
        [OperationContract] string CUDEmpleado(int opcion, empleado empleado);
        [OperationContract] string CUDEstadoEvento(int opcion, estado_evento estadoEvento);
        [OperationContract] string CUDEvento(int opcion, evento evento);
        [OperationContract] string CUDLugar(int opcion, lugar lugar);
        [OperationContract] string CUDMedidaProducto(int opcion, medida_producto tipoDocumento);
        [OperationContract] string CUDPaquete(int opcion, paquete paquete);
        [OperationContract] string CUDPedido(int opcion, pedido pedido);
        [OperationContract] string CUDProducto(int opcion, producto producto);
        [OperationContract] string CUDProveedor(int opcion, proveedor proveedor);
        [OperationContract] string CUDRoles(int opcion, rol rol);
        [OperationContract] string CUDSolicitudes(int opcion, solicitud solicitud);
        [OperationContract] string CUDSuministro(int opcion, suministro suministro);
        [OperationContract] string CUDTipoDocumento(int opcion, tipo_documento tipoDocumento);
        [OperationContract] string CUDTipoEvento(int opcion, tipo_evento tipoEvento);
        [OperationContract] string CUDTipoProducto(int opcion, tipo_producto tipoProducto);
        [OperationContract] string CUDUsuario(int opcion, usuario usuario);



        [OperationContract] List<ciudad> ObtenerCiudades(int idCiudad, string nombre);
        [OperationContract] List<clasificacion> ObtenerClasificacion(int idClasificacion, string nombreClasificacion);
        [OperationContract] List<cliente> ObtenerClientes(int idCliente, string nombreCliente, int tipoDocumento, string numeroIdentificacion, string apellido, string telefono, string celular, string direccion, int ciudad, string correo, string estado);
        [OperationContract] List<detalle_empleado> ObtenerDetalleEmpleado(long idEvento, long idEmpleado, double calificacion, string estado, long idDetalleEmpleado);
        [OperationContract] List<detalle_producto_suministro> ObtenerDetalleProducto(int idProducto, int idSuminstro, int cantidad, int estado, long idProductoSuministro);
        [OperationContract] List<detalle_proveedor> ObtenerDetalleProveedor(int idDetalleProveedor, int proveedorIdProvedor, int productoIdSuministro, string estado);
        [OperationContract] List<empleado> ObtenerEmpleados(long idEmpleado, string numeroIdentificacion, int tipoDocumento, string nombreEmpleado, string apellidoEmpleado, int idRol, string correo, string direccion, string telefono, string barrio, string estado);
        [OperationContract] List<estado_evento> ObtenerEstadosEventos(int idEstado, string nombre);
        [OperationContract] List<evento> ObtenerEventos(long idEvento, long IdSolicitud, long idCliente, int tipoEvento, int idLugar, int cantidadPersonas, int cantidadMeseros, DateTime horaInicio, DateTime horaFin, DateTime fecha, decimal precio, string observaciones, int estado);
        [OperationContract] List<lugar> ObtenerLugares(int idLugar, string nombreLugar, string descripcion, int cantMaxPersonas, string direccion, string ubicacion, string contacto, string telefonoContacto, int idCiudad);
        [OperationContract] List<medida_producto> ObtenerMedidas(int idMedidaProducto, string nombreMedidaProducto);
        [OperationContract] List<paquete> ObtenerPaquetes(int idPaquete, string nombrePaquete, int idClasificacion, string descripcion, int idLugar, int cantidadPersonas, decimal precio, string pdf, string foto, string estado);
        [OperationContract] List<pedido> ObtenerPedidos(int idPedido, int idProducto, int idProveedor, DateTime? fechaPedido, string cantidad, int idMedidaProducto, string observaciones, string fechaSugerida, string estado);
        [OperationContract] List<producto> ObtenerProductos(int idProducto, string nombre, string foto, int tipo, int cantidadMinima, int medida, decimal precioUnidad, string observaciones, string estado);
        [OperationContract] List<proveedor> ObtenerProveedores(int idProveedor, string razonSocial, string direccion, string telefono, string correo, string estado);
        [OperationContract] List<rol> ObtenerRoles(int idRol, string nombreRol);
        [OperationContract] List<solicitud> ObtenerSolicitudes(int idSolicitud, string nombreCliente, int cantidadPersonas, string telefono, string email, int TipoEvento, string hora, DateTime fecha, string observaciones, string estado, bool visto);
        [OperationContract] List<suministro> ObtenerSuministros(int idSuministro, string nombreSuministro, string foto, int cantidad, int cantidadMinima, int medida, decimal precioUnidad, string observaciones, string estado);
        [OperationContract] List<tipo_documento> ObtenerTipoDocumentos(int idTipoDocumento, string nombreTipoDocumento, string abreviatura);
        [OperationContract] List<tipo_evento> ObtenerTipoEventos(int idTipoEvento, string nombreTipoEvento);
        [OperationContract] List<tipo_producto> ObtenerTipoProductos(int idTipoProducto, string nombreTipoProducto);
        [OperationContract] List<usuario> ObtenerUsuarios(int idUsuario, long idEmpleado, string nombreUsuario, string estado);


    }
}
