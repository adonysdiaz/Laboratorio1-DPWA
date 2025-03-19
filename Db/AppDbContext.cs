
using Microsoft.EntityFrameworkCore;
using MVC5.Models;
using System.Collections.Generic;

namespace MVC5.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Alumnos> Alumnos { get; set; }
    }
}

