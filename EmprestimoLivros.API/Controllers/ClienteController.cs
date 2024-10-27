using EmprestimoLivro.Application.DTOs;
using EmprestimoLivro.Application.Interfaces;
using EmprestimoLivro.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmprestimoLivros.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        public async Task<ActionResult> Incluir(ClienteDTO clienteDTO)
        {
            var result = await _clienteService.Incluir(clienteDTO);
            return result == null ? BadRequest("Ocorreu um erro ao incluir cliente") : Ok("Cliente incluído com sucesso.");
        }

        [HttpPut]
        public async Task<ActionResult> Alterar(ClienteDTO clienteDTO)
        {
            var result = await _clienteService.Alterar(clienteDTO);
            return result == null ? BadRequest("Ocorreu um erro ao alterar cliente") : Ok("Cliente alterado com sucesso.");
        }

        [HttpDelete]
        public async Task<ActionResult> Alterar(int id)
        {
            var result = await _clienteService.Excluir(id);
            return result == null ? BadRequest("Ocorreu um erro ao excluir cliente") : Ok("Cliente excluído com sucesso.");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Selecionar(int id)
        {
            var result = await _clienteService.SelecionarAsync(id);
            return result == null ? NotFound("Cliente não encontrado") : Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult> SelecionarTodos()
        {
            var result = await _clienteService.SelecionarTodosAsync();
            return Ok(result);
        }
    }
}
