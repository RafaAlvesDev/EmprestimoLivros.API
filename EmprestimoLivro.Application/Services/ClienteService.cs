using AutoMapper;
using EmprestimoLivro.Application.DTOs;
using EmprestimoLivro.Application.Interfaces;
using EmprestimoLivros.Domain.Entities;
using EmprestimoLivros.Domain.Interfaces;

namespace EmprestimoLivro.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
           _mapper = mapper;
        }

        public async Task<ClienteDTO> Alterar(ClienteDTO clienteDTO)
        {
            var cliente = _mapper.Map<Cliente>(clienteDTO);
            var clienteAlterado = await _clienteRepository.Alterar(cliente);
            return _mapper.Map<ClienteDTO>(clienteAlterado);
        }

        public async Task<ClienteDTO> Excluir(int id)
        {
            var clienteExcluido = await _clienteRepository.Excluir(id);
            return _mapper.Map<ClienteDTO>(clienteExcluido);
        }

        public async Task<ClienteDTO> Incluir(ClienteDTO clienteDTO)
        {
            var cliente = _mapper.Map<Cliente>(clienteDTO);
            var clienteIncluir = await _clienteRepository.Incluir(cliente);
            return _mapper.Map<ClienteDTO>(clienteIncluir);
        }

        public async Task<ClienteDTO> SelecionarAsync(int id)
        {
            var clienteSelecionar = await _clienteRepository.SelecionarAsync(id);
            return _mapper.Map<ClienteDTO>(clienteSelecionar);
        }

        public async Task<IEnumerable<ClienteDTO>> SelecionarTodosAsync()
        {
            var clienteSelecionar = await _clienteRepository.SelecionarTodosAsync();
            return _mapper.Map<IEnumerable<ClienteDTO>>(clienteSelecionar);
        }
    }
}
