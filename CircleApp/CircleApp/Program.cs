/**********************************************
 * Program: CircleApp
 * Programmer: Danny Jackson
 * Purpose: Calculate attributes of a circle
 * Description: Inputs radius and returns
 * other aspects of a circle
 * Date: 20/05/2017
 **********************************************/

using System;
using static System.Console;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const string PROMPT = "What is the radius of the circle? "; // Set prompt

            

            // Ask for radius
            Write(PROMPT);

            string inValue = "";
            inValue = ReadLine(); // Get input

            double radius = 0F; // Holds radius

            while (double.TryParse(inValue, out radius) == false)
            {
                Write(PROMPT); // Repeat prompt
                inValue = ReadLine(); // Get input again
            }
            
            // Instantiate new circle
            Circle circle = new Circle(radius);

            WriteLine("The diameter is {0}\nThe area is {1}\nThe circumference is {2}", 
                circle.GetDiameter().ToString("N2"), circle.GetArea().ToString("N2"), 
                circle.GetCircumference().ToString("N2"));

            ReadLine();
        }
    }
}
