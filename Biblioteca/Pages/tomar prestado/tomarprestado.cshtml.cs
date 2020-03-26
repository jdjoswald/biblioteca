using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.core;
using Biblioteca.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Prestamos.core;
using Prestamos.Data;

namespace Biblioteca.Pages.tomar_prestado
{
    public class tomarprestadoModel : PageModel
    {
        private readonly Iprestamos prestamosData;
        private readonly ILibrosData librosData;


        [BindProperty]
        public Prestams prestamo { get; set; }
        [BindProperty]
        public Liibros libros { get; set; }

        public tomarprestadoModel(Iprestamos prestamodata, ILibrosData librosData)
        {
            this.prestamosData = prestamodata;
            this.librosData = librosData;
        }


        public IActionResult OnGet(int libroid)
        {
            libros = librosData.GetByid(libroid);
            prestamo = new Prestams();
            prestamo.ID_libro = libroid;
           
            return Page();
        }

        public IActionResult OnPost()
        {
            librosData.Upadateest(libros);
            prestamosData.Add(prestamo);
            return RedirectToPage("/Libros/Libros");
            
            //return Page();
            
            
        }
    }
}
