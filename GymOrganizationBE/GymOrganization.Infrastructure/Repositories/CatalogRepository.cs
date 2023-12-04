using GymOrganization.Infrastructure.ApplicationDbContexts;
using GymOrganization.Infrastructure.Entities;
using GymOrganization.Infrastructure.RepositoryContracts;
using GymOrganization.Infrastructure.Results;
using Microsoft.EntityFrameworkCore;

namespace GymOrganization.Infrastructure.Repositories;

public class CatalogRepository : ICatalogRepository
{
    private readonly GymOrganizationDbContext _db;

    public CatalogRepository(GymOrganizationDbContext db)
    {
        _db = db;
    }

    public async Task<OperationResult<List<CatalogItem>>> GetCatalog() => 
        await OperationResult<List<CatalogItem>>.Invoke(async () => await _db.CatalogItems.ToListAsync());
}