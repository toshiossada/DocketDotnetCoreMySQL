using System.Collections.Generic;

namespace mvc1.Models {
    public class TesteRepository : IRepository {
        private static Produto[] produtos = new Produto[] {
            new Produto { ProdutoId = 10, Nome = "Caneta", Categoria = "Material", Preco = 2 },
            new Produto { ProdutoId = 20, Nome = "Estojo", Categoria = "Material", Preco = 5 },
            new Produto { ProdutoId = 30, Nome = "Borracha", Categoria = "Material", Preco = 1 }
        };
        public IEnumerable<Produto> Produtos { get => produtos; }
    }
}