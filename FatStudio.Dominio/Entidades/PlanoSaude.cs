using System;
using System.Collections.Generic;
using System.Text;

namespace FatStudio.Dominio.Entidades
{
    class PlanoSaude
    {
        public int Id { get; set; }
        public string NumeroCarteira { get; set; }
        public DateTime Validade { get; set; }
        public string TipoPlano { get; set; }

        public int OperadoraId { get; set; }
        public int BeneficiarioId { get; set; }

    }
}
