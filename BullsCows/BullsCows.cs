using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



 class BullsCows
 {
     static void Main()
     {
         // ALL OK TESTED - 100 Points

         int secret = int.Parse(Console.ReadLine()); // range 1-9  ; 4 digits always 
         int bulls = int.Parse(Console.ReadLine());  // range 0-9
         int cows = int.Parse(Console.ReadLine());   // range 0-9

         bool isFound = false;  // for the last check when NOTHING is FOUND

         for (int i = 1000; i <= 9999; i++)  // ok as I thought going to all the numbers with a loop - will exclude the 0s also
         {
             int currentBulls = 0;  // counter for bulls
             int currentCows = 0;   // counter for cows

             int currentNumber = i;  // temp variable to preserve the current number i - this wil be the display value!!!!!!

             int numberFour = currentNumber % 10;  // with this I am storring each digit of each number in the variables numberOne ... numberFour
             currentNumber /= 10;
             int numberThree = currentNumber % 10; // getting each digit of the current number (for example 8754) to different variables
             currentNumber /= 10;
             int numberTwo = currentNumber % 10;  // for example numberFoure = 4 .... numberOne = 8 ... and this for all the 8999 numbers from the i loop
             currentNumber /= 10;
             int numberOne = currentNumber;

             if (numberOne == 0 || numberTwo == 0 || numberThree == 0 || numberFour == 0)  // SPECIAL CHECK FOR all 0s
             {
                 continue; // will return to the loop and ignore all numbers with 0
             }

             int tempSecret = secret;  // again temp variable to presrve the secret number

             int secretNumberFour = tempSecret % 10;  // getting each digit of the secret number step by step
             tempSecret /= 10;
             int secretNumberThree = tempSecret % 10; // storing each digit in a different varuiable  secretNumberFour..... secretNumberOne
             tempSecret /= 10;
             int secretNumberTwo = tempSecret % 10;
             tempSecret /= 10;
             int secretNumberOne = tempSecret;

             #region Bulls
             if (secretNumberOne == numberOne)  // check for bulls step by step
             {
                 currentBulls++;                // if bull is found - updte the counter
                 secretNumberOne = -1;          // and most important - CANCEL the numbers thast formed the bulls
                 numberOne = -2;
             }
             if (secretNumberTwo == numberTwo)
             {
                 currentBulls++;
                 secretNumberTwo = -1;
                 numberTwo = -2;
             }
             if (secretNumberThree == numberThree)
             {
                 currentBulls++;
                 secretNumberThree = -1;
                 numberThree = -2;
             }
             if (secretNumberFour == numberFour)
             {
                 currentBulls++;
                 secretNumberFour = -1;
                 numberFour = -2;
             }
             #endregion // here i find the bulls

             #region CowsOne
             if (secretNumberOne == numberTwo)          // check for cows step by step
             {
                 currentCows++;                         // if cows is found - update the counter
                 secretNumberOne = -1;                   // and most important - CANCEL the numbers thast formed the cows
                 numberTwo = -2;
             }
             if (secretNumberOne == numberThree)
             {
                 currentCows++;
                 secretNumberOne = -1;
                 numberThree = -2;
             }
             if (secretNumberOne == numberFour)
             {
                 currentCows++;
                 secretNumberOne = -1;
                 numberFour = -2;
             }
             #endregion

             #region CowsTwo
             if (secretNumberTwo == numberOne)          // check for cows step by step
             {
                 currentCows++;                         // if cows is found - update the counter
                 secretNumberTwo = -1;                   // and most important - CANCEL the numbers thast formed the cows
                 numberOne = -2;
             }
             if (secretNumberTwo == numberThree)
             {
                 currentCows++;
                 secretNumberTwo = -1;
                 numberThree = -2;
             }
             if (secretNumberTwo == numberFour)
             {
                 currentCows++;
                 secretNumberTwo = -1;
                 numberFour = -2;
             }
             #endregion

             #region CowsThree
             if (secretNumberThree == numberOne)            // check for cows step by step
             {
                 currentCows++;                             // if cows is found - update the counter
                 secretNumberThree = -1;                     // and most important - CANCEL the numbers thast formed the cows
                 numberOne = -2;
             }
             if (secretNumberThree == numberTwo)
             {
                 currentCows++;
                 secretNumberThree = -1;
                 numberTwo = -2;
             }
             if (secretNumberThree == numberFour)
             {
                 currentCows++;
                 secretNumberThree = -1;
                 numberFour = -2;
             }
             #endregion

             #region CowsFour
             if (secretNumberFour == numberOne)         // check for cows step by step
             {
                 currentCows++;                         // if cows is found - update the counter
                 secretNumberFour = -1;                  // and most important - CANCEL the numbers thast formed the cows
                 numberOne = -2;
             }
             if (secretNumberFour == numberTwo)
             {
                 currentCows++;
                 secretNumberFour = -1;
                 numberTwo = -2;
             }
             if (secretNumberFour == numberThree)
             {
                 currentCows++;
                 secretNumberFour = -1;
                 numberThree = -2;
             }
             #endregion

             //final results
             if (currentBulls == bulls && currentCows == cows)
             {
                 isFound = true;
                 Console.Write("{0} ", i);  // this should be inside the main loop in order for i to work as a result
             }
         }

         if (!isFound)  //special case for no resuts found and out of range
         {
             Console.WriteLine("No");
         }
         else
         {
             Console.WriteLine();
         }
     }
 }

