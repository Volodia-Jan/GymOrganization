using GymOrganization.Domain.DTOs;
using GymOrganization.Domain.Requests;
using GymOrganization.Domain.ServiceContracts;
using GymOrganization.Infrastructure.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EmptyResult = GymOrganization.Infrastructure.Results.EmptyResult;

namespace GymOrganization.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountsController : ControllerBase
{
    private readonly IAccountsService _accountsService;

    public AccountsController(IAccountsService accountsService)
    {
        _accountsService = accountsService;
    }

    [HttpPost("[action]")]
    public async Task<OperationResult<UserDto>> Login(LoginRequest loginRequest) =>
        await _accountsService.LoginAsync(loginRequest);

    [HttpPost("[action]")]
    [Authorize]
    public async Task<OperationResult<EmptyResult>> Logout() =>
        await _accountsService.LogoutAsync();
}