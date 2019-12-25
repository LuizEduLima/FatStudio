using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FatStudio.Dominio.Entidades
{
    public abstract class Entidade
    {
      private List<string> _mensagemValidacao { get; set; }

        private List<string> MensagemValidacao {
            get {
                return _mensagemValidacao ?? (_mensagemValidacao = new List<string>());
            }
        }

        protected void LimparMensagemValidacao()
        {
            MensagemValidacao.Clear();            
        }

        protected void AdicionarCritica(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }
        public abstract void Validate();
        /// <summary>
        /// Propriedade que irá verificar se as entidades estão válida se caso a lista estiver
        /// vazia
        /// </summary>
        protected bool EhValido {
            get { return !MensagemValidacao.Any(); }
        }
    }
}
