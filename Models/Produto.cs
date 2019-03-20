using System;

namespace mvc1.Models {
    public class Produto {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public decimal Preco { get; set; }
        public Produto (string nome = null, string categoria = null, decimal preco = 0) {
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
        }
    }
}