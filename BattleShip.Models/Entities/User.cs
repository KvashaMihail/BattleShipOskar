using BattleShip.Models.Enums;
using Microsoft.AspNetCore.Identity;

namespace BattleShip.Models.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public Part Part { get; set; }
        public int Money { get; set; }
    }
}
