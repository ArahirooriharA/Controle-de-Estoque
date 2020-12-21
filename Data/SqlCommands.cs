using controledeestoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controledeestoque.Data
{
    public class SqlCommands
    {
        private readonly EstoqueContext _context;
        public SqlCommands(EstoqueContext context)
        {
            _context = context;
        }

        public void CreateProduto(Produto cmd)
        {
            if (cmd == null)
                throw new ArgumentNullException(nameof(cmd));

            _context.Add(cmd);
        }

        public void DeleteProduto(Produto cmd)
        {
            if (cmd == null)
                throw new ArgumentNullException(nameof(cmd));

            _context.Produtos.Remove(cmd);
        }
        public Produto GetProdutoById(int id)
        {
            return _context.Produtos.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Produto> GetAllProdutos()
        {
            return _context.Produtos.ToList();
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}
