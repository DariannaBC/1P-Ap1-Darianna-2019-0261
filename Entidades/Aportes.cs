﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1P_Ap1_Darianna_2019_0261.Entidades
{
   public  class Aportes
    {
        [Key]
        public int AporteId { get; set; }
        public DateTime Fecha { get; set; }
        public String Persona { get; set; }
        public String Concepto { get; set; }
        public float Monto { get; set; }

        public Aportes()
        {
            AporteId = 0;
            Fecha = DateTime.Now;
            Persona = string.Empty;
            Concepto = string.Empty;
            Monto = 0;
        }
    }
}