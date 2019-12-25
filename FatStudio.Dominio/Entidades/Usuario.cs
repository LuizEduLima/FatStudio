using System;
using System.Collections.Generic;
using System.Text;

namespace FatStudio.Dominio.Entidades
{
    class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        public override void Validate()
        {

            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Email, o preechimento é obrigatório");

            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Senha, o preechimento é obrigatório");

            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Nome, o preechimento é obrigatório");

            if (string.IsNullOrEmpty(SobreNome))
                AdicionarCritica("Sobre Nome, o preechimento é obrigatório");
        }
    }
}
