namespace BattleShip.Services
{
    public class Player : IPlayer
    {
        char[,] grid = new char[11, 11];
        int hitcount = 0;
        int misscount = 0;
        int x = 0;
        int y = 0;

        public char[,] GetGrid()
        {
            return grid;
        }

        public void SetGrid(int q, int w)
        {
            grid[q, w] = 'S';
        }

        public int GetHitCount()
        {
            return hitcount;
        }

        public int GetMissCount()
        {
            return misscount;
        }

        public void ShipCoordinates()
        {
            Console.WriteLine("Enter X coordinate: ");
            string line = Console.ReadLine();
            int value;

            if (int.TryParse(line, out value))
            {
                x = value;
            }
            else
            {
                Console.WriteLine("Not an integer!");
            }

            Console.WriteLine("Enter Y coordinate: ");
            line = Console.ReadLine();

            if (int.TryParse(line, out value))
            {
                y = value;
            }
            else
            {
                Console.WriteLine("Not an integer!");
            }

            try
            {
                if (grid[x,y].Equals('S'))
                {
                    grid[x, y] = 'H';
                    Console.Clear();
                    Console.WriteLine("Hit!\r\n");
                    hitcount +=1;
                }
                else
                {
                    grid[x, y] = 'M';
                    Console.Clear();
                    Console.WriteLine("Miss!\r\n");
                    misscount += 1;
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Error: Please enter number between 0 and 10. (Inclusive)");
            }
        }

        public void Randomize()
        {
            SetGrid(1, 2);
            SetGrid(2, 2);

            SetGrid(4, 3);
            SetGrid(4, 4);
            SetGrid(4, 5);

            SetGrid(5, 0);
            SetGrid(6, 0);
            SetGrid(7, 0);

            SetGrid(0, 10);
            SetGrid(1, 10);
            SetGrid(2, 10);
            SetGrid(3, 10);

            SetGrid(7, 4);
            SetGrid(7, 5);
            SetGrid(7, 6);
            SetGrid(7, 7);
            SetGrid(7, 8);
            SetGrid(7, 9);
        }
    }
}
