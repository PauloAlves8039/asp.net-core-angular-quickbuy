using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    /// <summary>
    /// Classe abstrata responsável pela validação das entidades. 
    /// </summary>
    public abstract class Entidade
    {
        private List<string> _mensagensValidacao { get; set; }
        private List<string> mensagemValidacao 
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); } 
        }

        /// <summary>
        /// Método responsável por limpar as mensagens de validação.
        /// </summary>
        protected void LimparMensagensValidacao() 
        {
            mensagemValidacao.Clear();
        }

        /// <summary>
        /// Método responsável por adicionar mensagens críticas.
        /// </summary>
        /// <param name="mensagem"></param>
        protected void AdicionarCritica(string mensagem) 
        {
            mensagemValidacao.Add(mensagem);
        }
        
        /// <summary>
        /// Método abstrato responsável pela exibição de mensagens de validação.
        /// </summary>
        public abstract void Validate();

        protected bool EhValido 
        {
            get { return !mensagemValidacao.Any(); }
        }
    }
}
