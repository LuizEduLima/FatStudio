using FatStudio.Dominio.Contratos;
using FatStudio.Dominio.Entidades;
using FatStudio.Repositorio.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace FatStudio.Repositorio.Repositorios
{
    public class UsuarioRepositorio:BaseRepositorio<Usuario>,IUsuarioRepositorio    
    {
        public UsuarioRepositorio()
        {

        }
    }
}
