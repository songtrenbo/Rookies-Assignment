using AutoMapper;
using Backend.Extensions;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.Dto;
using Shared.Dto.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public class UserRepository: IUserRepository
    {
        private readonly ShoesStoreDatabaseContext _shoesStoreDatabaseContext;
        private readonly IMapper _mapper;

        public UserRepository(ShoesStoreDatabaseContext shoesStoreDatabaseContext, IMapper mapper)
        {
            _shoesStoreDatabaseContext = shoesStoreDatabaseContext;
            _mapper = mapper;
        }

        //Get users with pages, search, sort
        public async Task<PagedResponseDto<UserDto>> GetUsers([FromQuery] UserCriteriaDto userCriteriaDto)
        {
            var userQuery = _shoesStoreDatabaseContext
                               .Users
                               .Where(s=>s.PermissionId!=1)
                               .AsQueryable();
            userQuery = UserFilter(userQuery, userCriteriaDto);

            var pagedUsers = await userQuery
                                .AsNoTracking()
                                .PaginateAsync(userCriteriaDto);

            var userDto = _mapper.Map<IEnumerable<UserDto>>(pagedUsers.Items);
            return new PagedResponseDto<UserDto>
            {
                CurrentPage = pagedUsers.CurrentPage,
                TotalPages = pagedUsers.TotalPages,
                TotalItems = pagedUsers.TotalItems,
                Search = userCriteriaDto.Search,
                SortColumn = userCriteriaDto.SortColumn,
                SortOrder = userCriteriaDto.SortOrder,
                Limit = userCriteriaDto.Limit,
                Items = userDto
            };
        }

        //Fliter users
        private IQueryable<User> UserFilter(
           IQueryable<User> userQuery,
           UserCriteriaDto userCriteriaDto)
        {
            if (!String.IsNullOrEmpty(userCriteriaDto.Search))
            {
                userQuery = userQuery.Where(b =>
                    b.FirstName.Contains(userCriteriaDto.Search));
            }

            return userQuery;
        }
    }
}
