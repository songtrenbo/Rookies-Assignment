using Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Shared.Dto;
using Shared.Dto.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;

namespace Backend.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> GetUser();
        Task<PagedResponseDto<UserDto>> GetUsers([FromQuery] UserCriteriaDto userCriteriaDto);
        Task<bool> CheckUser([FromForm] LoginModel model);
        Task<User> Register([FromForm] RegisterModel model);
    }
}
