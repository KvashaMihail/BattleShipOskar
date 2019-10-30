namespace BattleShip.Models.Entities
{
    public class Battle
    {
        public User PlayerWin { get; set; }
        public User PlayerLose { get; set; }
        public int CountDestroyShipPlayerLeft { get; set; }
        public int CountDestroyShipPlayerRight { get; set; }
    }
}
