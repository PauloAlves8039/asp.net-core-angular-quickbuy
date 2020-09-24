namespace QuickBuy.Dominio.Entidades
{
    /// <summary>
    /// Classe responsável pela definição das propriedades referentes a entidade item de pedido.
    /// </summary>
    public class ItemPedido
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
    }
}
