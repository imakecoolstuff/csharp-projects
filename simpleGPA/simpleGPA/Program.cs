using static System.Console;

namespace simpleGPA
{
    class Program
    {
        static void Main(string[] args)
        {
            string inValue = "",
                   studentName = "";;

            Write("Please enter your name: ");
            studentName = ReadLine();

            float numTotalCredits = 0F, // Total number of credits received
                  currentCredit = 0F, // Number of credits earned currently
                  gpa = 0F,
                  numTotalPoints = 0F;

            char letterGrade = ' '; // Letter grade received

            while (inValue.ToUpper() != "YES")
            {
                try
                {
                    Write("Enter the class name: ");
                    inValue = ReadLine();

                    Write("Enter the credits for this class: ");

                    // Try to parse credits. If error, display it
                    currentCredit = float.Parse(ReadLine());

                    // Accumulate number of credits
                    numTotalCredits += currentCredit;
                    //numTotalPoints = numTotalCredits; // Initialize with num total credits to calculate gpa

                    Write("Enter the letter grade you achieved: ");
                    letterGrade = char.Parse(ReadLine());

                    switch (letterGrade)
                    {
                        case 'A':
                            numTotalPoints += 4.0F; // Multiply total credits entered by 4.0F
                            break;

                        case 'B':
                            numTotalPoints += 3.0F; // Same, but by 3.0F
                            break;

                        case 'C':
                            numTotalPoints += 2.0F; // Same, but by 2.0
                            break;

                        case 'D':
                            numTotalPoints += 1.0F; // Same, but by 1.0
                            break;

                        case 'F':
                            numTotalPoints += 0F;
                            break;

                        default:
                            break;
                    }

                    Write("Are you finished entering class data (yes or no): ");
                    inValue = ReadLine(); // Get input. If this changes to no, the loop is exited
                }
                catch (System.Exception e)
                {
                    WriteLine("Your program ended unexpectedly\nbecause of this error: " + e.Message);
                    break;
                }
            }

            numTotalPoints += numTotalCredits * numTotalPoints; // Calculate total points
            gpa = (float) numTotalPoints / (float) numTotalCredits; // Calculate GPA
            WriteLine(studentName + ", Your GPA is {0:F2}", gpa);
            ReadKey();
        }
    }
}
