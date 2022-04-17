using AutoMapper;
using Backend.Extensions;
using Backend.Model;
using Backend.Models;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public UserRepository(ShoesStoreDatabaseContext shoesStoreDatabaseContext, UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _shoesStoreDatabaseContext = shoesStoreDatabaseContext;
            _userManager = userManager;
            _mapper = mapper;
        }

        //Get users with pages, search, sort
        public async Task<PagedResponseDto<UserDto>> GetUsers([FromQuery] UserCriteriaDto userCriteriaDto)
        {
            //var admin = await _userManager.FindByIdAsync(accountId);
            var admin = await _userManager.GetUsersInRoleAsync("Admin");
            var userQuery = _shoesStoreDatabaseContext
                               .Users
                               .Where(s => s != admin)
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
        private IQueryable<ApplicationUser> UserFilter(
           IQueryable<ApplicationUser> userQuery,
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
