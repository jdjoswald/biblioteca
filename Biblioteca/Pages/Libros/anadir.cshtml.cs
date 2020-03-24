using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Biblioteca.core;
using Biblioteca.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Biblioteca.Pages.Libros
{
    public class anadirModel : PageModel
    {
        private readonly ILibrosData librosdata;
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public Liibros libros { get; set; }
        public IEnumerable<SelectListItem> paises { get; set; }
        public IEnumerable<SelectListItem> idiomas { get; set; }

        public anadirModel(ILibrosData librosdata,
                                IHtmlHelper htmlHelper)
        {
            this.librosdata = librosdata;
            this.htmlHelper = htmlHelper;
        }

        public IActionResult OnGet()
        {
            paises = htmlHelper.GetEnumSelectList<pais>();
            idiomas = htmlHelper.GetEnumSelectList<Idioma>();

            return Page();
        }
    }
}
