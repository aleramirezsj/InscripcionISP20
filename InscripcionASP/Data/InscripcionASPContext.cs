using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

    public class InscripcionASPContext : DbContext
    {
        public InscripcionASPContext (DbContextOptions<InscripcionASPContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Carrera> Carrera { get; set; }
    }
