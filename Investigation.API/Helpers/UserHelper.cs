using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Investigation.API.Data;
using Investigation.API.Helpers;
using Investigation.Shared.Entities;
using System.Net.Http.Headers;

namespace Investigation.API.Helpers
{
    public class UserHelper : IUserHelper
    {

        private readonly DataContext _context;
        private UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public string Name { get; private set; }
        public UserHelper(DataContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IdentityResult> AddUserAsync(User user, string password)
        {
            return await _userManager.CreateAsync(user, password);
        }

        public async Task AddUserToRoleAsync(User user, string roleName)
        {
            await _userManager.AddToRoleAsync(user, roleName);

        }

        public async Task CheckRoleAsync(string RoleName)
        {
            bool roleExist = await _roleManager.RoleExistsAsync(RoleName);
            if (!roleExist)
            {
                await _roleManager.CreateAsync(new IdentityRole
                {
                    Name = RoleName
                });

            }
        }

        public async Task<User> GetUserAsync(string email)
        {
            return await _context.Users
            .FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task<bool> IsUserInRoleAsync(User user, string RoleName)
        {
            return await _userManager.IsInRoleAsync(user, RoleName);
        }
    }
}