using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PayrollAppRazorPages.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollAppRazorPages.Models
{
    public class SeedData
    {
        public static async Task InitializeAsync(IServiceProvider serviceProvider)
        {
            using var context = new ApplicationDbContext(serviceProvider.GetRequiredService<
                DbContextOptions<ApplicationDbContext>>());

            if (context.Users.Any())
            {
                return;
            }
            var roleManager = serviceProvider.GetService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();

            string[] roles = new string[] { "superadmin", "admin", "staff" };
            foreach (string role in roles)
            {
                await roleManager.CreateAsync(new IdentityRole(role));
            }

            var user = new ApplicationUser
            {
                UserName = "superadmin"
            };

            await userManager.CreateAsync(user, "superadmin"); // set password same as username
            
            await userManager.AddToRoleAsync(user, "superadmin"); // add superadmin role 
        }
    }
}
