using EmprestimoLivro.Application.DTOs;

namespace EmprestimoLivro.Application.Interfaces
{
    public interface IClienteService
    {
        Task<ClienteDTO> Incluir(ClienteDTO cliente);
        Task<ClienteDTO> Alterar(ClienteDTO cliente);
        Task<ClienteDTO> Excluir(int id);
        Task<ClienteDTO> SelecionarAsync(int id);
        Task<IEnumerable<ClienteDTO>> SelecionarTodosAsync();
    }
}
