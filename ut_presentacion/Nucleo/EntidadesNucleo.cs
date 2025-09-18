using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib_dominio.Entidades;

namespace ut_presentacion.Nucleo
{
    public class EntidadesNucleo
    {
        public static Clientes Cliente()
        {
            return new Clientes
            {
                Documento = new Random().Next(1000, 9999),
                Nombre = "ClientePrueba-" + DateTime.Now.ToString("yyyyMMddHHmmss")
            };
        }

        public static Ciudades? Ciudad()
        {
            return new Ciudades
            {
                Nombre = "CiudadPrueba-" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                Departamento = "DepartamentoPrueba",
                Pais = "PaisPrueba"
            };
        }

        public static Sucursales Sucursal()
        {
            return new Sucursales
            {
                Nombre = "SucursalPrueba-" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                Ciudad = 1 // se ajusta en la prueba con un id válido
            };
        }

        public static Categorias Categoria()
        {
            return new Categorias
            {
                Nombre = "CategoriaPrueba-" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                Descripcion = "Descripcion prueba"
            };
        }

        public static Instrumentos Instrumento()
        {
            return new Instrumentos
            {
                Nombre = "InstrumentoPrueba-" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                Marca = "MarcaPrueba",
                Modelo = "ModeloPrueba",
                Precio = 999.99m,
                Categoria = 1 // se ajusta en la prueba
            };
        }

        public static Accesorios Accesorio()
        {
            return new Accesorios
            {
                Nombre = "AccesorioPrueba-" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                Marca = "MarcaPrueba",
                Precio = 199.99m,
                Categoria = 1 // se ajusta en la prueba
            };
        }

        public static Admin Admin()
        {
            return new Admin
            {
                Documento = new Random().Next(1000, 9999),
                Nombre = "ClientePrueba-" + DateTime.Now.ToString("yyyyMMddHHmmss")
            };
        }

        public static Asesores Asesor()
        {
            return new Asesores
            {
                
                Nombre = "AsesorPrueba-" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                Sucursal = 1 // se ajusta en la prueba con un id válido
            };
        }

        public static Empleado Empleado()
        {
            return new Empleado
            {
                
                Nombre = "EmpleadoPrueba-" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                Cargo = "CargoPrueba" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                Sucursal = 1 // se ajusta en la prueba con un id válido
            };
        }

        public static Lutiers Lutier()
        {
            return new Lutiers
            {
                Documento = new Random().Next(1000, 9999),
                Nombre = "LutierPrueba-" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                Especialidad = "EspecialidadPrueba"
            };
        }

        public static Facturas Factura()
        {
            return new Facturas
            {
                Fecha = DateTime.Now,
                Cliente = 1, // se ajusta en la prueba con un id válido
                Asesor = 1   // se ajusta en la prueba con un id válido
            };
        }

        public static Instrumentos_Facturas Instrumento_Factura()
        {
            return new Instrumentos_Facturas
            {
                Instrumento= 1, // se ajusta en la prueba con un id válido
                Factura = 1 ,     // se ajusta en la prueba con un id válido
                Cantidad = 1,
                Subtotal = 999.99m
            };
        }

        public static Clientes_Instrumentos Cliente_Instrumento()
        {
            return new Clientes_Instrumentos
            {
                Cliente = 1, // se ajusta en la prueba con un id válido
                Instrumento = 1, // se ajusta en la prueba con un id válido
                Fecha_Compra = DateTime.Now,
                Estado = "Vendido"
            };
        }

        public static Instrumentos_Accesorios Instrumento_Accesorio()
        {
            return new Instrumentos_Accesorios
            {
                Instrumento = 1, // se ajusta en la prueba con un id válido
                Accesorio = 1    // se ajusta en la prueba con un id válido
            };
        }
    }
}

