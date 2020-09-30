using QuickBuy.Dominio.Contratos;
using QuickBuy.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Repositorio.Repositorios
{
    /// <summary>
    /// Classe de repositório base para implementação de métodos referentes a regra de negócio da aplicação.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly QuickBuyContexto QuickBuyContexto;

        public BaseRepositorio(QuickBuyContexto quickBuyContexto)
        {
            QuickBuyContexto = quickBuyContexto;
        }

        public void Adicionar(TEntity entity)
        {
            QuickBuyContexto.Set<TEntity>().Add(entity);
        }

        public void Atualizar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return QuickBuyContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            QuickBuyContexto.Dispose();
        }
    }
}
