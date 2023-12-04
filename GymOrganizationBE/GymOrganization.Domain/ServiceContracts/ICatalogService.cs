using GymOrganization.Domain.DTOs;
using GymOrganization.Infrastructure.Results;

namespace GymOrganization.Domain.ServiceContracts;

public interface ICatalogService
{
    Task<OperationResult<List<CatalogItemDto>>> GetCatalog();
}