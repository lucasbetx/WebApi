using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebApi.Models.Entities;

namespace WebApi.Models.Mappings
{
    public class AutorMapping : EntityTypeConfiguration<Autor>
    {
        public AutorMapping()
        {
            ToTable("tbl_autores");
            HasKey(a => a.Id);
            Property(a => a.Nome).IsRequired().HasMaxLength(100);
            Property(a => a.Email).IsRequired();
            Property(a => a.Observacao).IsRequired().HasMaxLength(2000);
            Property(a => a.QuantidadeLivrosVendidos).HasColumnName("qntdLivrosVendidos");
        }
    }
}