using EmprestimoLivro.Application.DTOs;
using EmprestimoLivros.Domain.Entities;
using AutoMapper;

namespace EmprestimoLivro.Application.Mappings
{
    internal class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Cliente, ClienteDTO>().ReverseMap();
        }
    }
}
