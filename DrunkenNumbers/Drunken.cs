using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *Input
 *The input data should be read from the console.
 *The number or rounds N is given on the first input line.
 *An each of the next N lines one number is given – the drunken number for the corresponding round.
 *The input data will always be valid and in the format described. There is no need to check it explicitly.
 *
 * Output
 * The output data should be printed on the console.
 * On the only output line your program should print the first letter of the winner’s name 
 * (“M” for Mitko and “V” for Vladko) and a space followed by a number representing how much more beers the winner has drank. 
 * If there is no winner print “No” followed by a space and the total drunken beers.
 * 
 * Constraints
•	1 ≤ N ≤ 100.
•	All drunken numbers will be integers and will contain no more than 9 significant digits. 
•	Allowed working time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.
                        Examples
                        Input example	Output example
                        2
                        1234
                        123	            V 6
 
 */

class Drunken
{
    static void Main(string[] args)
    {
        // ALLL OK tested for 100 points
        // number of rounds
        long roundsNUm = long.Parse(Console.ReadLine()); 

        long sumBeerMitko = 0; // pre-declaring variables for beers of Mitko and beers of Vlado
        long sumBeerVlado = 0;

        long winnerMitko = sumBeerMitko - sumBeerVlado;     // difference of beers for the winner
        long winnerVlado = sumBeerVlado - sumBeerMitko;

        long totalBeers = sumBeerMitko + sumBeerVlado; // for No answer case - total sum of the beers!

        long[] drunken = new long[roundsNUm];  // array for collecting the values of each round
        
        // value of drunken for each round
        for (int i = 0; i < roundsNUm; i++)     // start LOPP FOR EAECH ROUND
        {
            drunken[i] = long.Parse(Console.ReadLine());  // collecting the value of beers drunk together
            if (drunken[i] < 0)             // SPECIAL CASE for negative numbers ("9 signiificant digits")
            {
                drunken[i] *= -1;
            }
            long tempDrunk = drunken[i];    // temp variable for reading the current number example : 1234
            int digits = 0;                 // variable for number of digits   
             
            while (tempDrunk > 0)           // dividing the number by 10 to get digits      example : 4
            {
                tempDrunk /= 10;
                digits++;
            }

            if (digits % 2 == 0)            // now in the same start loop checking if number of digits is EVEN
            {
                for (int y = 0; y < digits / 2; y++)    // slave loop for Mitko - NOTICE it goes up to digits/2 
                {
                    sumBeerMitko += drunken[i] % 10;    // adding the remainder of /10 to get sum of beers
                    drunken[i]/= 10;                    // adjusting the number to the next digit
                }
                for (int x = 0 ; x < digits / 2 ; x++)  // the number is now divided after the middle so this loop is for VLADO
                {
                    sumBeerVlado += drunken[i] % 10;   
                    drunken[i] /= 10;
                }   
            }
            else if (digits % 2 !=0)                    // the same as above but for ODD number of digits
            {
                for (int y = 0; y < digits/2; y++)
                {
                    sumBeerMitko += drunken[i] % 10;
                    drunken[i] /= 10;
                }

                long middle = drunken[i] % 10;          // THIS IS HOW TO GET THE MIDDLE DIGIT
                sumBeerMitko += middle;             
                sumBeerVlado += middle;                 // ading to both Vlado and Mitko
                drunken[i] /= 10;                       // then again moving to the next digit

                for (int x = 0; x < digits/2; x++)      // final cont of beers for VLADO
                {
                    sumBeerVlado += drunken[i] % 10;
                    drunken[i] /= 10;
                }   
            }
        }

        if (sumBeerVlado > sumBeerMitko)                // tast conditions checks
        {
            Console.WriteLine("M {0}", sumBeerVlado - sumBeerMitko);
        }
        else if (sumBeerMitko > sumBeerVlado )
        {
            Console.WriteLine("V {0}", sumBeerMitko - sumBeerVlado);
        }
        else // m = v
        {
            Console.WriteLine("No {0}", sumBeerMitko + sumBeerVlado);
        }
    }
}

