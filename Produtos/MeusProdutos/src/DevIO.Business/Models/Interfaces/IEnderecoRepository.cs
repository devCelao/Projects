using DevIO.Business.Core.Data;
using System;
using System.Threading.Tasks;

namespace DevIO.Business.Models.Fornecedores
{
    public interface IEnderecoRepository : IRepository<Fornecedor>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);

    }
}
