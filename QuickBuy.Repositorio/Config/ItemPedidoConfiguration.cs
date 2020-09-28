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
        /// <summary>
        /// Método responsável por atribuir as configuração das propriedade da entidade ItemPedido.
        /// </summary>
        /// <param name="builder">Parâmetro responsável por definir configurações das propriedades do ItemPedido.</param>
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(i => i.Id);

            builder
                .Property(i => i.ProdutoId)
                .IsRequired();

            builder
                .Property(i => i.Quantidade)
                .IsRequired();
        }
    }
}
