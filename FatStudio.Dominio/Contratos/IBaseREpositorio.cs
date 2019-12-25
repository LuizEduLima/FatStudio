﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FatStudio.Dominio.Contratos
{
    public interface IBaseREpositorio<TEntity>:IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);
    }
}
