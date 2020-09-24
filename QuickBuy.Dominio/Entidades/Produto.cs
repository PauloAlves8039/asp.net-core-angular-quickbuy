namespace QuickBuy.Dominio.Entidades
{
    /// <summary>
    /// Class responsável pela definição das propriedades da entidade Produto.
    /// </summary>
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

    }
}
