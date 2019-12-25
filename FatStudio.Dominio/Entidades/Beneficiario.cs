using System;
using System.Collections.Generic;
using System.Text;

namespace FatStudio.Dominio.Entidades
{
    class Beneficiario : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime dateTime { get; set; }
        public char Sexo { get; set; }
        public string Identidade { get; set; }
        public string CPF { get; set; }

        /// <summary>
        /// Um beneficiário pode ter nenhum ou mais de um Plano de Saúde.
        /// 
        /// </summary>
        public ICollection<PlanoSaude> Planos { get; set; } = new List<PlanoSaude>();

        public override void Validate()
        {
            if (Nome == string.Empty) 
            AdicionarCritica("O Campo Nome é de preenchimento obrigatório.");

            if (Sexo == Convert.ToChar(string.Empty))
                AdicionarCritica("O Campo Sexo é de preenchimento obrigatório.");

            if (Identidade == string.Empty)
                AdicionarCritica("O Campo Identidade é de preenchimento obrigatório.");

            if (CPF == string.Empty)
                AdicionarCritica("O Campo CPF é de preenchimento obrigatório.");

        }

       
    }
}
