using AutoMapper;
using Backend.Extensions;
using Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.Dto;
using Shared.Dto.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;

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

        public async Task<bool> CheckUser([FromForm] LoginModel model)
        {
            var hasher = new PasswordHasher<User>();       

            var user = await _shoesStoreDatabaseContext.Users.FirstOrDefaultAsync(s => s.UserName == model.UserName);
            if (user == null)
            {
                return false;
            }
            var result = hasher.VerifyHashedPassword(user, user.Password, model.Password);
            if (result != PasswordVerificationResult.Success)
            {
                return false;
            }
            var permission = await _shoesStoreDatabaseContext.Permissions.FirstOrDefaultAsync(s => s.PermissionId == user.PermissionId);
            model.PermissionName = permission.PermissionName;
            model.UserId = user.UserId;
            model.FullName = user.LastName + " " + user.FirstName;
            return true;
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

        public async Task<List<User>> GetUser()
        {
            return await _shoesStoreDatabaseContext.Users.ToListAsync();
        }

        public async Task<User> Register([FromForm] RegisterModel model)
        {
            var hasher = new PasswordHasher<User>();
            User user = new User
            {
                UserName = model.UserName,
                UserEmail = model.UserEmail,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Password = hasher.HashPassword(null, model.Password),
                PermissionId = 2
            };
            var result = await _shoesStoreDatabaseContext.Users.AddAsync(user);
            await _shoesStoreDatabaseContext.SaveChangesAsync();
            return result.Entity;
        }
    }
}
