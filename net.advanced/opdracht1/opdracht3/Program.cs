using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
                    if(i * 7 == 546)
                {
                    return;
                }
               
            }
        }
    }
}
