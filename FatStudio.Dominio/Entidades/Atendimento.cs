using FatStudio.Dominio.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace FatStudio.Dominio.Entidades
{
    class Atendimento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public TipoAtendimentoEnum TipoAtendimento { get; set; }
        public string NumeroGuiaNoPrestador { get; set; }
        public string RegistroAns { get; set; }
        public string NumeroGuiaSolicitacaoInternacao { get; set; }
        public string Senha { get; set; }
        public string NumeroDaGuiaAtribuidaPleaOperadora { get; set; }

        
        public int BeneficiarioId { get; set; }
        public Beneficiario Beneficiario { get; set; }

        public int OperadoraId { get; set; }
        public Operadora Operadora { get; set; }

        public DateTime DataInicioFaturamento { get; set; }
        public DateTime DataFimFaturaento { get; set; }

        public List<ItemAtendimento> Items { get; set; } = new List<ItemAtendimento>();




    }
}
