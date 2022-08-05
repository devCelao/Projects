using DevIO.Business.Core.Data;
using DevIO.Business.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevIO.Business.Models.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId);
        Task<IEnumerable<Produto>> ObterProdutosFornecedores();
        Task<Produto> ObterProdutoFornecedor(Guid id);
    }
}
