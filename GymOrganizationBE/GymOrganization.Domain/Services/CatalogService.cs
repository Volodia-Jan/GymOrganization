using AutoMapper;
using GymOrganization.Domain.DTOs;
using GymOrganization.Domain.ServiceContracts;
using GymOrganization.Infrastructure.RepositoryContracts;
using GymOrganization.Infrastructure.Results;

namespace GymOrganization.Domain.Services;

public class CatalogService : ICatalogService
{
    private readonly ICatalogRepository _catalogRepository;
    private readonly IMapper _mapper;

    public CatalogService(ICatalogRepository catalogRepository, IMapper mapper)
    {
        _catalogRepository = catalogRepository;
        _mapper = mapper;
    }

    public async Task<OperationResult<List<CatalogItemDto>>> GetCatalog()
    {
        return await OperationResult<List<CatalogItemDto>>.InvokeNotNull(async () =>
        {
            var catalog = await _catalogRepository.GetCatalog();

            return _mapper.Map<List<CatalogItemDto>>(catalog.Result);
        });
    }
}