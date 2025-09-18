﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Sucursales
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }

        
        public int Ciudad { get; set; }

        [ForeignKey("Ciudad")] public Ciudades? _Ciudad { get; set; }
        
    }
}
