﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text;

namespace Biblioteca.core
{
    public class Liibros
    {
        [Required,Key]      
        public int ID_libro { get; set; }
        //  [Required, StringLength(80) ]
        public string Ubicación_física { get; set; }

        public int ID_autor_libro { get; set; }
        [Required, StringLength(80) ]
        public string Titulo { get; set; }
        public int Paginas { get; set; }
        public int ID_idioma { get; set; }
        public Idioma Idioma { get; set; }
        //public int ID_editorial_libro { get; set; }
        public string editorial { get; set; }
        [Required]
        public int ID_estado { get; set; }
        public Estado Estado { get; set; }
       
        public int ID_país { get; set; }
        public pais pais { get; set; }
        public string Resumen_del_documento { get; set; }
        public int Publicación { get; set; }
        public string Serie { get; set; }
        
        public string Notas { get; set; }

    }
}

