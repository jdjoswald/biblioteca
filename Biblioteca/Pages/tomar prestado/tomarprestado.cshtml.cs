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
using Usuario.core;
using Usuario.Data;

namespace Biblioteca.Pages.tomar_prestado
{
    public class tomarprestadoModel : PageModel
    {
        private readonly Iprestamos prestamosData;
        private readonly ILibrosData librosData;
        private readonly IUserData userData;
        public string mensaje = "";


        [BindProperty]
        public Prestams prestamo { get; set; }
        [BindProperty]
        public Liibros libros { get; set; }
        [BindProperty]
        public IEnumerable<Users> usuarios { get; set; }
        [BindProperty]
        public Users usuario { get; set; }

        public tomarprestadoModel(Iprestamos prestamodata, ILibrosData librosData, 
                                  IUserData userData)
        {
            this.prestamosData = prestamodata;
            this.librosData = librosData;
            this.userData = userData;
        }


        public IActionResult OnGet(int libroid)
        {
            libros = librosData.GetByid(libroid);
            prestamo = new Prestams();
            prestamo.ID_libro = libroid;
            usuarios = userData.GetUserBYName(null);
            
            return Page();
        }

        public IActionResult OnPost()
        {
            usuario = userData.GetuserByCedula(usuario.Cedula);
            if (usuario.tardanzas == 0)
            {
                
                prestamo.ID_usuario = usuario.ID_usuario; //usuario.ID_usuario;
                prestamo.usuario = usuario.Nombre;
                librosData.Upadateest(libros);
                prestamosData.Add(prestamo);
                System.Diagnostics.Debug.WriteLine(prestamo.Fecha_devolucion);
                return RedirectToPage("/Libros/Libros");
            }
            mensaje = "este usuario tiene una tardanza debe saldar su tardanza ";
            return Page();
            
            
        }
    }
}
