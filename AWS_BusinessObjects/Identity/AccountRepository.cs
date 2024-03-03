using AWS_BusinessObjects.Common.Interfaces;
using AWS_BusinessObjects.Identity;
using AWS_BusinessObjects.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Identity
{

    public class AccountRepository : IAccountRepository
    {
        private readonly IIdentityService identityService;
        private readonly IConfiguration configuration;
        private readonly RoleManager<IdentityRole> roleManager;
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;

        public AccountRepository(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IConfiguration configuration,
            RoleManager<IdentityRole> roleManager,
            IIdentityService identityService
            )
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.configuration = configuration;
            this.roleManager = roleManager;
            this.identityService = identityService;
        }
        public async Task<string> SignInAsync(SignInModel model)
        {
            /*var signInResult = await signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
            if(!signInResult.Succeeded)
            {
                throw new InvalidOperationException("Sai tên đăng nhập hoặc mật khẩu. Vui lòng thử lại!");
                //return string.Empty;
            }*/
            var user = await identityService.GetUserByEmailAsync(model.Email);
            var passwordCheck = await userManager.CheckPasswordAsync(user, model.Password);
            if (user == null || passwordCheck == false)
            {
                throw new InvalidOperationException("Sai tên đăng nhập hoặc mật khẩu. Vui lòng thử lại!");
            }
            // Claims
            var authClaims = new List<Claim>
        {
            new Claim(ClaimTypes.Email, model.Email),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };
            //Get role
            var userRole = await userManager.GetRolesAsync(user);
            foreach (var role in userRole)
            {
                //add role
                authClaims.Add(new Claim(ClaimTypes.Role, role.ToString()));
            }
            // Use this line to relax HMAC key size validation
            IdentityModelEventSource.ShowPII = true;

            // Get Key and token
            var authenKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:SecrectKey"]));
            var token = new JwtSecurityToken(
                issuer: configuration["JWT:ValidIssuer"],
                audience: configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddMinutes(30),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authenKey, SecurityAlgorithms.HmacSha512Signature)
            );

            // Return token
            return new JwtSecurityTokenHandler().WriteToken(token);


        }

        public async Task<IdentityResult> SignUpAsync(SignUpModel model)
        {
            var user = new ApplicationUser
            {
                Email = model.Email,
                UserName = model.Email,
            };
            var result = await userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                // Check role
                if (!await roleManager.RoleExistsAsync("Audience"))
                {
                    await roleManager.CreateAsync(new IdentityRole("Audience"));
                }
                await userManager.AddToRoleAsync(user, "Audience");
            }

            return result;
        }
    }

}
