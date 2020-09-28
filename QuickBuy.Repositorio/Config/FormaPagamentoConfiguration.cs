using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.ObjetoDeValor;

namespace QuickBuy.Repositorio.Config
{
    /// <summary>
    /// Classe responsável pelas configurações de mapeamento com o banco de dados referente ao objeto de valor FormaPagamento.
    /// </summary>
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        /// <summary>
        /// Método responsável por atribuir as configuração das propriedade do objeto de valor FormaPagamento.
        /// </summary>
        /// <param name="builder">Parâmetro responsável por definir configurações do objeto de valor FormaPagamento.</param>
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(f => f.Id);
            builder
                .Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(f => f.Descricao)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
