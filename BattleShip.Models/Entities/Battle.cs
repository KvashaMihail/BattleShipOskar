namespace BattleShip.Models.Entities
{
    public class Battle : BaseEntity
    {
        public User PlayerWin { get; set; }
        public User PlayerLose { get; set; }
        public int CountDestroyShipPlayerWin { get; set; }
        public int CountDestroyShipPlayerLose { get; set; }
    }
}
