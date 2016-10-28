using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piskvorky
{
    class Program
    {
        static void Main(string[] args)
        {           
            Game mriezka = new Game();
            mriezka.VytvorMriezku();
              
            Console.ReadLine();
        }
    }
}
