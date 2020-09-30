using QuickBuy.Dominio.Contratos;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Repositorio.Contexto;

namespace QuickBuy.Repositorio.Repositorios
{
    /// <summary>
    /// Classe de repositório base para regra de negócio referente a entidade Produto.
    /// </summary>
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(QuickBuyContexto quickBuyContexto) : base(quickBuyContexto)
        {
        }
    }
}
