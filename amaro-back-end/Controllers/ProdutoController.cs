using amaro_back_end.Models;
using amaro_back_end.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace amaro_back_end.Controllers
{
    [ApiController]    
    //[Route("produtos")]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoRepository repository;

        public ProdutoController()
        {
            repository = new ProdutoRepository();
        }

        [HttpGet("produtos")]
        public ActionResult<List<Produtos>> GetProdutos([FromQuery] int offset = 0, [FromQuery] int limit = 0)
        {
            var produtos = repository.GetProdutos(offset, limit);

            return Ok(new 
            {
                Offset = offset,
                Limit = limit,
                Count = produtos.Count,
                Produtos = produtos
            });
        }

        [HttpGet("produto/{controleexterno}")]
        public ActionResult<Produtos> GetProdutoByControleExterno(int controleexterno)
        {
            var produto = repository.GetProdutoByControleExterno(controleexterno);
            return produto;
        }
    }
}
