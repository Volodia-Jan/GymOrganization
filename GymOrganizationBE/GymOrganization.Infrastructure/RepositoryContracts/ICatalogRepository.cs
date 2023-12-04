using GymOrganization.Infrastructure.Entities;
using GymOrganization.Infrastructure.Results;

namespace GymOrganization.Infrastructure.RepositoryContracts;

public interface ICatalogRepository
{
    Task<OperationResult<List<CatalogItem>>> GetCatalog();
}