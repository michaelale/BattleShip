namespace BattleShip.Services
{
    public class BattleShipBoard : IBattleShipBoard
    {
        public void DisplayBoard(char[,] board)
        {
            try
            {
                Console.WriteLine("  | 0 1 2 3 4 5 6 7 8 9 10");
                Console.WriteLine("--+-----------------------");
                for (int row = 0; row < 11; row++)
                {
                    if (row == 10)
                    {
                        Console.Write(row.ToString() + "| ");
                    }
                    else
                    {
                        Console.Write(row.ToString() + " | ");
                    }

                    for (int column = 0; column < 10; column++)
                    {
                        Console.Write(board[column, row] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n");
            }
            catch
            {
                throw;
            }
        }

    }
}
