using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VStest

{
    class Board
    {
        public int[,] addValues(int[,] arrayInput)
        {
            int[,] temp = arrayInput;
            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                temp[rnd.Next(0 , arrayInput.GetLength(0)),rnd.Next(0, arrayInput.GetLength(1))] = rnd.Next(0, 2);
            }
            return temp;
        }
        public void printArr(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == 1)
                    {
                        if (j == array.GetLength(1) - 1)
                        {
                            Console.Write("* \r\n");
                        }
                        Console.Write("* ");
                    }
                    else if (j == array.GetLength(1) - 1)
                    {
                        Console.Write("  \r\n");
                        break;
                    }
                    else if (array[i, j] == 0)
                    {
                        Console.Write("  ");
                    }
                }
            }
        }
    }
}
