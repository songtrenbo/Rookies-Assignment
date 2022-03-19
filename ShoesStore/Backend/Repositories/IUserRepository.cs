using Microsoft.AspNetCore.Mvc;
using Shared.Dto;
using Shared.Dto.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public interface IUserRepository
    {
        Task<PagedResponseDto<UserDto>> GetUsers([FromQuery] UserCriteriaDto userCriteriaDto);
    }
}
