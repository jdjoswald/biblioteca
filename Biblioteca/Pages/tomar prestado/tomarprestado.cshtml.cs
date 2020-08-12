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
        int idlibro = 0;


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
            
            idlibro = libroid;
            prestamo = new Prestams();
            prestamo.ID_libro = libroid;
            prestamosData.Add(prestamo);
            usuarios = userData.GetUserBYName(null);
            System.Diagnostics.Debug.WriteLine(libros.pais);

            return Page();
        }

        public IActionResult OnPost()
        {
            usuario = userData.GetuserByCedula(usuario.Cedula);
            prestamo.ID_usuario = usuario.ID_usuario;
            //libros = librosData.GetByid(idlibro);
            prestamo.usuario = usuario.Nombre;
            System.Diagnostics.Debug.WriteLine(libros.pais);
            if (usuario.tardanzas == 0)
            {
                
                prestamosData.Add(prestamo);
                librosData.Upadate(libros);
                librosData.Commit();
                prestamosData.commit();
                return RedirectToPage("/Libros/Libros");
            }
            mensaje = "este usuario tiene una tardanza debe saldar su tardanza ";
            return Page();
            
            
        }
    }
}
