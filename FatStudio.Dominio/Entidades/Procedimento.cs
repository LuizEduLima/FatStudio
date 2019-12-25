using System;
using System.Collections.Generic;
using System.Text;

namespace FatStudio.Dominio.Entidades
{
    class Procedimento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public long Ch { get; set; }
        public int Porte { get; set; }
        public int NumeroAuxiliar { get; set; }
        public float Filme { get; set; }
    }
}
