using System;
using System.Collections.Generic;
using System.Text;

namespace FatStudio.Dominio.Entidades
{
    public class Procedimento : Entidade
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public long Ch { get; set; }
        public int Porte { get; set; }
        public int NumeroAuxiliar { get; set; }
        public float Filme { get; set; }

        public override void Validate()
        {

            if (string.IsNullOrEmpty(Descricao))
                AdicionarCritica("Descrição, o preechimento é obrigatório");
        }
    }
}
