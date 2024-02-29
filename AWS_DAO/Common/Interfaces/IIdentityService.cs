using AWS_BusinessObjects.Identity;
using AWS_DAO.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.Common.Interfaces
{
    public interface IIdentityService
    {
        Task<string?> GetUserNameAsync(string userId);

        Task<bool> IsInRoleAsync(string userId, string role);

        Task<bool> AuthorizeAsync(string userId, string policyName);

        Task<(Result Result, string UserId)> CreateUserAsync(string userName, string password);

        Task<(Result Result, string UserId)> CreateNewUserAsync(string email, string userName, string firstName, string lastName, DateTime birthday, string address, string phone, string password);

        Task<ApplicationUser> GetUserByEmailAsync(string email);

        Task<ApplicationUser> GetUserByNameAsync(string name);

        Task<ApplicationUser> DeleteUserAsync(string userId);

        Task<ApplicationUser> GetUserAsync(string userId);

        Task<List<ApplicationUser>> GetListUsersAsync();
    }
}
