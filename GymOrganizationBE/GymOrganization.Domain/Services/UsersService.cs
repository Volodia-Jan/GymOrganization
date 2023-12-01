using AutoMapper;
using GymOrganization.Domain.DTOs;
using GymOrganization.Domain.Requests;
using GymOrganization.Domain.ServiceContracts;
using GymOrganization.Infrastructure.Entities;
using GymOrganization.Infrastructure.RepositoryContracts;
using GymOrganization.Infrastructure.Results;

namespace GymOrganization.Domain.Services;

public class UsersService : IUsersService
{
    private readonly IUsersRepository _usersRepository;
    private readonly IJwtService _jwtService;
    private readonly IMapper _mapper;

    public UsersService(IUsersRepository usersRepository, IMapper mapper, IJwtService jwtService)
    {
        _usersRepository = usersRepository;
        _mapper = mapper;
        _jwtService = jwtService;
    }

    public async Task<OperationResult<UserDto>> UpdateUserAsync(UpdateUserRequest updateUserRequest) =>
        await OperationResult<UserDto>.InvokeNotNull(async () =>
        {
            var result = await _usersRepository.UpdateUserAsync(_mapper.Map<ApplicationUser>(updateUserRequest));
            
            return _mapper.Map<UserDto>(result.Result);
        });

    public async Task<OperationResult<EmptyResult>> DeleteUserAsync(Guid userId)
    {
        return await OperationResult<EmptyResult>.InvokeNotNull(async () =>
        {
            var user = await _usersRepository.GetUserByIdAsync(userId);
            
            return (await _usersRepository.DeleteUserAsync(user.Result)).Result;
        });
    }

    public async Task<OperationResult<UserDto>> CreateUserAccountAsync(CreateUserRequest createUserRequest)
    {
        return await OperationResult<UserDto>.InvokeNotNull(async () =>
        {
            var result = await _usersRepository.CreateAsync(_mapper.Map<ApplicationUser>(createUserRequest),
                createUserRequest.Password);

            var dto = _mapper.Map<UserDto>(result.Result);
            // todo handle role
            dto.Token = _jwtService.GenerateJwt(dto.Id, dto.Email, string.Empty);

            return dto;
        });
    }
}