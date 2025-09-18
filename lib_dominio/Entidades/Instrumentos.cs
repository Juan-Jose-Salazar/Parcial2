using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Instrumentos
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public decimal Precio { get; set; }
        public int Categoria { get; set; }

        [ForeignKey("Categoria")] public Categorias? _Categoria { get; set; }

    }
}
