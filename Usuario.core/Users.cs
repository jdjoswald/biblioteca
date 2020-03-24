using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Usuario.core
{
     public class Users
    {
        //[Required]
        public int ID_usuario { get; set; }
        [Required, StringLength(80)]
        public string Nombre { get; set; }
        [Required, StringLength(80)]
        public string Cedula{ get; set; }
        public   int tardanzas { get; set; }



    }
}
