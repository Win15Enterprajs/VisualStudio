using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VStest
{
    class UI
    {
        public void MakeItSnow()
        {
            Board SnowBoard = new Board();
            do
            {
                Board arr = new Board();
                int[,] boardArr = new int[20, 20];
                boardArr = arr.addValues(boardArr);
                arr.printArr(boardArr);
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape)
                {
                    return;
                }
                Console.Clear();
            } while (true);
        }
    }
}
