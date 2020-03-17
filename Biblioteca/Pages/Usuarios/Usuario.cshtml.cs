using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Usuario.core;
using Usuario.Data;

namespace Biblioteca.Pages.Usuarios
{
    public class UsuarioModel : PageModel
    {
        private readonly IUserData UsuarioData;
        public IEnumerable<Users> usuarios { get; set; }
        public UsuarioModel(IUserData UsuarioData)
        {
            this.UsuarioData = UsuarioData;
        }

        public void OnGet(string searchterm)
        {
            usuarios = UsuarioData.GetUserBYName(searchterm);
        }
    }
}
