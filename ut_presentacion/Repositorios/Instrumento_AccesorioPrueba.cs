using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib_repositorios.Interfaces;
using lib_repositorios.Implementaciones;
using Microsoft.EntityFrameworkCore;
using ut_presentacion.Nucleo;
using lib_dominio.Entidades;

namespace ut_presentacion.Repositorios
{
    [TestClass]
    public class InstrumentoAccesorioPrueba
    {
        private readonly IConexion? iConexion;
        private List<Instrumentos_Accesorios>? lista;
        private Instrumentos_Accesorios? entidad;

        public InstrumentoAccesorioPrueba()
        {
            iConexion = new Conexion();
            iConexion.StringConexion = Configuracion.ObtenerValor("StringConexion");
        }

        [TestMethod]
        public void Ejecutar()
        {
            Assert.AreEqual(true, Guardar());
            Assert.AreEqual(true, Modificar());
            Assert.AreEqual(true, Listar());
            Assert.AreEqual(true, Borrar());
        }

        public bool Guardar()
        {
            this.entidad = EntidadesNucleo.Instrumento_Accesorio();
            this.iConexion!.Instrumentos_Accesorios.Add(this.entidad);
            this.iConexion.SaveChanges();
            return true;
        }

        public bool Modificar()
        {
            
            this.entidad!.Accesorio = this.entidad.Accesorio;
            var entry = this.iConexion!.Entry(this.entidad);
            entry.State = EntityState.Modified;
            this.iConexion.SaveChanges();
            return true;
        }

        public bool Listar()
        {
            this.lista = this.iConexion!.Instrumentos_Accesorios.ToList();
            return lista.Count > 0;
        }

        public bool Borrar()
        {
            this.iConexion!.Instrumentos_Accesorios.Remove(this.entidad!);
            this.iConexion.SaveChanges();
            return true;
        }
    }
}
