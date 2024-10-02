using EmprestimoLivro.Application.DTOs;
using EmprestimoLivros.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
