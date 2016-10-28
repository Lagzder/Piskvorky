using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piskvorky
{
    class Game
    {
        public Game() { }

        public void VytvorMriezku()
        {
            int poc = 1;
            int poc1 = 0;
            int a = 0;
            int hrac1 = 0;
            int hrac2 = 0;
            bool z = true;
            bool volba = true;


            int[,] array = new int[3, 3]; //naplnenie pola nulami

            for (int k = 0; k < 3; k++)
            {
                for (int l = 0; l < 3; l++)
                {
                    array[k, l] = 0;
                }
            }

            while (z)
            {

                string volbaR;
                string volbaS;

                if (poc % 2 == 0)
                {
                    Console.WriteLine("2. hrac zadava\n");
                }
                else
                {
                    Console.WriteLine("1. hrac zadava\n");
                }

                for (int i = 0; i < 3; i++) //vykreslenie aktualnej hracej plochy
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (array[i, j] == 1)
                        {
                            Console.Write("x ");
                        }
                        if (array[i, j] == 2)
                        {
                            Console.Write("o ");
                        }
                        if (array[i, j] == 0)
                        {
                            Console.Write("- ");
                        }
                    }
                    Console.WriteLine();
                }

                while (volba) //zadavanie vstupov riadku a stlpca
                {
                    Console.WriteLine("\nZadaj riadok");
                    volbaR = Console.ReadLine();

                    int x = Convert.ToInt32(volbaR) - 1;

                    Console.WriteLine("\nZadaj stlpec");
                    volbaS = Console.ReadLine();

                    int y = Convert.ToInt32(volbaS) - 1;

                    if (array[x, y] == 1 || array[x, y] == 2)
                    {
                        Console.WriteLine("Obsadene policko");
                    }
                    else
                    {
                        if (poc % 2 == 0)
                        {
                            array[x, y] = 2;
                        }
                        else
                        {
                            array[x, y] = 1;
                        }

                        volba = false;
                    }
                }
                

                for (int i = 0; i < 3; i++) //pre hladanie vyhercu po riadkoch + zaverecne vykreslenie plochy
                {
                    for (int j = 0; j < 3; j++)
                    {
                        a = array[i, j];

                        if (a == 1)
                        {
                            hrac1++;
                        }
                        if (a == 2)
                        {
                            hrac2++;
                        }

                        if (hrac1 == 3) //ak riadok obsahuje 3 znaky 1. hraca
                        {
                            for (int ii = 0; ii < 3; ii++)
                            {
                                for (int jj = 0; jj < 3; jj++)
                                {
                                    if (array[ii, jj] == 1)
                                    {
                                        Console.Write("x ");
                                    }
                                    if (array[ii, jj] == 2)
                                    {
                                        Console.Write("o ");
                                    }
                                    if (array[ii, jj] == 0)
                                    {
                                        Console.Write("- ");
                                    }
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine("\nvyhral hrac 1");
                            z = false;
                            
                        }

                        if (hrac2 == 3) //ak riadok obsahuje znaky 2.hraca
                        {
                            for (int ii = 0; ii < 3; ii++)
                            {
                                for (int jj = 0; jj < 3; jj++)
                                {
                                    if (array[ii, jj] == 1)
                                    {
                                        Console.Write("x ");
                                    }
                                    if (array[ii, jj] == 2)
                                    {
                                        Console.Write("o ");
                                    }
                                    if (array[ii, jj] == 0)
                                    {
                                        Console.Write("- ");
                                    }
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine("\nvyhral hrac 2");
                            z = false;
                        }
                    }

                    hrac1 = 0;
                    hrac2 = 0;

                }

                for (int j = 0; j < 3; j++) //pre hladanie vyhercu po stlpcoch + zaverecne vykreslenie plochy
                {
                    for (int i = 0; i < 3; i++)
                    {
                        a = array[i, j];

                        if (a == 1)
                        {
                            hrac1++;
                        }
                        if (a == 2)
                        {
                            hrac2++;
                        }

                        if (hrac1 == 3)
                        {
                            for (int ii = 0; ii < 3; ii++) //vykreslenie
                            {
                                for (int jj = 0; jj < 3; jj++)
                                {
                                    if (array[ii, jj] == 1)
                                    {
                                        Console.Write("x ");
                                    }
                                    if (array[ii, jj] == 2)
                                    {
                                        Console.Write("o ");
                                    }
                                    if (array[ii, jj] == 0)
                                    {
                                        Console.Write("- ");
                                    }
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine("\nvyhral hrac 1");
                            z = false;

                        }

                        if (hrac2 == 3)
                        {
                            for (int ii = 0; ii < 3; ii++) // vykreslenie
                            {
                                for (int jj = 0; jj < 3; jj++)
                                {
                                    if (array[ii, jj] == 1)
                                    {
                                        Console.Write("x ");
                                    }
                                    if (array[ii, jj] == 2)
                                    {
                                        Console.Write("o ");
                                    }
                                    if (array[ii, jj] == 0)
                                    {
                                        Console.Write("- ");
                                    }
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine("\nvyhral hrac 2");
                            z = false;
                        }
                    }

                    hrac1 = 0;
                    hrac2 = 0;

                }

                if(array[0,0] == 1 && array[1,1] == 1 && array[2,2] == 1 || array[2, 0] == 1 && array[1, 1] == 1 && array[0, 2] == 1) //1. uhlopriecka
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (array[i, j] == 1)
                            {
                                Console.Write("x ");
                            }
                            if (array[i, j] == 2)
                            {
                                Console.Write("o ");
                            }
                            if (array[i, j] == 0)
                            {
                                Console.Write("- ");
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\nVyhral hrac1");
                    z = false;
                }

                if (array[0, 0] == 2 && array[1, 1] == 2 && array[2, 2] == 2 || array[2, 0] == 2 && array[1, 1] == 2 && array[0, 2] == 2) //2.Uhlopriecka
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (array[i, j] == 1)
                            {
                                Console.Write("x ");
                            }
                            if (array[i, j] == 2)
                            {
                                Console.Write("o ");
                            }
                            if (array[i, j] == 0)
                            {
                                Console.Write("- ");
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\nVyhral hrac2");
                    z = false;
                }

                for (int i = 0; i < 3; i++) // plna hracia plocha, nikto nevyhrava
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if(array[j,i] == 0)
                        {
                            poc1++;
                        } 
                    }
                    
                    if(poc1 == 0)
                    {
                        Console.WriteLine("nikto nevyhral");
                        z = false;
                    }              
                }

                volba = true;
                poc++;
            } // while

        } // funkcia

                
               
                    
   }
}
            
        
    

