using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Fire
{
    static void Main(string[] args)
    {
        // ALLL OK TESTED for 100 points
        int width = int.Parse(Console.ReadLine());

        int height = (3 * width) / 4;

        for (int x = 0; x < height; x++)   // printing only the top part of the torch
        {
            for (int y = 0; y < width; y++)
            {
                if  ( ( (y == 0) || ( y == width - 1) ) && (x <= (2* height)/3 && x >= width/2-1) )  // side wall y=0 and y=widht-1 OK
                {
                    Console.Write('#');
                }
                else if ( ( x == 0 ) && ((y == width/2-1) || (y == width/2 )) )      // top wall OK
                {
                    Console.Write('#');
                }
                else if (x + y == width/2-1)                        // torch left-up OK
                {
                    Console.Write('#');
                }
                else if (x + y == (3*width)/2-1)                    // torch right-down    w=12 x+y17 OK
                {
                    Console.Write('#');
                }
                else if (x - y == width / 2)                        // torch  left-down  OK
                {
                    Console.Write('#');
                }
                else if (x - y == -(width/2) )                    // torch   right-uo  OK
                {
                    Console.Write('#');
                }
                else
                {
                    Console.Write('.');
                }
               
            }
            
            Console.WriteLine();
        }
        for (int x = 0; x < 1; x++)  // the straight line
        {
            for (int y = 0; y < width; y++)
            {
                Console.Write('-');
            }
        }
        Console.WriteLine();

        for (int x = 0; x < width/2; x++)  // this is the down side of the torch
        {
            for (int y = 0; y < width; y++)
            {
                if ((y -x >= 0) && y < width/2)  //   OKKKKK
                {
                    Console.Write('\\');
                }
                else if ( (y > width/2 -1) && x+y < width)
                {
                    Console.Write('/');
                }
                else 
                {
                    Console.Write('.');
                }
                
            }
            Console.WriteLine();
        }
        

    }
}

