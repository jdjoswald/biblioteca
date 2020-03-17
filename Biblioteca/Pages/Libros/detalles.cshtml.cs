using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.core;
using Biblioteca.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Biblioteca
{
    public class detallesModel : PageModel
    {
        private readonly ILibrosData librosData;

        public Liibros Libros { get; set; }
        
        public detallesModel(ILibrosData librosData)
        {
            this.librosData = librosData;
        }

        public IActionResult OnGet( int libroid)
        {

            Libros = librosData.GetByid(libroid);
            if (Libros == null) { return RedirectToPage("./Notfound"); }
            return Page();
           



        }
       
    }
}