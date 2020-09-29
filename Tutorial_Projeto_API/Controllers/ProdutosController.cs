
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System;
using Domain.Entities;
using Modelo.Service.Services;

namespace Tutorial_Projeto_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {

        private readonly ProdutosService _ProdutosService;

        public ProdutosController(ProdutosService ProdutosService)
        {
            _ProdutosService = ProdutosService;
        }

        [HttpGet]
        public ActionResult<List<Produto>> Get() => _ProdutosService.Get();

        [HttpGet("{id}")]
        public ActionResult<Produto> Get(string id)
        {
            var Produto = _ProdutosService.Get(id);

            if (Produto == null)
            {
                return NotFound();
            }

            return Produto;
        }

        [HttpPost]
        public ActionResult<Produto> Create(Produto produto)
        {
            _ProdutosService.Create(produto);

            return CreatedAtRoute("getProduto", new { id = produto.Id.ToString() }, produto);
        }

        [HttpPut("{codigo}")]
        public IActionResult Update(string codigo, Produto produtoIn)
        {
            var prod = _ProdutosService.Get(codigo);

            if (prod == null)
            {
                return NotFound();
            }

            _ProdutosService.Update(codigo, produtoIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var book = _ProdutosService.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            _ProdutosService.Remove(book.Id);

            return NoContent();
        }
    }
}