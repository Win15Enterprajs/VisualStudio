﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VStest
{
    class Öxölklöfför
    {
        public void axelklaffar()
        {
            var vokaler = new char[] { 'a', 'o', 'u', 'å', 'e', 'i', 'y', 'ä', 'ö' };
            string test = Console.ReadLine();
            foreach (char c in vokaler)
            {
                test = test.Replace(c, 'ö');
            }

            Console.WriteLine(test);
            Console.ReadKey();
        }
    }
}
