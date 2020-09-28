using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    /// <summary>
    /// Classe responsável pelas configurações de mapeamento com o banco de dados referente a entidade Usuario.
    /// </summary>
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        /// <summary>
        /// Método responsável por atribuir as configuração das propriedade da entidade Usuario.
        /// </summary>
        /// <param name="builder">Parâmetro responsável por definir configurações das propriedades do Usuario.</param>
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);
            
            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(400);

            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.SobreNome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuario);
        }
    }
}
