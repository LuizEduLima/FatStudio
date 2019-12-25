using System;
using System.Collections.Generic;
using System.Text;

namespace FatStudio.Dominio.Entidades
{
    class Beneficiario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime dateTime { get; set; }
        public int Sexo { get; set; }
        public string Identidade { get; set; }
        public string CPF { get; set; }

        /// <summary>
        /// Um beneficiário pode ter nenhum ou mais de um Plano de Saúde.
        /// 
        /// </summary>
        public ICollection<PlanoSaude> Planos { get; set; } = new List<PlanoSaude>();



    }
}
