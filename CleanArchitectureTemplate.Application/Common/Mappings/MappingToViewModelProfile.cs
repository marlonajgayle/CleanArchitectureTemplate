using AutoMapper;
using CleanArchitectureTemplate.Application.Clients.Commands.CreateClient;
using CleanArchitectureTemplate.Domain.Entities;

namespace CleanArchitectureTemplate.Application.Common.Mappings
{
    public class MappingToViewModelProfile : Profile
    {
        public MappingToViewModelProfile()
        {
            CreateMap<Client, ClientViewModel>();
        }
    }
}
