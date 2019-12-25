using System;
using System.Collections.Generic;
using System.Text;

namespace FatStudio.Dominio.Entidades
{
    class PlanoSaude : Entidade
    {
        public int Id { get; set; }
        public string NumeroCarteira { get; set; }
        public DateTime Validade { get; set; }
        public string TipoPlano { get; set; }

        public int OperadoraId { get; set; }
        public Operadora Operadora { get; set; }

        public int BeneficiarioId { get; set; }
        public Beneficiario Beneficiario { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(NumeroCarteira))
                AdicionarCritica("Número da Carteria, o preechimento é obrigatório");

            if (string.IsNullOrEmpty(Validade.ToString()))
                AdicionarCritica("Validade da Carteira, o preechimento é obrigatório");

            if (string.IsNullOrEmpty(NumeroCarteira))
                AdicionarCritica("Número da Carteria, o preechimento é obrigatório");

        }
    }
}
