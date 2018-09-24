/* ************************************************************
 * Program: FertCalc                                          *
 * Programmer: Danny Jackson                                  *
 * Purpose: Calculate amount of pounds of fertilizer needed   *
 * Description: Takes inputs, calculates and displays result  *
 * ************************************************************
 */

using System;
using static System.Console;

namespace FertCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = ""; // Set up input variable

            int yardLength = 0, // Declare yard length and width variables
                yardWidth = 0;

            double percentOfNitrogen = 0F, // Percent of Nitrogen in fertilizer
                   numberOfPoundsOfNitrogenNeeded = 0F,
                   numberOfPoundsOfFertilizerNeeded = 0F;

            try
            {
                // Ask for the length of the yard
                WriteLine("What is the length of your yard?");
                // Get input
                input = ReadLine();
                // Parse
                yardLength = int.Parse(input);
                // Ask for the width of the yard
                WriteLine("What is the width of your yard?");
                // Get input
                input = ReadLine();
                // Parse
                yardWidth = int.Parse(input);
                // Ask for percentage of Nitrogen
                WriteLine("What is the percentage of Nitrogen in the fertilizer?");
                // Get input
                input = ReadLine();
                // Parse
                percentOfNitrogen = int.Parse(input);
                percentOfNitrogen /= 100; // Convert to decimal
                WriteLine(percentOfNitrogen); // Display percent of nitrogen
                // Calculate number of pounds of Nitrogen needed
                numberOfPoundsOfNitrogenNeeded = (double) yardLength * (double) yardWidth / 1000F;
                // Calculate number of pounds of fertilizer needed
                numberOfPoundsOfFertilizerNeeded = (double) numberOfPoundsOfNitrogenNeeded / (double) percentOfNitrogen;
                // Display total
                WriteLine("\t-> The total number of pounds of fertilizer you need is: {0:f2}", numberOfPoundsOfFertilizerNeeded);
                // Wait for Enter key
                ReadLine();
            }
            catch (Exception e)
            {
                // Write any exceptions to console screen
                WriteLine(e.Message);
            }
        }
    }
}
