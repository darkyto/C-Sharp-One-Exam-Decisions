using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;



class Secrets
{
    static void Main(string[] args)
    {
        /*
         TESTED for 100 points - remember the check for negative number (when nessasery) and the use of BigInteger
        */
        BigInteger userNum = BigInteger.Parse(Console.ReadLine());
        BigInteger originalNum = userNum;

        if (userNum < 0)        // check for negative 
        {
            userNum *= -1;
        }

        BigInteger specialSum = 0;

        BigInteger sumOdd = 0;
        BigInteger sumEven = 0;

        int counter = 0;                // pre-declaring counter for use to count the digit rank
        while (userNum != 0)
        {  
            counter++;                              // counter in synhron with digit rank
            BigInteger digit = userNum % 10;        // taking each digit value
            userNum /= 10;                          // goint to the next digit with each loop 

            if (counter % 2 != 0)                   // if the digit position is ODD
            {
                sumOdd += digit * (counter * counter);
            }
            else // if EVEN
            {
                sumEven += (digit * digit) * counter;
            }
        }
        specialSum = sumEven + sumOdd; // calculating the Special SUM
        

        if (specialSum % 10 == 0)     // special check if specialSum end in 0 
        {
            Console.WriteLine(specialSum);
            Console.WriteLine("{0} has no secret alpha-sequence", originalNum);
        }
        else if (specialSum % 10 != 0) // if not go to the final calculations
        {
            Console.WriteLine(specialSum); // the result for special sum before the loop starts
            BigInteger r = specialSum % 26;  // special sum divided by number of etter A-Z

            string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            BigInteger secretLenght = specialSum % 10;  // the lenght of the secret sequence of letters
            int tempCount = 0; // pre-declaring counter for inner use

            for (int i = (int)r; i < r + secretLenght; i++)  //starting loop to count the numbers from the alphabet
            {

                tempCount++;  // using this count so I will know from where to continue in the next loop
                if (i < 26)   // loops only until letter 26 in the array and breaks from the loop after that
                {
                    Console.Write("" + alphabet[i]);
                }
                else
                {
                    break;
                }

            }
            if (alphabet.Length < r + secretLenght)  // this will be ussed only when we have to start from Z to A
            {
                for (ulong y = 0; y <= secretLenght - tempCount; y++)  // using the previous counter to know where to end
                {
                    Console.Write("" + alphabet[y]); // final result
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
            }
        }

    }

}