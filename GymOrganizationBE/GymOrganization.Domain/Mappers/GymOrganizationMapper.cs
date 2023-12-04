using AutoMapper;
using GymOrganization.Domain.DTOs;
using GymOrganization.Domain.Extensions;
using GymOrganization.Domain.Requests;
using GymOrganization.Infrastructure.Entities;

namespace GymOrganization.Domain.Mappers;

public class GymOrganizationMapper : Profile
{
    public GymOrganizationMapper()
    {
        CreateMap<ApplicationUser, UserDto>()
            .ForMember(dto => dto.Age, src => src.MapFrom(e => e.DateOfBirth.GetAge()));

        CreateMap<CreateUserRequest, ApplicationUser>()
            .BeforeMap((_, d) => d.Id = Guid.NewGuid());

        CreateMap<CatalogItem, CatalogItemDto>();
    }
}