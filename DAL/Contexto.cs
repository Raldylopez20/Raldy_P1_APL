using System;
using System.Collections.Generic;
using System.Text;
using Raldy_P1_APL.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Raldy_P1_APL.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Ciudades> Ciudades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= Data\Ciudades.db");
        }
    }
}