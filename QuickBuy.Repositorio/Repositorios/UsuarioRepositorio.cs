﻿using QuickBuy.Dominio.Contratos;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Repositorios
{
    /// <summary>
    /// Classe de repositório base para regra de negócio referente a entidade Usuario.
    /// </summary>
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio()
        {

        }
    }
}
