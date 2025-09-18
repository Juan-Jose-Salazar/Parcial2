using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Instrumentos_Accesorios
    {
        public int Id { get; set; }
        public int Instrumento { get; set; }
        
        public int Accesorio { get; set; }


        [ForeignKey("Instrumento")] public Instrumentos? _Instrumento { get; set; }
        [ForeignKey("Accesorio")] public Accesorios? _Accesorio { get; set; }
    }
}
