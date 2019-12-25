using System;
using System.Collections.Generic;
using System.Text;
using FatStudio.Dominio.Entidades.Enums;
namespace FatStudio.Dominio.Entidades
{
    public class ViaDeAcesso : Entidade
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Porcentagem { get; set; }

        public bool ViaUnica {
            get { return Id == (int)TipoViaDeAcessoEnum.ViaUnica; }
        }
        public bool MesmaVia {
            get {
                return Id == (int)TipoViaDeAcessoEnum.MesmaVia;
            }
        }
        public bool ViaDiferente {
            get {
                return Id == (int)TipoViaDeAcessoEnum.ViaDiferente;
            }
        }

        public override void Validate()
        {

            if (string.IsNullOrEmpty(Descricao))
                AdicionarCritica("Descrição, o preechimento é obrigatório");
        }
    }
}
