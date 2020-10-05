using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Raldy_P1_APL.Entidades
{
    public class Ciudades
    {
        [Key]
        public int CiudadId { get; set; }
        public string Nombre { get; set; }
        
    }
}