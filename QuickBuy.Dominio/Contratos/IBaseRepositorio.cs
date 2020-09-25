using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Contratos
{
    /// <summary>
    /// Interface base responsável pelos métodos referentes a regra de negócio da aplicação.
    /// </summary>
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        /// <summary>
        /// Método responsável pela adicição de registro entidade.
        /// </summary>
        /// <param name="entity">Representa a adição de registro da uma entidade.</param>
        void Adicionar(TEntity entity);

        /// <summary>
        /// Método responsável por obter registro de uma entidade por id.
        /// </summary>
        /// <param name="id">Responsável pela busca de uma entidade.</param>
        /// <returns>Entidade selecionada por id.</returns>
        TEntity ObterPorId(int id);
        
        /// <summary>
        /// Método responsável pela listagem de registros da entidade.
        /// </summary>
        /// <returns>Lista de registros da entidade.</returns>
        IEnumerable<TEntity> ObterTodos();

        /// <summary>
        /// Método responsável atualizar registro de uma entidade.
        /// </summary>
        /// <param name="entity">Representa a atualização de registro da entidade.</param>
        void Atualizar(TEntity entity);

        /// <summary>
        /// Método para remover registro de uma entidade.
        /// </summary>
        /// <param name="entity">Representa a exclusão de registro da entidade.</param>
        void Remover(TEntity entity);
    }
}
