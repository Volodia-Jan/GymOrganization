using AutoMapper;
using GymOrganization.Domain.DTOs;
using GymOrganization.Domain.Requests;
using GymOrganization.Domain.ServiceContracts;
using GymOrganization.Infrastructure.RepositoryContracts;
using GymOrganization.Infrastructure.Results;

namespace GymOrganization.Domain.Services;

public class AccountsService : IAccountsService
{
    private readonly IAccountsRepository _accountsRepository;
    private readonly IUsersRepository _usersRepository;
    private readonly IJwtService _jwtService;
    private readonly IMapper _mapper;

    public AccountsService(IAccountsRepository accountsRepository, IMapper mapper, IJwtService jwtService, IUsersRepository usersRepository)
    {
        _accountsRepository = accountsRepository;
        _mapper = mapper;
        _jwtService = jwtService;
        _usersRepository = usersRepository;
    }

    public async Task<OperationResult<UserDto>> LoginAsync(LoginRequest loginRequest)
    {
        var result = await _accountsRepository.LoginAsync(loginRequest.Login, loginRequest.Password);
        var dto = _mapper.Map<UserDto>(result.Result);
        var roles = await _usersRepository.GetUserRoleByUserId(dto.Id);
        dto.Role = roles.Result.Name;
        dto.Token = _jwtService.GenerateJwt(dto.Id, dto.Email, dto.Role);
        return result.Status == ResultStatus.Success
            ? OperationResult<UserDto>.Success(dto)
            : OperationResult<UserDto>.Fail("Invalid login or password");
    }

    public async Task<OperationResult<EmptyResult>> LogoutAsync() => await _accountsRepository.LogoutAsync();
}