using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameProgramming_Challenge_SuperVirus_GabeRyan
{
    internal class Program
    {
        static Random random = new Random();
        

        static char[,] minimap = {
    {'-','-','-','-','-','^','^','^','-','-','-','-','-','-','-','-','-','-','-','-','-','-','^','^','^','-','-','-','-','-','-','-','^','^','^','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-'},
    {'-','-','-','~','~','~','^','^','-','-','-','-','-','-','-','-','-','-','-','-','-','^','^','^','^','-','-','-','-','-','-','-','^','^','^','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-'},
    {'^','^','-','~','~','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','^','^','^','^','^','-','-','-','-','-','-','-','^','^','^','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-'},
    {'-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-'},
    {'-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-'},
    {'-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-'},
    {'-','-','-','-','~','~','~','~','-','-','-','-','-','-','-','-','-','-','-','-','~','~','~','~','~','-','-','-','-','-','-','-','~','~','~','~','-','-','-','-','-','-','-','-','-','-','-','-','-','-'},
    {'~','~','~','~','~','~','~','-','-','-','-','-','-','-','-','-','-','-','-','-','~','~','~','~','~','~','-','-','-','-','-','-','~','~','~','~','~','-','-','-','-','-','-','-','-','-','-','-','-','-'},
    {'~','~','~','~','~','~','~','-','-','-','-','-','-','-','-','-','-','-','-','-','~','~','~','~','~','~','-','-','-','-','-','-','~','~','~','~','~','-','-','-','-','-','-','-','-','-','-','-','-','-'},
    {'~','~','~','~','~','~','~','-','-','-','-','-','-','-','-','-','-','-','-','-','~','~','~','~','~','~','-','-','-','-','-','-','~','~','~','~','~','-','-','-','-','-','-','-','-','-','-','-','-','-'},
    {'-','-','-','-','-','^','^','^','^','^','-','-','-','-','-','-','-','-','-','-','^','^','^','^','^','^','-','-','-','-','-','-','^','^','^','^','^','-','-','-','-','-','-','-','-','-','-','-','-','-'},
    {'-','-','-','~','~','~','^','^','^','^','^','-','-','-','-','-','-','-','-','-','^','^','^','^','^','^','-','-','-','-','-','-','^','^','^','^','^','-','-','-','-','-','-','-','-','-','-','-','-','-'},
    {'^','^','-','~','~','~','~','~','^','^','^','^','-','-','-','-','-','-','-','-','^','^','^','^','^','^','-','-','-','-','-','-','^','^','^','^','^','-','-','-','-','-','-','-','-','-','-','-','-','-'},
    {'-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-'},
    {'-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-'}
};

        static List<(int, int)> virusPosition = new List<(int, int)>();
        static void Main(string[] args)
        {
            
            for(int i = 0; i <minimap.GetLength(0); i++)
            {

                for (int j = 0; j < minimap.GetLength(1); j++)
                {
                    Console.Write(minimap[i, j]);
                }
                    

                Console.Write("\n");
            }


            
            virusPosition.Add((5,5));
            virusPosition.Add((30, 7));
            virusPosition.Add((15, 8));
            //set cursor position using virusPosition[0]
            //Write x

            Console.CursorVisible = false;


            while (true)
            {
                

                    Console.SetCursorPosition(virusPosition[0].Item1, virusPosition[0].Item2);

                    Console.Write("X");
                    Console.SetCursorPosition(virusPosition[1].Item1, virusPosition[1].Item2);
                    Console.Write("X");
                    Console.SetCursorPosition(virusPosition[2].Item1, virusPosition[2].Item2);
                    Console.Write("X");

                    Thread.Sleep(500);
                    Console.SetCursorPosition(virusPosition[0].Item1, virusPosition[0].Item2);
                    Console.Write(minimap[virusPosition[0].Item2, virusPosition[0].Item1]);
                    Console.SetCursorPosition(virusPosition[1].Item1, virusPosition[1].Item2);
                    Console.Write(minimap[virusPosition[1].Item2, virusPosition[1].Item1]);
                    Console.SetCursorPosition(virusPosition[2].Item1, virusPosition[2].Item2);
                    Console.Write(minimap[virusPosition[2].Item2, virusPosition[2].Item1]);






                
                int randomNumber = random.Next(-1, 2);
                    int randomNumber2 = random.Next(-1, 2);
                    int randomNumber3 = random.Next(-1, 2);
                    int randomNumber4 = random.Next(-1, 2);
                    int randomNumber5 = random.Next(-1, 2);
                    int randomNumber6 = random.Next(-1, 2);




                    // set cursor position to virus position
                    // write minimap [virusposition]



                    virusPosition[0] = (virusPosition[0].Item1 + randomNumber, virusPosition[0].Item2 + randomNumber2);

                    virusPosition[1] = (virusPosition[1].Item1 + randomNumber3, virusPosition[1].Item2 + randomNumber4);

                    virusPosition[2] = (virusPosition[2].Item1 + randomNumber5, virusPosition[2].Item2 + randomNumber6);
                    
                    for(int i = 0; i < virusPosition.Count; i++)
                {
                    if (virusPosition[i].Item1 == -1)
                    {
                        virusPosition[i] = (0, virusPosition[i].Item2);
                    }
                    if (virusPosition[i].Item2 == -1)
                    {
                        virusPosition[i] = (virusPosition[i].Item1, 0);
                    }
                    if (virusPosition[i].Item1 == 50)
                    {
                        virusPosition[i] = (49, virusPosition[i].Item2);
                    }
                    if(virusPosition[i].Item2 == 15)
                    {
                        virusPosition[i] = (virusPosition[i].Item1, 14);
                    }
                }
                    




                    //Move x in random position
                    // make previous space what it was before






                
            }
         
        }

        
    }
}
