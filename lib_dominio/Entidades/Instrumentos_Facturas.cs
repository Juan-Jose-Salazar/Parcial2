using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Instrumentos_Facturas
    {
        public int Id { get; set; }
        public int Instrumento { get; set; }
        
        public int Factura { get; set; }
        
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }



        [ForeignKey("Instrumento")] public Instrumentos? _Instrumento { get; set; }
        [ForeignKey("Factura")] public Facturas? _Factura { get; set; }

    }
}
