/*
Project:    Lab 2 Calculate Batting Average
Date:        to/da/y
Author:     You the big new programmer
Notes:      This program reads in a baseball player's name,
            number of hits and number of at bats.
            The player's batting average is calculated and displayed
*/

using System;

namespace SD_104_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable declaration
            string strPlayerName;
            double nHints, nAtBats;
            double dblBattingAverage;

            // prompt for name and receive
            Console.WriteLine("This program calculates a baseball player's batting average");
            Console.WriteLine("<--------------------------------------------------------->");
            Console.WriteLine("");

            //initialize variables
            strPlayerName = "";

            while (strPlayerName.ToLower() != "exit")
            {
                // prompt USER name
                Console.Write("Enter the player's name or Type 'exit' to quit: ");
                strPlayerName = Console.ReadLine();

                if (strPlayerName.ToLower() == "exit") { break; }

                // prompt for hits, walks and bats
                do
                {
                    Console.Write("Enter the player's number of hits: ");
                } while ((!double.TryParse(Console.ReadLine(), out nHints)));

                do
                {
                    Console.Write("Enter the player's number of at bats: ");
                } while ((!double.TryParse(Console.ReadLine(), out nAtBats)));


                // Calculate
                dblBattingAverage = nHints / nAtBats;

                Console.WriteLine(strPlayerName + "'s batting average is {0:F}",dblBattingAverage + " %");
                Console.WriteLine();
            }
        }
    }
}
