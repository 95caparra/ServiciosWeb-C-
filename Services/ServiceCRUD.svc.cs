using System;
using System.Collections.Generic;
using Dominio;
using LogicaNegocio;
using Repositorio;

namespace SpartaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceCRUD" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceCRUD.svc o ServiceCRUD.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceCRUD : IServiceCRUD
    {
        private CiudadRepositorio ciudadRepositorio = new CiudadRepositorio();
        private RolRepositorio rolRepositorio = new RolRepositorio();
        private EstadoEventoRepositorio estadoEventoRepositorio = new EstadoEventoRepositorio();
        private ClasificacionRepositorio clasificacionRepositorio = new ClasificacionRepositorio();
        private ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        private DetalleEmpleadoRepositorio detalleEmpleadoRepositorio = new DetalleEmpleadoRepositorio();
        private DetalleProductoRepositorio detalleProductoRepositorio = new DetalleProductoRepositorio();
        private DetalleProveedorRepositorio detalleProveedorRepositorio = new DetalleProveedorRepositorio();
        private EmpleadoRepositorio empleadoRepositorio = new EmpleadoRepositorio();
        private EventoRepositorio eventoRepositorio = new EventoRepositorio();
        private LugarRepositorio lugarRepositorio = new LugarRepositorio();
        private MedidaProductoRepositorio medidaProductoRepositorio = new MedidaProductoRepositorio();
        private PaqueteRepositorio paqueteRepositorio = new PaqueteRepositorio();
        private PedidoRepositorio pedidoRepositorio = new PedidoRepositorio();
        private ProductoRepositorio productoRepositorio = new ProductoRepositorio();
        private ProveedorRepositorio proveedorRepositorio = new ProveedorRepositorio();
        private SolicitudRepositorio solicitudRepositorio = new SolicitudRepositorio();
        private SuministroRepositorio suministroRepositorio = new SuministroRepositorio();
        private TipoDocumentoRepositorio tipoDocumentoRepositorio = new TipoDocumentoRepositorio();
        private TipoEventoRepositorio tipoEventoRepositorio = new TipoEventoRepositorio();
        private TipoProductoRepositorio tipoProductoRepositorio = new TipoProductoRepositorio();
        private UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();


        public string CUDCiudades(int opcion, ciudad ciudad)
        {
            string mensaje = "Ciudad " + ciudad.Nombre + " {0} exitosamente";
            try
            {
                switch (opcion)
                {
                    case 1: //insert
                        ciudadRepositorio.InsertarCiudad(ciudad);
                        mensaje = string.Format(mensaje, "Insertada");
                        break;
                    case 2: //update
                        ciudadRepositorio.ActualizarCiudad(ciudad);
                        mensaje = string.Format(mensaje, "Actualizada");
                        break;
                    case 3: //delete
                        ciudadRepositorio.EliminarCiudad(ciudad);
                        mensaje = string.Format(mensaje, "Eliminada");
                        break;
                    default:
                        mensaje = "Opcion no implementada 1= Insert, 2=Update, 3=Delete";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = "se presento un inconveniente en el proceso de manejo de informacion";
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }

            return mensaje;
        }

        public string CUDClasificacion(int opcion, clasificacion clasificacion)
        {
            string mensaje = "Rol " + clasificacion.nombre + " {0} exitosamente";
            try
            {
                switch (opcion)
                {
                    case 1: //insert
                        clasificacionRepositorio.InsertarClasificacion(clasificacion);
                        mensaje = string.Format(mensaje, "Insertado");
                        break;

                    case 2: //update
                        clasificacionRepositorio.ActualizarClasificacion(clasificacion);
                        mensaje = string.Format(mensaje, "Actualizado");

                        break;

                    case 3: //delete
                        clasificacionRepositorio.EliminarClasificacion(clasificacion);
                        mensaje = string.Format(mensaje, "Eliminado");

                        break;
                    default:
                        mensaje = "Opcion no implementada 1= Insert, 2=Update, 3=Delete";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = "se presento un inconveniente en el proceso de manejo de informacion";
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }

            return mensaje;
        }

        public string CUDCliente(int opcion, cliente cliente)
        {
            string mensaje = "Rol " + cliente.nombre + " {0} exitosamente";
            try
            {
                switch (opcion)
                {
                    case 1: //insert
                        clienteRepositorio.InsertarCliente(cliente);
                        mensaje = string.Format(mensaje, "Insertado");
                        break;

                    case 2: //update
                        clienteRepositorio.ActualizarCliente(cliente);
                        mensaje = string.Format(mensaje, "Actualizado");

                        break;

                    case 3: //delete
                        clienteRepositorio.EliminarCliente(cliente);
                        mensaje = string.Format(mensaje, "Eliminado");

                        break;
                    default:
                        mensaje = "Opcion no implementada 1= Insert, 2=Update, 3=Delete";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = "se presento un inconveniente en el proceso de manejo de informacion";
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }

            return mensaje;
        }

        public string CUDDetalleEmpleado(int opcion, detalle_empleado detalleEmpleado)
        {
            string mensaje = "Detalle empleado  {0}  exitosamente";
            try
            {
                switch (opcion)
                {
                    case 1: //insert
                        detalleEmpleadoRepositorio.InsertarDetalleEmpleado(detalleEmpleado);
                        mensaje = string.Format(mensaje, "Insertado");
                        break;

                    case 2: //update
                        detalleEmpleadoRepositorio.ActualizarDetalleEmpleado(detalleEmpleado);
                        mensaje = string.Format(mensaje, "Actualizado");

                        break;

                    case 3: //delete
                        detalleEmpleadoRepositorio.EliminarDetalleEmpleado
(detalleEmpleado);
                        mensaje = string.Format(mensaje, "Eliminado");

                        break;
                    default:
                        mensaje = "Opcion no implementada 1= Insert, 2=Update, 3=Delete";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = "se presento un inconveniente en el proceso de manejo de informacion";
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }

            return mensaje;
        }

        public string CUDDetalleProducto(int opcion, detalle_producto_suministro detalleProducto)
        {
            string mensaje = "Detalle Producto  {0}  exitosamente";
            try
            {
                switch (opcion)
                {
                    case 1: //insert
                        detalleProductoRepositorio.InsertarDetallePoductoSuministro(detalleProducto);
                        mensaje = string.Format(mensaje, "Insertado");
                        break;

                    case 2: //update
                        detalleProductoRepositorio.ActualizarDetallePoductoSuministro(detalleProducto);
                        mensaje = string.Format(mensaje, "Actualizado");

                        break;

                    case 3: //delete
                        detalleProductoRepositorio.EliminarDetallePoductoSuministro(detalleProducto);
                        mensaje = string.Format(mensaje, "Eliminado");

                        break;
                    default:
                        mensaje = "Opcion no implementada 1= Insert, 2=Update, 3=Delete";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = "se presento un inconveniente en el proceso de manejo de informacion";
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }

            return mensaje;
        }

        public string CUDDetalleProveedor(int opcion, detalle_proveedor detalleProveedor)
        {
            string mensaje = "Detalle Producto  {0}  exitosamente";
            try
            {
                switch (opcion)
                {
                    case 1: //insert
                        detalleProveedorRepositorio.InsertarDetalleProveedor(detalleProveedor);
                        mensaje = string.Format(mensaje, "Insertado");
                        break;

                    case 2: //update
                        detalleProveedorRepositorio.ActualizarDetalleProveedor(detalleProveedor);
                        mensaje = string.Format(mensaje, "Actualizado");

                        break;

                    case 3: //delete
                        detalleProveedorRepositorio.EliminarDetalleProveedor(detalleProveedor);
                        mensaje = string.Format(mensaje, "Eliminado");

                        break;
                    default:
                        mensaje = "Opcion no implementada 1= Insert, 2=Update, 3=Delete";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = "se presento un inconveniente en el proceso de manejo de informacion";
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }

            return mensaje;
        }

        public string CUDEmpleado(int opcion, empleado empleado)
        {
            string mensaje = "Detalle Producto  {0}  exitosamente";
            try
            {
                switch (opcion)
                {
                    case 1: //insert
                        empleadoRepositorio.InsertarEmpleado(empleado);
                        mensaje = string.Format(mensaje, "Insertado");
                        break;

                    case 2: //update
                        empleadoRepositorio.ActualizarEmpleado(empleado);
                        mensaje = string.Format(mensaje, "Actualizado");

                        break;

                    case 3: //delete
                        empleadoRepositorio.EliminarEmpleado(empleado);
                        mensaje = string.Format(mensaje, "Eliminado");

                        break;
                    default:
                        mensaje = "Opcion no implementada 1= Insert, 2=Update, 3=Delete";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = "se presento un inconveniente en el proceso de manejo de informacion";
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }

            return mensaje;
        }

        public string CUDEstadoEvento(int opcion, estado_evento estadoEvento)
        {
            string mensaje = "Rol " + estadoEvento.nombre + " {0} exitosamente";
            try
            {
                switch (opcion)
                {
                    case 1: //insert
                        estadoEventoRepositorio.InsertarEstadoEvento(estadoEvento);
                        mensaje = string.Format(mensaje, "Insertado");
                        break;

                    case 2: //update
                        estadoEventoRepositorio.ActualizareEstadoEvento(estadoEvento);
                        mensaje = string.Format(mensaje, "Actualizado");

                        break;

                    case 3: //delete
                        estadoEventoRepositorio.EliminarEstadoEvento(estadoEvento);
                        mensaje = string.Format(mensaje, "Eliminado");

                        break;
                    default:
                        mensaje = "Opcion no implementada 1= Insert, 2=Update, 3=Delete";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = "se presento un inconveniente en el proceso de manejo de informacion";
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }

            return mensaje;
        }

        public string CUDEvento(int opcion, evento evento)
        {
            string mensaje = "Evento {0} exitosamente";
            try
            {
                switch (opcion)
                {
                    case 1: //insert
                        eventoRepositorio.InsertarEvento(evento);
                        mensaje = string.Format(mensaje, "Insertado");
                        break;

                    case 2: //update
                        eventoRepositorio.ActualizareEvento(evento);
                        mensaje = string.Format(mensaje, "Actualizado");

                        break;

                    case 3: //delete
                        eventoRepositorio.EliminarEvento(evento);
                        mensaje = string.Format(mensaje, "Eliminado");

                        break;
                    default:
                        mensaje = "Opcion no implementada 1= Insert, 2=Update, 3=Delete";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = "se presento un inconveniente en el proceso de manejo de informacion";
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }

            return mensaje;
        }

        public string CUDLugar(int opcion, lugar lugar)
        {
            string mensaje = "Lugar {0} exitosamente";
            try
            {
                switch (opcion)
                {
                    case 1: //insert
                        lugarRepositorio.InsertarLugar(lugar);
                        mensaje = string.Format(mensaje, "Insertado");
                        break;

                    case 2: //update
                        lugarRepositorio.ActualizarLugar(lugar);
                        mensaje = string.Format(mensaje, "Actualizado");

                        break;

                    case 3: //delete
                        lugarRepositorio.EliminarLugar(lugar);
                        mensaje = string.Format(mensaje, "Eliminado");

                        break;
                    default:
                        mensaje = "Opcion no implementada 1= Insert, 2=Update, 3=Delete";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = "se presento un inconveniente en el proceso de manejo de informacion";
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }

            return mensaje;
        }

        public string CUDMedidaProducto(int opcion, medida_producto tipoDocumento)
        {
            string mensaje = "Medida " + tipoDocumento.nombre + " {0} exitosamente";
            try
            {
                switch (opcion)
                {
                    case 1: //insert
                        medidaProductoRepositorio.InsertarMedidaProducto(tipoDocumento);
                        mensaje = string.Format(mensaje, "Insertado");
                        break;

                    case 2: //update
                        medidaProductoRepositorio.ActualizareMedidaProducto(tipoDocumento);
                        mensaje = string.Format(mensaje, "Actualizado");

                        break;

                    case 3: //delete
                        medidaProductoRepositorio.EliminarMedidaProducto(tipoDocumento);
                        mensaje = string.Format(mensaje, "Eliminado");

                        break;
                    default:
                        mensaje = "Opcion no implementada 1= Insert, 2=Update, 3=Delete";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = "se presento un inconveniente en el proceso de manejo de informacion";
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }

            return mensaje;
        }

        public string CUDPaquete(int opcion, paquete paquete)
        {
            string mensaje = "Paquete {0} exitosamente";
            try
            {
                switch (opcion)
                {
                    case 1: //insert
                        paqueteRepositorio.InsertarPaquete(paquete);
                        mensaje = string.Format(mensaje, "Insertado");
                        break;

                    case 2: //update
                        paqueteRepositorio.ActualizarePaquete(paquete);
                        mensaje = string.Format(mensaje, "Actualizado");

                        break;

                    case 3: //delete
                        paqueteRepositorio.EliminarPaquete(paquete);
                        mensaje = string.Format(mensaje, "Eliminado");

                        break;
                    default:
                        mensaje = "Opcion no implementada 1= Insert, 2=Update, 3=Delete";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = "se presento un inconveniente en el proceso de manejo de informacion";
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }

            return mensaje;
        }

        public string CUDPedido(int opcion, pedido pedido)
        {
            string mensaje = "Pedido {0} exitosamente";
            try
            {
                switch (opcion)
                {
                    case 1: //insert
                        pedidoRepositorio.InsertarPedido(pedido);
                        mensaje = string.Format(mensaje, "Insertado");
                        break;

                    case 2: //update
                        pedidoRepositorio.ActualizarePedido(pedido);
                        mensaje = string.Format(mensaje, "Actualizado");

                        break;

                    case 3: //delete
                        pedidoRepositorio.EliminarPedido(pedido);
                        mensaje = string.Format(mensaje, "Eliminado");

                        break;
                    default:
                        mensaje = "Opcion no implementada 1= Insert, 2=Update, 3=Delete";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = "se presento un inconveniente en el proceso de manejo de informacion";
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }

            return mensaje;
        }

        public string CUDProducto(int opcion, producto producto)
        {
            string mensaje = "Producto {0} exitosamente";
            try
            {
                switch (opcion)
                {
                    case 1: //insert
                        productoRepositorio.InsertarProducto(producto);
                        mensaje = string.Format(mensaje, "Insertado");
                        break;

                    case 2: //update
                        productoRepositorio.ActualizareProducto(producto);
                        mensaje = string.Format(mensaje, "Actualizado");

                        break;

                    case 3: //delete
                        productoRepositorio.EliminarProducto(producto);
                        mensaje = string.Format(mensaje, "Eliminado");

                        break;
                    default:
                        mensaje = "Opcion no implementada 1= Insert, 2=Update, 3=Delete";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = "se presento un inconveniente en el proceso de manejo de informacion";
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }

            return mensaje;
        }

        public string CUDProveedor(int opcion, proveedor proveedor)
        {
            string mensaje = "Proveedor {0} exitosamente";
            try
            {
                switch (opcion)
                {
                    case 1: //insert
                        proveedorRepositorio.InsertarProveedor(proveedor);
                        mensaje = string.Format(mensaje, "Insertado");
                        break;

                    case 2: //update
                        proveedorRepositorio.ActualizareProveedor(proveedor);
                        mensaje = string.Format(mensaje, "Actualizado");

                        break;

                    case 3: //delete
                        proveedorRepositorio.EliminarProveedor(proveedor);
                        mensaje = string.Format(mensaje, "Eliminado");

                        break;
                    default:
                        mensaje = "Opcion no implementada 1= Insert, 2=Update, 3=Delete";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = "se presento un inconveniente en el proceso de manejo de informacion";
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }

            return mensaje;
        }

        public string CUDRoles(int opcion, rol rol)
        {
            string mensaje = "Rol " + rol.nombre + " {0} {1}";
            try
            {
                switch (opcion)
                {
                    case 1: //insert
                        mensaje = rolRepositorio.InsertarRol(rol) ? string.Format(mensaje, "Insertado", "Exitosamente") : string.Format(mensaje, "No pudo ser ", "Insertado");
                        break;

                    case 2: //update
                        rolRepositorio.ActualizarRol(rol);
                        mensaje = string.Format(mensaje, "Actualizado");

                        break;

                    case 3: //delete
                        rolRepositorio.EliminarRol(rol);
                        mensaje = string.Format(mensaje, "Eliminado");

                        break;
                    default:
                        mensaje = "Opcion no implementada 1= Insert, 2=Update, 3=Delete";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = "se presento un inconveniente en el proceso de manejo de informacion";
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }

            return mensaje;
        }

        public string CUDSolicitudes(int opcion, solicitud solicitud)
        {
            string mensaje = "Solicitud {0} {1}";
            try
            {
                switch (opcion)
                {
                    case 1: //insert
                        mensaje = solicitudRepositorio.InsertarSolicitud(solicitud) ? string.Format(mensaje, "Insertado", "Exitosamente") : string.Format(mensaje, "No pudo ser ", "Insertado");
                        break;

                    case 2: //update
                        solicitudRepositorio.ActualizarSolicitud(solicitud);
                        mensaje = string.Format(mensaje, "Actualizado");

                        break;

                    case 3: //delete
                        solicitudRepositorio.EliminarSolicitud(solicitud);
                        mensaje = string.Format(mensaje, "Eliminado");

                        break;
                    default:
                        mensaje = "Opcion no implementada 1= Insert, 2=Update, 3=Delete";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = "se presento un inconveniente en el proceso de manejo de informacion";
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }

            return mensaje;
        }

        public string CUDSuministro(int opcion, suministro suministro)
        {
            string mensaje = "Suministro {0} exitosamente";
            try
            {
                switch (opcion)
                {
                    case 1: //insert
                        suministroRepositorio.InsertarSuministro(suministro);
                        mensaje = string.Format(mensaje, "Insertado");
                        break;

                    case 2: //update
                        suministroRepositorio.ActualizareSuministro(suministro);
                        mensaje = string.Format(mensaje, "Actualizado");

                        break;

                    case 3: //delete
                        suministroRepositorio.EliminarSuministro(suministro);
                        mensaje = string.Format(mensaje, "Eliminado");

                        break;
                    default:
                        mensaje = "Opcion no implementada 1= Insert, 2=Update, 3=Delete";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = "se presento un inconveniente en el proceso de manejo de informacion";
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }

            return mensaje;
        }

        public string CUDTipoDocumento(int opcion, tipo_documento tipoDocumento)
        {
            string mensaje = "Medida " + tipoDocumento.descripcion_documento + " {0} exitosamente";
            try
            {
                switch (opcion)
                {
                    case 1: //insert
                        tipoDocumentoRepositorio.InsertarTipoDocumento(tipoDocumento);
                        mensaje = string.Format(mensaje, "Insertado");
                        break;

                    case 2: //update
                        tipoDocumentoRepositorio.ActualizareTipoDocumento(tipoDocumento);
                        mensaje = string.Format(mensaje, "Actualizado");

                        break;

                    case 3: //delete
                        tipoDocumentoRepositorio.EliminarTipoDocumento(tipoDocumento);
                        mensaje = string.Format(mensaje, "Eliminado");

                        break;
                    default:
                        mensaje = "Opcion no implementada 1= Insert, 2=Update, 3=Delete";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = "se presento un inconveniente en el proceso de manejo de informacion";
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }

            return mensaje;
        }

        public string CUDTipoEvento(int opcion, tipo_evento tipoEvento)
        {
            string mensaje = "Medida " + tipoEvento.nombre + " {0} exitosamente";
            try
            {
                switch (opcion)
                {
                    case 1: //insert
                        tipoEventoRepositorio.InsertarTipoEvento(tipoEvento);
                        mensaje = string.Format(mensaje, "Insertado");
                        break;

                    case 2: //update
                        tipoEventoRepositorio.ActualizareTipoEvento(tipoEvento);
                        mensaje = string.Format(mensaje, "Actualizado");

                        break;

                    case 3: //delete
                        tipoEventoRepositorio.EliminarTipoEvento(tipoEvento);
                        mensaje = string.Format(mensaje, "Eliminado");

                        break;
                    default:
                        mensaje = "Opcion no implementada 1= Insert, 2=Update, 3=Delete";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = "se presento un inconveniente en el proceso de manejo de informacion";
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }

            return mensaje;
        }

        public string CUDTipoProducto(int opcion, tipo_producto tipoProducto)
        {
            string mensaje = "Medida " + tipoProducto.nombre + " {0} exitosamente";
            try
            {
                switch (opcion)
                {
                    case 1: //insert
                        tipoProductoRepositorio.InsertarTipoProducto(tipoProducto);
                        mensaje = string.Format(mensaje, "Insertado");
                        break;

                    case 2: //update
                        tipoProductoRepositorio.ActualizarTipoProducto(tipoProducto);
                        mensaje = string.Format(mensaje, "Actualizado");

                        break;

                    case 3: //delete
                        tipoProductoRepositorio.EliminarTipoProducto(tipoProducto);
                        mensaje = string.Format(mensaje, "Eliminado");

                        break;
                    default:
                        mensaje = "Opcion no implementada 1= Insert, 2=Update, 3=Delete";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = "se presento un inconveniente en el proceso de manejo de informacion";
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }

            return mensaje;
        }

        public string CUDUsuario(int opcion, usuario usuario)
        {
            string mensaje = "Medida " + usuario.id_usuario + " {0} exitosamente";
            try
            {
                switch (opcion)
                {
                    case 1: //insert
                        usuarioRepositorio.InsertarUsuario(usuario);
                        mensaje = string.Format(mensaje, "Insertado");
                        break;

                    case 2: //update
                        usuarioRepositorio.ActualizareUsuario(usuario);
                        mensaje = string.Format(mensaje, "Actualizado");

                        break;

                    case 3: //delete
                        usuarioRepositorio.EliminarUsuario(usuario);
                        mensaje = string.Format(mensaje, "Eliminado");

                        break;
                    default:
                        mensaje = "Opcion no implementada 1= Insert, 2=Update, 3=Delete";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = "se presento un inconveniente en el proceso de manejo de informacion";
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }

            return mensaje;
        }






        public List<ciudad> ObtenerCiudades(int idCiudad, string nombre)
        {
            List<ciudad> lstCiudad = null;
            try
            {
                lstCiudad = ciudadRepositorio.FiltrarCiudades(idCiudad, nombre);
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }
            return lstCiudad;
        }
        public List<clasificacion> ObtenerClasificacion(int idClasificacion, string nombreClasificacion)
        {
            List<clasificacion> lstClasificacions = null;
            try
            {
                lstClasificacions = clasificacionRepositorio.FiltrarClasificaciones(idClasificacion, nombreClasificacion);
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }
            return lstClasificacions;
        }
        public List<cliente> ObtenerClientes(int idCliente, string nombreCliente, int tipoDocumento, string numeroIdentificacion, string apellido, string telefono, string celular, string direccion, int ciudad, string correo, string estado)
        {
            List<cliente> lstClientes = null;
            try
            {
                lstClientes = clienteRepositorio.FiltrarClientes(idCliente, numeroIdentificacion, tipoDocumento, nombreCliente, apellido, telefono, celular, direccion, ciudad, correo, estado);
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }
            return lstClientes;
        }
        public List<detalle_empleado> ObtenerDetalleEmpleado(long idEvento, long idEmpleado, double calificacion, string estado, long idDetalleEmpleado)
        {
            List<detalle_empleado> lstDetalleEmpleado = null;
            try
            {
                lstDetalleEmpleado = detalleEmpleadoRepositorio.FiltrarDetalleEmpleados(idEvento, idEmpleado, calificacion, estado, idDetalleEmpleado);
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }
            return lstDetalleEmpleado;
        }

        public List<detalle_producto_suministro> ObtenerDetalleProducto(int idProducto, int idSuminstro, int cantidad, int estado, long idProductoSuministro)
        {
            List<detalle_producto_suministro> lstDetalleProducto = null;
            try
            {
                lstDetalleProducto = detalleProductoRepositorio.FiltrarDetallePoductoSuministros(idProducto, idSuminstro, cantidad, estado, idProductoSuministro);
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }
            return lstDetalleProducto;
        }

        public List<detalle_proveedor> ObtenerDetalleProveedor(int idDetalleProveedor, int proveedorIdProvedor, int productoIdSuministro, string estado)
        {
            List<detalle_proveedor> lstDetalleProveedor = null;
            try
            {
                lstDetalleProveedor = detalleProveedorRepositorio.FiltrarDetalleProveedores(idDetalleProveedor, proveedorIdProvedor, productoIdSuministro, estado);
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }
            return lstDetalleProveedor;
        }

        public List<empleado> ObtenerEmpleados(long idEmpleado, string numeroIdentificacion, int tipoDocumento, string nombreEmpleado, string apellidoEmpleado, int idRol, string correo, string direccion, string telefono
            , string barrio, string estado)
        {
            List<empleado> lstEmpleados = null;
            try
            {
                lstEmpleados = empleadoRepositorio.FiltrarEmpleadoes(idEmpleado, numeroIdentificacion, tipoDocumento, nombreEmpleado, apellidoEmpleado, idRol, correo, direccion, telefono
            , barrio, estado);
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }
            return lstEmpleados;
        }

        public List<estado_evento> ObtenerEstadosEventos(int idEstado, string nombre)
        {
            List<estado_evento> lstEstados = null;
            try
            {
                lstEstados = estadoEventoRepositorio.FiltrarEstadosEventos(idEstado, nombre);
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }
            return lstEstados;
        }


        public List<evento> ObtenerEventos(long idEvento, long IdSolicitud, long idCliente, int tipoEvento, int idLugar
            , int cantidadPersonas, int cantidadMeseros, DateTime horaInicio, DateTime horaFin, DateTime fecha,
            decimal precio, string observaciones, int estado)
        {
            List<evento> lstEventos = null;
            try
            {
                lstEventos = eventoRepositorio.FiltrarEstadosEventos(idEvento, IdSolicitud, idCliente, tipoEvento, idLugar
            , cantidadPersonas, cantidadMeseros, horaInicio, horaFin, fecha, precio, observaciones, estado);
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }
            return lstEventos;
        }


        public List<lugar> ObtenerLugares(int idLugar, string nombreLugar, string descripcion, int cantMaxPersonas
            , string direccion, string ubicacion, string contacto, string telefonoContacto, int idCiudad)
        {
            List<lugar> lstLugares = null;
            try
            {
                lstLugares = lugarRepositorio.FiltrarLugares(idLugar, nombreLugar, descripcion, cantMaxPersonas
            , direccion, ubicacion, contacto, telefonoContacto, idCiudad);
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }
            return lstLugares;
        }


        public List<medida_producto> ObtenerMedidas(int idMedidaProducto, string nombreMedidaProducto)
        {
            List<medida_producto> lstMedidas = null;
            try
            {
                lstMedidas = medidaProductoRepositorio.FiltrarMedidasProductos(idMedidaProducto, nombreMedidaProducto);
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }
            return lstMedidas;
        }

        public List<paquete> ObtenerPaquetes(int idPaquete, string nombrePaquete, int idClasificacion, string descripcion, int idLugar
            , int cantidadPersonas, decimal precio, string pdf, string foto, string estado)
        {
            List<paquete> lstPaquetees = null;
            try
            {
                lstPaquetees = paqueteRepositorio.FiltrarPaquetes(idPaquete, nombrePaquete, idClasificacion, descripcion, idLugar
            , cantidadPersonas, precio, pdf, foto, estado);
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }
            return lstPaquetees;
        }

        public List<pedido> ObtenerPedidos(int idPedido, int idProducto, int idProveedor, DateTime? fechaPedido, string cantidad, int idMedidaProducto
            , string observaciones, string fechaSugerida, string estado)
        {
            List<pedido> lstPedidoes = null;
            try
            {
                lstPedidoes = pedidoRepositorio.FiltrarPedidos(idPedido, idProducto, idProveedor, fechaPedido, cantidad, idMedidaProducto
            , observaciones, fechaSugerida, estado);
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }
            return lstPedidoes;
        }
        public List<producto> ObtenerProductos(int idProducto, string nombre, string foto, int tipo, int cantidadMinima, int medida, decimal precioUnidad,
            string observaciones, string estado)
        {
            List<producto> lstProductos = null;
            try
            {
                lstProductos = productoRepositorio.FiltrarProductos(idProducto, nombre, foto, tipo, cantidadMinima, medida, precioUnidad, observaciones, estado);
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }
            return lstProductos;
        }

        public List<proveedor> ObtenerProveedores(int idProveedor, string razonSocial, string direccion, string telefono, string correo, string estado)
        {
            List<proveedor> lstProveedors = null;
            try
            {
                lstProveedors = proveedorRepositorio.FiltrarProveedores(idProveedor, razonSocial, direccion, telefono, correo, estado);
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }
            return lstProveedors;
        }

        public List<rol> ObtenerRoles(int idRol, string nombreRol)
        {
            List<rol> lstRol = null;
            try
            {
                lstRol = rolRepositorio.FiltrarRoles(idRol, nombreRol);
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }
            return lstRol;
        }


        public List<solicitud> ObtenerSolicitudes(int idSolicitud, string nombreCliente, int cantidadPersonas, string telefono, string email, int TipoEvento, string hora,
            DateTime fecha, string observaciones, string estado, bool visto)
        {
            List<solicitud> lstSolicitud = null;
            try
            {
                lstSolicitud = solicitudRepositorio.FiltrarSolicitudes(idSolicitud, nombreCliente, cantidadPersonas, telefono, email, TipoEvento, hora,
            fecha, observaciones, estado, visto);
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }
            return lstSolicitud;
        }

        public List<suministro> ObtenerSuministros(int idSuministro, string nombreSuministro, string foto, int cantidad, int cantidadMinima, int medida, decimal precioUnidad
            , string observaciones, string estado)
        {
            List<suministro> lstSuministro = null;
            try
            {
                lstSuministro = suministroRepositorio.FiltrarSuministros(idSuministro, nombreSuministro, foto, cantidad, cantidadMinima, medida, precioUnidad
            , observaciones, estado);
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }
            return lstSuministro;
        }


        public List<tipo_documento> ObtenerTipoDocumentos(int idTipoDocumento, string nombreTipoDocumento, string abreviatura)
        {
            List<tipo_documento> lstTipoDocumento = null;
            try
            {
                lstTipoDocumento = tipoDocumentoRepositorio.FiltrarTiposDocumento(idTipoDocumento, nombreTipoDocumento, abreviatura);
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }
            return lstTipoDocumento;
        }

        public List<tipo_evento> ObtenerTipoEventos(int idTipoEvento, string nombreTipoEvento)
        {
            List<tipo_evento> lstTipoEvento = null;
            try
            {
                lstTipoEvento = tipoEventoRepositorio.FiltrarTiposEvento(idTipoEvento, nombreTipoEvento);
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }
            return lstTipoEvento;
        }

        public List<tipo_producto> ObtenerTipoProductos(int idTipoProducto, string nombreTipoProducto)
        {
            List<tipo_producto> lstTipoProducto = null;
            try
            {
                lstTipoProducto = tipoProductoRepositorio.FiltrarTipoProductos(idTipoProducto, nombreTipoProducto);
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }
            return lstTipoProducto;
        }

        public List<usuario> ObtenerUsuarios(int idUsuario, long idEmpleado, string nombreUsuario, string estado)
        {
            List<usuario> lstTipoProducto = null;
            try
            {
                lstTipoProducto = usuarioRepositorio.FiltrarUsuarios(idUsuario, idEmpleado, nombreUsuario, estado);
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadesAuditoria.GenerarLog("Error en clase ServiceCRUD " + ex.Message + " En " + ex.StackTrace);
            }
            return lstTipoProducto;
        }
    }
}
