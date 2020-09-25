namespace QuickBuy.Dominio.Entidades
{
    /// <summary>
    /// Class responsável pela definição das propriedades da entidade Produto.
    /// </summary>
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome)) 
            {
                AdicionarCritica("Nome do produto não foi informado!");
            }

            if (string.IsNullOrEmpty(Descricao)) 
            {
                AdicionarCritica("Descrição não foi informada!");
            }
        }
    }
}
