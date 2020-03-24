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

namespace Biblioteca.Pages.Prestamos
{
    public class prestamodetalleModel : PageModel
    {
        private readonly Iprestamos prestamosData;
        private readonly ILibrosData librosData;
        private readonly IUserData UsuarioData;
        [BindProperty]
        public Prestams prestamo { get; set; }
        [BindProperty]
        public Liibros libros { get; set; }
        [BindProperty]
        public Users usuario { get; set; }
        public prestamodetalleModel(Iprestamos prestamodata, ILibrosData librosData, IUserData UsuarioData) 
        {
            this.prestamosData = prestamodata;
            this.librosData = librosData;
            this.UsuarioData = UsuarioData;
        }
         
        
        public IActionResult OnGet(int prestamoid)
        {
            prestamo = prestamosData.GetByid(prestamoid);
            libros = librosData.GetByid(prestamo.ID_libro);
            usuario = UsuarioData.GetuserByid(prestamo.ID_usuario);
            prestamo.usuario = usuario.Nombre;
            if (prestamo == null) { return RedirectToPage("../Libros/notfound"); }
            return Page();
        }
        public IActionResult OnPost()
        {
            libros = librosData.Upadateest(libros);
            librosData.Commit();
            usuario = UsuarioData.update(usuario);
            UsuarioData.commit();
            prestamo = prestamosData.update(prestamo);
            prestamosData.commit();

            return RedirectToPage("./Prestamos");


        }
    }
}
