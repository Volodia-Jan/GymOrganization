using GymOrganization.Domain.DTOs;
using GymOrganization.Domain.ServiceContracts;
using GymOrganization.Infrastructure.Results;
using Microsoft.AspNetCore.Mvc;

namespace GymOrganization.Controllers;

[ApiController]
[Route("[controller]")]
public class CatalogController : ControllerBase
{
    private readonly ICatalogService _catalogService;

    public CatalogController(ICatalogService catalogService)
    {
        _catalogService = catalogService;
    }

    [HttpGet]
    public async Task<ActionResult<OperationResult<List<CatalogItemDto>>>> GetCatalog() =>
        await _catalogService.GetCatalog();
}