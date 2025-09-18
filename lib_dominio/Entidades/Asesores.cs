using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Asesores
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int Sucursal { get; set; }


        [ForeignKey("Sucursal")] public Sucursales? _Sucursal { get; set; }
    }
}
