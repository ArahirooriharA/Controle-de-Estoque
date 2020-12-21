using controledeestoque.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controledeestoque.Data
{
    public class EstoqueContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = xxx; Initial Catalog = Estoque; Integrated Security = True;");
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
