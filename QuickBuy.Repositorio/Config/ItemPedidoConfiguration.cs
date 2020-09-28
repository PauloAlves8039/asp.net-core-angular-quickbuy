using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    /// <summary>
    /// Classe responsável pelas configurações de mapeamento com o banco de dados referente a entidade ItemPedido.
    /// </summary>
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
