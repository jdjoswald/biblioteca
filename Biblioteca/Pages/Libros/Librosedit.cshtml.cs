using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.core;
using Biblioteca.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Biblioteca.Pages.Libros
{
    public class LibroseditModel : PageModel
    {
        private readonly ILibrosData librosdata;
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public Liibros libros { get; set; }
        public IEnumerable<SelectListItem> paises { get; set; }
        public IEnumerable<SelectListItem> idiomas { get; set; }

        public LibroseditModel(ILibrosData librosdata,
                                IHtmlHelper htmlHelper)
        {
            this.librosdata = librosdata;
            this.htmlHelper = htmlHelper;
        }
        public IActionResult OnGet(int? libroid )
        {
            paises = htmlHelper.GetEnumSelectList<pais>();
            idiomas = htmlHelper.GetEnumSelectList<Idioma>();
            if (libroid.HasValue)
            {
                libros = librosdata.GetByid(libroid.Value);
            }
            else 
            {
                libros = new Liibros();
            }
                if (libros == null) 
            {
                return RedirectToPage("./notfound");
                }
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                paises = htmlHelper.GetEnumSelectList<pais>();
                idiomas = htmlHelper.GetEnumSelectList<Idioma>();

                return Page();
            }
            if (libros.ID_libro > 0)
            {
                libros = librosdata.Upadate(libros);
            }
            else
            {

                librosdata.Add(libros);
            }
            librosdata.Commit();
            return RedirectToPage("./Libros");


        }
    }
}
