using System;
using static System.Console;

namespace CircleApp
{
    class Circle
    {
        const double PI = 3.14159; // Constant value of PI
        private double radius = 0F; // Holds radius

        public Circle()
        {
            radius = 0F;
        }

        public Circle(double theRadius)
        {
            radius = theRadius;
        }

        // Set and get radius
        public double Radius
        {
            set
            {
                radius = value;
            }

            get
            {
                return radius;
            }
        }

        // Get diameter of circle
        public double GetDiameter()
        {
            return radius * 2;   
        }

        // Get area of circle
        public double GetArea()
        {
            return PI * radius * radius;
        }

        // Get circumference of circle
        public double GetCircumference()
        {
            return 2 * PI * radius;
        }
    }
}
