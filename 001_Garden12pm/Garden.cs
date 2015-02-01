using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Garden
{
    static void Main(string[] args)
    {
        // NOT TESTED (bgCOder do not proceed) - try the both variants with dot and comma
        // Decision for 1.24h

        double[] prices = new double[6];   // array for the prices
        prices[0] = 0.5;   //tomatoPrice  
        prices[1] = 0.4;   //cucumberPrice
        prices[2] = 0.25;  //potatoPrice  
        prices[3] = 0.6;   //carrotPrice  
        prices[4] = 0.3;   //cabbagePrice 
        prices[5] = 0.4;   //beansPrice   

        double sumPrice = 0;

        double totalArea = 250;
        double sumArea = 0; // area for all the seeds EXCEPT for the beans
        double beansArea = 0;   //totalArea - sumArea;   area left for the beans - use later after you get the digits for the sumArea

        int rows = 5;
        int cols = 2;
        int[,] seedsInfo = new int[rows, cols];                     //tomato-tomatoArea ;       0
                                                                    //cucumber-cucumberArea ;   1
        for (int seed = 0; seed < rows; seed++)                     //potato-PotatoArea ;       2
        {                                                           //carrot-carrotArea ;       3
            for (int area = 0; area < cols; area++)                 //cabbage-cabbageArea       4
            {
                seedsInfo[seed, area] = int.Parse(Console.ReadLine());
            }
        }
        int beansAmount = int.Parse(Console.ReadLine());

        //for test only remove later
        //for (int row = 0; row < seedsInfo.GetLength(0); row++)
        //{
        //    for (int col = 0; col < seedsInfo.GetLength(1); col++)
        //    {
        //        Console.Write(" " + seedsInfo[row, col]);
        //    }
        //    Console.WriteLine();
        //}
        sumArea = seedsInfo[0, 1] + seedsInfo[1, 1] + seedsInfo[2, 1] + seedsInfo[3, 1] + seedsInfo[4, 1]; // sum of the area without the beans
        beansArea = totalArea - sumArea; // calculating the beans area

        //now calculating the total costs for all the beans - price x quantity 
        sumPrice = (prices[0] * seedsInfo[0, 0]) + (prices[1] * seedsInfo[1, 0]) + (prices[2] * seedsInfo[2, 0]) + (prices[3] * seedsInfo[3, 0]) + (prices[4] * seedsInfo[4, 0]) + (prices[5] * beansAmount);

        if (beansArea > 0)
        {
            Console.WriteLine("Total costs: {0:F2}", sumPrice);
            Console.WriteLine("Beans area: {0}", beansArea);
        }
        else if (sumArea > totalArea)
        {
            Console.WriteLine("Total costs: {0:F2}", sumPrice);
            Console.WriteLine("Insufficient area");           
        }
        else if (beansArea <= 0)
        {
            Console.WriteLine("Total costs: {0:#.##}", sumPrice); // {0:F2}  test it when bgCoder is up
            Console.WriteLine("No area for beans");
        }

    }
}

