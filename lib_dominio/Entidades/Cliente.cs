using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Cliente
    {
        public long Id { get; set; }           
        public int Documento { get; set; }     
        public string? Nombre { get; set; }

        public ICollection<Factura>? Facturas { get; set; }
    }
}
