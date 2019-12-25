using FatStudio.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FatStudio.Repositorio.Repositorios.Config
{
    class FatStudioContexto:DbContext
    {
        
        public DbSet<Atendimento>Atendimentos { get; set; }
        public DbSet<Beneficiario> Beneficiarios { get; set; }
        public DbSet<ItemAtendimento> ItemAtendimentos { get; set; }
        public DbSet<Operadora> Operadoras { get; set; }
        public DbSet<PlanoSaude> PlanoSaudes { get; set; }
        public DbSet<Procedimento> Procedimentos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ViaDeAcesso> ViaDeAcessos { get; set; }

    }
}
