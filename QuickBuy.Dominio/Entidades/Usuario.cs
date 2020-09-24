using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    /// <summary>
    /// classe responsável pela definição das propriedades da entidade Usuario.
    /// </summary>
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
