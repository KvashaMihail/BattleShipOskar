using System;
using System.ComponentModel.DataAnnotations;

namespace BattleShip.Models.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }

        protected BaseEntity()
        {
            Id = Guid.NewGuid();
            var now = DateTime.UtcNow;
            CreationDate = new DateTime(now.Ticks / 100000 * 100000, now.Kind);
        }
    }
}
