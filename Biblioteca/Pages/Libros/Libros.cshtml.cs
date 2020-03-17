using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Biblioteca.core;

namespace Biblioteca.Pages.Libros
{
    public class LibrosModel : PageModel
    {
       
        private readonly ILibrosData LibrosData;
        public IEnumerable<Liibros> libros { get; set; }
      
        public LibrosModel( ILibrosData LibrosData) 
        {
            this.LibrosData = LibrosData;
        }

        public void OnGet (string searchterm)
        {
           
            libros = LibrosData.GetLibrosByName(searchterm);
        }
    }
}
