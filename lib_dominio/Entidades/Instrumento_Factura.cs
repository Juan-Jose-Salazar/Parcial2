using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Instrumento_Factura
    {
        public int Id { get; set; }
        public int InstrumentoId { get; set; }
        public Instrumento Instrumento { get; set; }
        public int FacturaId { get; set; }
        public Factura Factura { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
        
    }
}
