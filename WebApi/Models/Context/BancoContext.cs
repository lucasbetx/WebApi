using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WebApi.Models.Entities;
using WebApi.Models.Mappings;

namespace WebApi.Models.Context
{
    public class BancoContext : DbContext
    {
        public DbSet<Livro> Livros { get; set; }
        //public DbSet<Autor> Autores { get; set; }
        public DbSet<Editora> Editoras { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //modelBuilder.Configurations.Add(new AutorMapping());
        }
    }
}