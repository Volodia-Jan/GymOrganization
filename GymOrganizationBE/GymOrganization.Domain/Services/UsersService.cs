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
            var user = await _usersRepository.GetUserByIdAsync(updateUserRequest.Id);
            user.Result.Email = updateUserRequest.Email;
            user.Result.UserName = updateUserRequest.Email;
            user.Result.FirstName = updateUserRequest.FirstName;
            user.Result.LastName = updateUserRequest.LastName;
            user.Result.DateOfBirth = updateUserRequest.DateOfBirth;
            var result = await _usersRepository.UpdateUserAsync(user.Result);
            
            var dto = _mapper.Map<UserDto>(result.Result);
            var userRole = await _usersRepository.GetUserRoleByUserId(dto.Id);
            dto.Role = userRole.Result.Name;

            return dto;
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
            await _usersRepository.AddToRoleAsync(result.Result!.Id, createUserRequest.Role);
            
            var role = await _usersRepository.GetUserRoleByUserId(result.Result.Id);
            var dto = _mapper.Map<UserDto>(result.Result);
            dto.Role = role.Result.Name;
            dto.Token = _jwtService.GenerateJwt(dto.Id, dto.Email, dto.Role);

            return dto;
        });
    }
}