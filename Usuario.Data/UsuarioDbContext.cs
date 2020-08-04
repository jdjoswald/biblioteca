using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Usuario.core;

namespace Usuario.Data
{
    class UsuarioDbContext: DbContext
    {
        public UsuarioDbContext( DbContextOptions<UsuarioDbContext>options)
            : base(options)
        {

        }
        public DbSet<Users> Usuarios { get; set; }
    }
}
