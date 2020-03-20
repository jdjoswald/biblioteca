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

namespace Biblioteca.Pages.Prestamos
{
    public class prestamodetalleModel : PageModel
    {
        private readonly Iprestamos prestamosData;
        private readonly ILibrosData librosData;
        [BindProperty]
        public Prestams prestamo { get; set; }
        [BindProperty]
        public Liibros libros { get; set; }
        public prestamodetalleModel(Iprestamos prestamodata, ILibrosData librosData) 
        {
            this.prestamosData = prestamodata;
            this.librosData = librosData;
        }
         
        
        public IActionResult OnGet(int prestamoid)
        {
            prestamo = prestamosData.GetByid(prestamoid);
            libros = librosData.GetByid(prestamo.ID_libro);
            if (prestamo == null) { return RedirectToPage("../Libros/notfound"); }
            return Page();
        }
        public IActionResult OnPost()
        {
            libros = librosData.Upadateest(libros);
            librosData.Commit();
            prestamo = prestamosData.update(prestamo);
            prestamosData.commit();
           
            return Page();


        }
    }
}
