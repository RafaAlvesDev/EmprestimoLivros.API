using EmprestimoLivro.Application.DTOs;
using EmprestimoLivros.Domain.Entities;
using AutoMapper;

namespace EmprestimoLivro.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Cliente, ClienteDTO>().ReverseMap();
        }
    }
}
