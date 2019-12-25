using System;
using System.Collections.Generic;
using System.Text;

namespace FatStudio.Dominio.Entidades
{
    class Operadora : Entidade
    {
        public int Id { get; set; }
        public string RegistroANS { get; set; }
        public string CNPJ { get; set; }
        public string Nome { get; set; }
        public string CodigoCNES { get; set; }
        public string Logotipo { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(RegistroANS))
                AdicionarCritica("O Registro ANS, o preenchimento é ogrigatório");
            
            if (string.IsNullOrEmpty(CNPJ))
                AdicionarCritica("O CNPJ, o preenchimento é ogrigatório");
            
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O Nome, o preenchimento é ogrigatório");
            
            if (string.IsNullOrEmpty(CodigoCNES))
                AdicionarCritica("O Codigo CNES, o preenchimento é ogrigatório");
        
        
        }

    }
}
