using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TreinoMVC.Models;

namespace TreinoMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Categoria> Categorias {get; set;}
        public DbSet<Contato> Contatos {get; set;}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
