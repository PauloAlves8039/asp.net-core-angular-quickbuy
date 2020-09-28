using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    /// <summary>
    /// Classe responsável pelas configurações de mapeamento com o banco de dados referente a entidade Produto.
    /// </summary>
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        /// <summary>
        /// Método responsável por atribuir as configuração das propriedade da entidade Produto.
        /// </summary>
        /// <param name="builder">Parâmetro responsável por definir configurações das propriedades do Produto.</param>
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(400);

            builder
                .Property(p => p.Preco)
                .IsRequired();
        }
    }
}
