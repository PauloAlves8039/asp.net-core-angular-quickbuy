using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickBuy.Web.Controllers
{
    /// <summary>
    /// Controlador responsável pelas ações referentes a entidade Produto.
    /// </summary>
    [Route("api/[Controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }
    }
}
