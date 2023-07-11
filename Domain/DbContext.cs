﻿using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class UrlShorteningDbContext : DbContext
    {
        public DbSet<UrlShortening> UrlShortening { get; set; }

        public UrlShorteningDbContext(DbContextOptions<UrlShorteningDbContext> options)
          : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase("exampleDatabase");
        }
    }
}
