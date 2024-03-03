using AWS_BusinessObjects.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Persistence
{
    public class ApplicationDbContextInitialiser
    {
        private readonly ILogger<ApplicationDbContextInitialiser> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public ApplicationDbContextInitialiser(ILogger<ApplicationDbContextInitialiser> logger, ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task InitialiseAsync()
        {
            try
            {
                if (_context.Database.IsSqlServer())
                {
                    await _context.Database.MigrateAsync();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while initialising the database.");
                throw;
            }
        }

        public async Task SeedAsync()
        {
            try
            {
                await TrySeedAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while seeding the database.");
                throw;
            }
        }

        public async Task TrySeedAsync()
        {

            // Roles
            //var roles = new List<IdentityRole>
            //{
            //    new IdentityRole("Admin"),
            //    new IdentityRole("Manager"),
            //    new IdentityRole("Customer"),
            //    new IdentityRole("Expert")
            //};
            //foreach (var role in roles)
            //{
            //    if (_roleManager.Roles.All(r => r.Name != role.Name))
            //    {
            //        await _roleManager.CreateAsync(role);
            //        _logger.LogInformation($"Role '{role.Name}' seeded successfully.");
            //    }
            //}

            // Default roles
            var administratorRole = new IdentityRole("Administrator");

            if (_roleManager.Roles.All(r => r.Name != administratorRole.Name))
            {
                await _roleManager.CreateAsync(administratorRole);
            }

           

            var customerRole = new IdentityRole("Audience");

            if (_roleManager.Roles.All(r => r.Name != customerRole.Name))
            {
                await _roleManager.CreateAsync(customerRole);
            }

          
            var psychologistRole = new IdentityRole("Artist");

            if (_roleManager.Roles.All(r => r.Name != psychologistRole.Name))
            {
                await _roleManager.CreateAsync(psychologistRole);
            }
    
            await _context.SaveChangesAsync();
            // Default data
            /*// Seed, if necessary
            if (!_context.TodoLists.Any())
            {
                _context.TodoLists.Add(new TodoList
                {
                    Title = "Todo List",
                    Items =
                    {
                        new TodoItem { Title = "Make a todo list 📃" },
                        new TodoItem { Title = "Check off the first item ✅" },
                        new TodoItem { Title = "Realise you've already done two things on the list! 🤯"},
                        new TodoItem { Title = "Reward yourself with a nice, long nap 🏆" },
                    }
                });

                await _context.SaveChangesAsync();
            }*/
        }
    }
}
