using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using PrimerRegistroCompleto.Entidades;

namespace PrimerRegistroCompleto.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Roles> Roles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = GestionPersonas.Db");
        }
    }
}
