using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject.Entity
{
    public class BancoContext:IdentityDbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options): base(options)
        {

        }

        public DbSet<Carro> Carros { get; set; }
        public DbSet<Concessionaria> Concessionarias { get; set; }


    }
}
