using Microsoft.AspNetCore.Identity;
using ProjectCachoeiro.Web.Models;
using System;

namespace ProjectCachoeiro.Web.Util
{
    public class UserRoles
    {
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;

        public async void CriarRolesAsync(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;

            if ((await _roleManager.FindByNameAsync("User") == null))
                await _roleManager.CreateAsync(new IdentityRole { Name = "User" });

            if ((await _roleManager.FindByNameAsync("Admin") == null))
                await _roleManager.CreateAsync(new IdentityRole { Name = "Admin" });

            if ((await _roleManager.FindByNameAsync("SysAdmin") == null))
                await _roleManager.CreateAsync(new IdentityRole { Name = "SysAdmin" });
        }
    }
}
