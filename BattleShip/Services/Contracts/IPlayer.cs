namespace BattleShip.Services
{
    public interface IPlayer
    {
        char[,] GetGrid();
        void SetGrid(int q, int w);
        int GetHitCount();
        int GetMissCount();
        void ShipCoordinates();
        void Randomize();
    }
}
