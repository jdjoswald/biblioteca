using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Usuario.core;
using Biblioteca.Data;
using Usuario.Data;

namespace Biblioteca.Pages.Usuarios
{
    public class anadiruModel : PageModel
    {
        private readonly IUserData userData;
        [BindProperty]
        public Users usuario { get; set; }
        public anadiruModel(IUserData userData) 
        {
            this.userData = userData;


        }
        public void OnGet()
        {
            usuario = new Users();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();

            }
            userData.Add(usuario);
            userData.commit();
            return RedirectToPage("./Usuario");
        }
    }
}
