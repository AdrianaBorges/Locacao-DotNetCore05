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
    public class UserMap: IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> Builder)
        {
            Builder.Property(x => x.Id).IsRequired();
            Builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            
        }
    }
}
