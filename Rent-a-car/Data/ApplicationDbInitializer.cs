using Microsoft.AspNetCore.Identity;
using Rent_a_car.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_a_car.Data
{
    public class ApplicationDbInitializer
    {
        public static void SeedUsers(UserManager<AppUsers> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (!(roleManager.RoleExistsAsync("Admin").Result))
            {
                roleManager.CreateAsync(new IdentityRole()
                {
                    Name = "Admin"
                }).Wait();
                roleManager.CreateAsync(new IdentityRole()
                {
                    Name = "Client"
                }).Wait();
            }
            if (userManager.FindByNameAsync("Admin").Result == null)
            {
                var adminUser = new AppUsers()
                {
                    UserName = "Admin",
                    Email = "admin@mail.bg",
                    fName = "Admicho",
                    lName = "Adminchev",
                    EGN = "0000000000"
                };
                IdentityResult createAdmin = userManager.CreateAsync(adminUser, "admin123").Result;
                if (createAdmin.Succeeded)
                {
                    userManager.AddToRoleAsync(adminUser, "Admin").Wait();
                }
            }
            if (userManager.FindByNameAsync("Client").Result == null)
            {
                var clientUser = new AppUsers()
                {
                    UserName = "Client",
                    Email = "client@mail.bg",
                    fName = "Clientcho",
                    lName = "Clientchev",
                    EGN = "1111111111"
                };
                IdentityResult createClient = userManager.CreateAsync(clientUser, "client123").Result;
                if (createClient.Succeeded)
                {
                    userManager.AddToRoleAsync(clientUser, "Client").Wait();
                }
            }
        }
    }
}
