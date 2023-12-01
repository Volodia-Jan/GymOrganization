using GymOrganization.Domain.DTOs;
using GymOrganization.Domain.Requests;
using GymOrganization.Domain.ServiceContracts;
using GymOrganization.Infrastructure.Results;
using Microsoft.AspNetCore.Mvc;
using EmptyResult = GymOrganization.Infrastructure.Results.EmptyResult;

namespace GymOrganization.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUsersService _usersService;

    public UsersController(IUsersService usersService)
    {
        _usersService = usersService;
    }

    [HttpPost]
    public async Task<OperationResult<UserDto>> CreateUser(CreateUserRequest createUserRequest) =>
        await _usersService.CreateUserAccountAsync(createUserRequest);

    [HttpPatch]
    public async Task<OperationResult<UserDto>> UpdateUser(UpdateUserRequest updateUserRequest) =>
        await _usersService.UpdateUserAsync(updateUserRequest);

    [HttpDelete("{userId}")]
    public async Task<OperationResult<EmptyResult>> DeleteUser(Guid userId) =>
        await _usersService.DeleteUserAsync(userId);
}