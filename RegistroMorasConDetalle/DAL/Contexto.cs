﻿using Microsoft.EntityFrameworkCore;
using RegistroMorasConDetalle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroMorasConDetalle.DAL
{
    public class Contexto:DbContext
    {
        public DbSet<Prestamos> Prestamos { get; set; }
        public DbSet<Moras> Moras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = C:\Databases\Prestamos.db");
        }
    }
}
