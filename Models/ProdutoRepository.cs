using System.Collections.Generic;

namespace mvc1.Models {
    public class ProdutoRepository : IRepository {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Produto> Produtos { get => _context.Produtos; }
    }
}