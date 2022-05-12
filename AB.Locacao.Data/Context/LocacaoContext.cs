using AB.Locacao.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB.Locacao.Data.Context
{
    public class LocacaoContext: DbContext
    {
        public LocacaoContext(DbContextOptions<LocacaoContext> option)
            : base(option) { }

        #region "DBSets"

        public DbSet<User> Users { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }

        #endregion

    }
}
