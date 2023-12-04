using System.Threading.Tasks;
using AutoMapper;
using GymOrganization.Domain.DTOs;
using GymOrganization.Domain.Requests;
using GymOrganization.Domain.ServiceContracts;
using GymOrganization.Infrastructure.Entities;
using GymOrganization.Infrastructure.RepositoryContracts;
using GymOrganization.Infrastructure.Results;

namespace GymOrganization.Domain.Services;

public class AccountsService : IAccountsService
{
    private readonly IAccountsRepository _accountsRepository;
    private readonly IJwtService _jwtService;
    private readonly IMapper _mapper;

    public AccountsService(IAccountsRepository accountsRepository, IMapper mapper, IJwtService jwtService)
    {
        _accountsRepository = accountsRepository;
        _mapper = mapper;
        _jwtService = jwtService;
    }

    public async Task<OperationResult<UserDto>> LoginAsync(LoginRequest loginRequest)
    {
        var result = await _accountsRepository.LoginAsync(loginRequest.Login, loginRequest.Password);
        var dto = _mapper.Map<UserDto>(result.Result);
        // todo handle roles
        dto.Token = _jwtService.GenerateJwt(dto.Id, dto.Email, string.Empty);
        
        return result.Status == ResultStatus.Success
            ? OperationResult<UserDto>.Success(dto)
            : OperationResult<UserDto>.Fail("Invalid login or password");
    }

    public async Task<OperationResult<EmptyResult>> LogoutAsync() => await _accountsRepository.LogoutAsync();
}