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
            /*for(int i = 0; i < 10; i++)
            {
                
                if((poc % 2) == 0)
                {
                    Console.WriteLine("parne");
                }
                else Console.WriteLine("neparne");

                poc = poc + 1;
               
                
            }

            /*for(int j = 0; j < 10; j++)
            {
               
            }*/
            
            Console.ReadLine();
        }
    }
}
