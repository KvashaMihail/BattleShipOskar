using BattleShip.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BattleShip.DataAccess
{
    public class BattleShipDbContext : IdentityDbContext<User>
    {
        public DbSet<Battle> Battle { get; set; }

        public BattleShipDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
