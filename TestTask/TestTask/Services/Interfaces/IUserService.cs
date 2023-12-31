﻿using TestApplication.DTO;
using TestApplication.Models;

namespace TestApplication.Services;

public interface IUserService
{
    public Task CreateUserAsync(CreateUserRequest request);
    public Task AddRoleToUserAsync(AddUserRoleRequest roleRequest);
    public Task<UserGetResponse> GetUser(Guid userId);
    //public Task<List<UserGetResponse>> GetUsers();
    public Task<List<UserGetResponse>> GetUsers(int pageNumber, int pageSize);

    public Task DeleteUserAsync(Guid userId);
    public Task EditUserAsync(EditUserRequest request);
    public Task<bool> IsEmailUniqueAsync(string email);
    public Task<bool> IsEmailUniqueForUserAsync(Guid userId, string email);
    public Task<List<UserGetResponse>> GetFilteredAndSortedUsers(FilterSortUserRequest request);
    public Task<List<RoleModel>> GetFilteredAndSortedRoles(FilterSortRolesRequest request);
}