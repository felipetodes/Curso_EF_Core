﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkCare.Domain;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.Data
{
    public class FootballLeageDbContext : DbContext
    {


        public DbSet<Team> Teams { get; set; }

        public DbSet<Coach> Coaches { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //Usando SLQ Server
            //    optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=FootballLeage_EfCore; Encrypt=False");
            optionsBuilder.UseSqlServer($"Data Source=FootballLeage_Efcore.db");
        }
    }
}