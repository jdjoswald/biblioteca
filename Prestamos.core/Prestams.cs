using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Prestamos.core
{
    public class Prestams
    {
        [Key]
        public int ID_prestamos { get; set; }  
        public int ID_libro { get; set; }
        public string Titulo { get; set; }
        public string usuario { get; set; }
        public int ID_usuario { get; set; }
        public string Nombre { get; set; }
        public int ID_Estado { get; set; }
        public string estado { get; set; }

        public DateTime Fecha_prestamo { get; set; }

        public DateTime Fecha_devolucion { get; set; }

    }
}
