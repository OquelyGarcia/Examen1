using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using SQLite;

namespace Contactos.Models
{
    internal class Contactos
    {
        
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int edad { get; set; }
        public string pais { get; set; }
        public string nota { get; set; }
        public NumberFormatInfo latitud { get; set; }
        public NumberFormatInfo longitud { get; set; }

    }
}
