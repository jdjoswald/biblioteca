using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Prestamos.core;
using Prestamos.Data;

namespace Biblioteca.Pages.Prestamos
{
    public class prestamodetalleModel : PageModel
    {
        private readonly Iprestamos prestamosData;
        [BindProperty]
        public Prestams prestamo { get; set; }
        public prestamodetalleModel(Iprestamos prestamodata) 
        {
            this.prestamosData = prestamodata;
        }
        public IActionResult OnGet(int prestamoid)
        {
            prestamo = prestamosData.GetByid(prestamoid);
            if (prestamo == null) { return RedirectToPage("../Libros/notfound"); }
            return Page();
        }
        public IActionResult OnPost()
        {
            prestamo = prestamosData.update(prestamo);
            prestamosData.commit();
            return Page();


        }
    }
}
