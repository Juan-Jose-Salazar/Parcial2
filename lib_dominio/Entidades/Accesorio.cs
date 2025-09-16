using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Accesorio
    {
        public int Id { get; ser; }
        public string Nombre { get; set; }  
        public string Marca { get; set; }
        public string Precio { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
