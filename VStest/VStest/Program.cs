using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VStest
{
    class Program
    {
        static void Main(string[] args)
        {
            // first line of code added
            Console.WriteLine("Initial code added here, Här vid har jag ändrat.");
            UI ui = new UI();
            ui.UserInterface();
            Console.WriteLine("Här har jag också ändrat.");
        }
    }
}
