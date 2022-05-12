using AB.Locacao.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB.Locacao.Data.Mappings
{
   public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> Builder)
        {
            Builder.Property(x => x.Id).IsRequired();
            Builder.Property(x => x.Nome).HasMaxLength(100).IsRequired();
            Builder.Property(x => x.Cpf).HasMaxLength(25).IsRequired();
            Builder.Property(x => x.Rg).HasMaxLength(25).IsRequired();
            Builder.Property(x => x.Telefone).HasMaxLength(25).IsRequired();
            Builder.Property(x => x.Email).HasMaxLength(100);
            Builder.Property(x => x.Nacionalidade).HasMaxLength(100).IsRequired();
            Builder.Property(x => x.EstadoCivil).HasMaxLength(100).IsRequired();
            Builder.Property(x => x.Profissao).HasMaxLength(100).IsRequired();

        }
    }

}
