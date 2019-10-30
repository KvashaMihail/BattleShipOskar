using BattleShip.DataAccess;
using Microsoft.AspNetCore.Identity;
using BattleShip.Models.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace BattleShip.Configurations
{
    public static class IdentityConfigExtension
    {
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentityCore<User>(options =>
            {
                options.Password.RequiredLength = 8;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredUniqueChars = 0;
            })
            .AddEntityFrameworkStores<BattleShipDbContext>()
            .AddDefaultTokenProviders();
        }
    }
}
