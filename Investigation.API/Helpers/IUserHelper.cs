using Microsoft.AspNetCore.Identity;
using Investigation.Shared.Entities;
namespace Investigation.API.Helpers
{


    public interface IUserHelper
    {
        Task<User> GetUserAsync(string CorreoElectronico);
        Task<IdentityResult> AddUserAsync(User user, string password);
        Task CheckRoleAsync(string RoleName);
        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string RoleName);

    }
}