using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


 class CarWars
 {
     static void Main(string[] args)
     {
         string[] cards = { "2","3","4","5","6","7","8","9","10","A","J","Q","K" }; // cards
         long[] values = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 11, 12, 13 };  // their according values

         int rounds = int.Parse(Console.ReadLine());

         string[] playCards = new string[6]; // this is used for collecting the players cards 0-2 for first player.. 3-5 for second player

         BigInteger roundScoreAlpha = 0; // score to determine user Alpha streight
         BigInteger roundScoreBeta = 0;  // round score for user Beta

         int winnerRoundAlpha = 0; // counters to know how many rounds were won by the winner
         int winnerRoundBeta = 0;

         int xJoker = 0;        // for the special card X - use this to compare players draws for x
         int xJokerBeta = 0;

         for (long i = 0; i < rounds; i++) // loops for the numbers of rounds
         {
             for (long y = 0; y < 6; y++)   // loop for collecting 6 cards each round
             {
                 playCards[i] = Console.ReadLine();

                 #region userALPHA score
                 if (y < 3)
                 {
                     switch (playCards[i])
                     {
                         case "2":
                             roundScoreAlpha += values[0];
                             break;
                         case "3":
                             roundScoreAlpha += values[1];
                             break;
                         case "4":
                             roundScoreAlpha += values[2];
                             break;
                         case "5":
                             roundScoreAlpha += values[3];
                             break;
                         case "6":
                             roundScoreAlpha += values[4];
                             break;
                         case "7":
                             roundScoreAlpha += values[5];
                             break;
                         case "8":
                             roundScoreAlpha += values[6];
                             break;
                         case "9":
                             roundScoreAlpha += values[7];
                             break;
                         case "10":
                             roundScoreAlpha += values[8];
                             break;
                         case "A":
                             roundScoreAlpha += values[9];
                             break;
                         case "J":
                             roundScoreAlpha += values[10];
                             break;
                         case "Q":
                             roundScoreAlpha += values[11];
                             break;
                         case "K":
                             roundScoreAlpha += values[12];
                             break;
                         case "Z":
                             roundScoreAlpha *= 2; // change
                             break;
                         case "Y":
                             roundScoreAlpha -= 200;  // change
                             break;
                         case "X":
                             xJoker++;  // change
                             break;
                         default: break;
                     }
                 }
                 #endregion

                 #region userBeta score
                 else if (y >= 3)
                 {
                     switch (playCards[i])
                     {
                         case "2":
                             roundScoreBeta += values[0];
                             break;
                         case "3":
                             roundScoreBeta += values[1];
                             break;
                         case "4":
                             roundScoreBeta += values[2];
                             break;
                         case "5":
                             roundScoreBeta += values[3];
                             break;
                         case "6":
                             roundScoreBeta += values[4];
                             break;
                         case "7":
                             roundScoreBeta += values[5];
                             break;
                         case "8":
                             roundScoreBeta += values[6];
                             break;
                         case "9":
                             roundScoreBeta += values[7];
                             break;
                         case "10":
                             roundScoreBeta += values[8];
                             break;
                         case "A":
                             roundScoreBeta += values[9];
                             break;
                         case "J":
                             roundScoreBeta += values[10];
                             break;
                         case "Q":
                             roundScoreBeta += values[11];
                             break;
                         case "K":
                             roundScoreBeta += values[12];
                             break;
                         case "Z":
                             roundScoreBeta *= 2; 
                             break;
                         case "Y":
                             roundScoreBeta -= 200;  
                             break;
                         case "X":
                             xJokerBeta++;  // change;  // change
                             break;
                         default: break;
                     }
                 }
                 #endregion
                 else
                 {
                     break;
                 }
             }

             if (xJoker == xJokerBeta && xJoker>0)
             {
                 roundScoreAlpha += 50;
                 roundScoreBeta += 50;
             }

             if (roundScoreAlpha > roundScoreBeta)   // those are the counters for the winner of each round
             {
                 winnerRoundAlpha++;
             }
             else if (roundScoreBeta > roundScoreAlpha)
             {
                 winnerRoundBeta++;
             }
             else // roundsBeta == roundAlpha
             {
                 winnerRoundAlpha = winnerRoundBeta = 0;
             }
         }

         if (xJoker > xJokerBeta)
         {
             Console.WriteLine("X card drawn! Player one wins the match!");
         }
         else if (xJokerBeta > xJoker)
         {
             Console.WriteLine("X card drawn! Player two wins the match!");
         }
         else
         {
             if (roundScoreAlpha > roundScoreBeta)
             {
                 Console.WriteLine("First player wins! ");
                 Console.WriteLine("Score: {0} ", roundScoreAlpha);  // this must me fixed
                 Console.WriteLine("Games won: {0}", winnerRoundAlpha); // insert a counter for this!!
                 Console.WriteLine();
             }
             else if (roundScoreBeta > roundScoreAlpha)
             {
                 Console.WriteLine("Second player wins! ");
                 Console.WriteLine("Score: {0} ", roundScoreBeta);  // this must me fixed
                 Console.WriteLine("Games won: {0}", winnerRoundBeta); // insert a counter for this!!
                 Console.WriteLine();
             }
             else if (roundScoreAlpha == roundScoreBeta)
             {
                 Console.WriteLine("It's a tie! ");
                 Console.WriteLine("Score: {0}", winnerRoundBeta);  // this must me fixed
                 Console.WriteLine();
             }
         }

     }
 }

