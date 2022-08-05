using DevIO.Business.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DevIO.Business.Core.Data
{
    public interface IRepository<TEndity> : IDisposable where TEndity : Entity
    {
        Task Adicionar(TEndity entity);
        Task<TEndity> ObterPorId(Guid id);
        Task<List<TEndity>> ObterTodos();
        Task Atualizar(TEndity entity);
        Task Remover(TEndity entity);
        Task<IEnumerable<TEndity>> Buscar(Expression<Func<TEndity, bool>> predicate);
        Task<int> SaveChanges();
    }
}
