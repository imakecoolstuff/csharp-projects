using System;
using static System.Console;

namespace quizScores
{
    class Program
    {
        static string studentName = ""; // Declare student's name variable

       // Input scores
        public static int[] GetScores(int[] quizScore)
        {
            WriteLine(); // Format

            for (int i = 0; i < quizScore.Length; i++)
            {
                Write("Please enter {0}\'s score for test {1}\t", studentName, i + 1);

                // Prime read
                string inValue = ReadLine();
                int score = 0;

                while (int.TryParse(inValue, out score) == false)
                {

                    WriteLine("Must enter a whole number");
                    Write("Please enter {0}\'s score for test {1}\t", studentName, i + 1);
                    inValue = ReadLine(); // Get quiz score and save into array
                }

                quizScore[i] = score;
            }

            return quizScore; // Return array
        }

        // Returns average of quizz scores as double
        public static double FindAverage(int[] quizScore)
        {
            int total = 0;

            for (int i = 0; i < quizScore.Length; i++)
            {
                total += quizScore[i];
            }

            // Return avearage
            return (double) total / (double) quizScore.Length;
        }

        // Displays scores and their average
        public static void ShowData(int[] quizScore)
        {
            WriteLine(); // Insert blank line for formatting

            for (int i = 0; i < quizScore.Length; i++)
            {
                WriteLine("{0}\'s score at position {1}: {2}", studentName, i + 1, quizScore[i]);
            }

            WriteLine("The average is: {0}", FindAverage(quizScore));
        }

        static void Main(string[] args)
        {
            int[] score = new int[5];

            WriteLine("\n\tThis program stores a student's score on 5 quizzes.\n");

            string inValue = ""; // Declare inValue

            do
            {
                Write("What is the stuedent's name?\t");
                studentName = ReadLine(); // Get student's name
                score = GetScores(score);
                ShowData(score);

                WriteLine("\nWould you like to store another student\'s scores?");
                Write("Press Y for yes or any other key for No.\t");
                inValue = ReadLine();
                WriteLine(); // Leave blank
            } while (inValue == "Y" || inValue == "y");
        }
    }
}
