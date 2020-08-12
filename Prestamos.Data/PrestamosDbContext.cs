using Microsoft.EntityFrameworkCore;
using Prestamos.core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prestamos.Data
{
    public class PrestamosDbContext: DbContext
    {
        public DbSet<Prestams> Prestams { get; set; }
    }
}
