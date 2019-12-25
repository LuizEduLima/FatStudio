using FatStudio.Dominio.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace FatStudio.Dominio.Entidades
{
    class ItemAtendimento : Entidade
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public DateTime HoraInicial { get; set; }
        public DateTime HoraFinal { get; set; }

        public int ProcedimentoId { get; set; }
        public Procedimento Procedimento { get; set; }
        public int Tabela { get; set; }

        public int ViaDeAcessoId { get; set; }
        public ViaDeAcesso ViaDeAcesso { get; set; }
        
        public float Acrescimo { get; set; }

        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (Data == null)
                AdicionarCritica("A Data é de preenchimento obrigatório");
        }
    }
}
