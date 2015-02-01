using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * The machine has five trays – for 0.05, 0.10, 0.20, 0.50, and 1.00 BGN 
 * We are given the number of coins available in each tray N1, N2, …, N5 inside the machine 
 * (N1 corresponds to 0.05, N2 corresponds to 0.10 and so on). 
 * We are also given the amount A of money the developer has put into the machine, and the price P of the drink.
 * 
 *  Write a program to calculate whether the machine can give change to the developer. There are three possible cases:
•	The machine has enough coins in its trays to give the change.
•	The machine waits for the developer to put more coins (in order to reach the amount A).
•	The machine does not have enough coins to give the change.
 * ===================================================================================================================
 * INPUT
    The input data should be read from the console. 
    On the first five lines there will be the numbers N1, N2, …, N5, each on its own line.
    On the sixth line there will be the amount A the developer has put in the machine.
    On the seventh line there will be the price P of the selected drink.
    The input data will always be valid and in the format described. There is no need to check it explicitly.
 * ====================================================================================================================
 * OUTPUT
 * The output data should be printed on the console.
    On the only output line your program should print one of the following words and prices, separated by a single space:
 * 
•	----If the developer has given enough money and the machine can give change (or there is no change), print 
 * Yes along with the money left in the machine’s trays after giving change.
 * 
•	----If the price of the drink is more than the amount put by the developer, print More along with the additional amount of money needed.
 * 
•	----If the developer has given enough money but the machine cannot give change, print No along with the amount of insufficient money 
 * in the machine’s trays (e. g. if the machine has 1 BGN totally in its trays but has to give 2.50 BGN, the amount 
 * of insufficient money is 1.50 BGN).
 * 
    ----All prices should be printed with exactly two numbers after the decimal point. The decimal separator 
 * for all numbers is point “.”. Do not put any currency signs.



 */

class CoffeMachine
{
    static void Main()
    {
        // ALL OK TESTED - 100 points
        // declare double for five trays with coins 0.05 , 0.10 , 0.20 , 0.50 , 1.00
        double tray1 = 0.05;
        double tray2 = 0.10;
        double tray3 = 0.20;
        double tray4 = 0.50;
        double tray5 = 1.00;
        // user assigned double for n1...n5 - how much coins we have in each tray
        int[] n = new int[5];
        for (int i = 0; i < 5; i++)
        {
            n[i] = int.Parse(Console.ReadLine());
        }
        // doubles for amaount in the trays
        double amountTray1 = tray1 * n[0];
        double amountTray2 = tray2 * n[1];
        double amountTray3 = tray3 * n[2];
        double amountTray4 = tray4 * n[3];
        double amountTray5 = tray5 * n[4];
        double totalAmount = amountTray1 + amountTray2 + amountTray3 + amountTray4 + amountTray5;
        
        // double for A - amaount of money developer has to pay
        double bill = double.Parse(Console.ReadLine());
        
        // double P - price of the drink
        double price = double.Parse(Console.ReadLine());

        double change = bill - price; // this will be the change needed to later calculations

        double amaountLeft = totalAmount - change; // strange logic but by task conditions...
        double changeNeeded = bill - totalAmount - price ;

        if ((bill >= price) && (totalAmount >= change))
        {
            Console.WriteLine("Yes {0:F2}", amaountLeft); 
        }
        else if (price > bill)
        {
            Console.WriteLine("More {0:F2}", price - bill);
        }
        else if ( (bill >= price) && (change > changeNeeded) )
        {
            Console.WriteLine("No {0:F2}", changeNeeded);
        }
    }
}

