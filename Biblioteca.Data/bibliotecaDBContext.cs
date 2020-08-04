using Biblioteca.core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Design;
using Usuario.core;
using Prestamos.core;

namespace Biblioteca.Data
{
    public class bibliotecaDBContext: DbContext
    {
        public bibliotecaDBContext(DbContextOptions<bibliotecaDBContext>options)
            :base(options)
        {

        }
        public DbSet<Liibros> Liibros { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Prestams> Prestams { get; set; }

    }
}
