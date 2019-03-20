using System.Collections.Generic;

namespace mvc1.Models
{
    public interface IRepository
    {
        IEnumerable<Produto> Produtos { get; }
    }
}