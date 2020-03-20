using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Usuario.core;
using Usuario.Data;

namespace Biblioteca
{
    public class TardanzasModel : PageModel
    {
        private readonly IUserData userData;

        public Users  usuario { get; set; }
        public TardanzasModel(IUserData userData)
        {
            this.userData = userData;
        }

        public  void  OnGet(int usuarioid )
        {
            usuario = userData.GetuserByid(usuarioid);
        }
    }
}