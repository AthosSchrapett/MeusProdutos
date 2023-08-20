using MeusProdutos.Models.DTOs.Update;
using MeusProdutos.Models.Entities;
using MeusProdutos.Models.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace MeusProdutos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoService? _produtoService;

        public ProdutosController(IProdutoService? produtoService) => _produtoService = produtoService;

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<Produto>? produtos = _produtoService?.GetAll();

            if(!produtos.Any())
                return NotFound();

            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Produto produto = _produtoService?.GetById(id);

            if (produto is null)
                return NotFound();

            return Ok(produto);
        }

        [HttpPost]
        public IActionResult Post(Produto produto)
        {
            _produtoService.Add(produto);

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(ProdutoUpdateDTO produtoUpdateDTO)
        {
            _produtoService.Update(produtoUpdateDTO);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _produtoService.Delete(id);

            return Ok();
        }
    }
}
