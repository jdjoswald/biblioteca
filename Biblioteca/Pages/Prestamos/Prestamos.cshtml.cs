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
    public class PrestamosModel : PageModel
    {
        private readonly Iprestamos prestamosData;
        public IEnumerable<Prestams> prestamos { get; set; }
        public PrestamosModel(Iprestamos PrestamosData) 
        { 
            this.prestamosData = PrestamosData;
        }

        public void OnGet( string searchterm)
        {
            prestamos = prestamosData.GetPrestamosByname(searchterm);
        }
    }
}
