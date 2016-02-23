using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VStest
{
    class UI
    {
        public void JanStenmark()
        {
            Öxölklöfför Jan = new Öxölklöfför();
            Jan.axelklaffar();
        }
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

        public void UserInterface()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Make it snow." + "\r\n2. Jan Stenmark Generator." + "\r\n3. {placeholder}" + "\r\nESC. Exit");

                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        MakeItSnow();
                        break;
                    case ConsoleKey.D2:
                        JanStenmark();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.WriteLine("Make a choice.");
                        break;
                } 
            } while (true);
        }
    }
}
