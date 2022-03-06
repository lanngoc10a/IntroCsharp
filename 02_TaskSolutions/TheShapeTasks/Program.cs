using System;
using System.Collections.Generic;

namespace TheShapeTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // From the example in the lesson - SQUARE
            // =======================================

            List<Square> squareList = new();

            // Adding a square to the list:
            Square mySquare = new(2);  // Giving the new square a starting length of 2 (for it's sides).
            mySquare.SetLength(-3);  // This one (-3) will be corrected by the Setter-method, as negative values are not allowed according to that method.
            squareList.Add(mySquare);

            // Adding another square, through slightly shorter syntax:
            squareList.Add(new(3));

            Console.WriteLine($"Area of my 1st square is: {squareList[0].CalculateArea()}");
            Console.WriteLine($"Circumference of my 1st square is: {squareList[0].CalculateCircumference()}");
            Console.WriteLine($"Area of my 2nd square is: {squareList[1].CalculateArea()}");
            Console.WriteLine($"Circumference of my 2nd square is: {squareList[1].CalculateCircumference()}");


            // Task 2.7, 2.10 & 2.11 - RECTANGLE
            // =================================

            Rectangle rectangle = new(2, 3);  // Giving the new rectangle sides of length of 2 and 3.
            Console.WriteLine();  // To insert a blank line.
            Console.WriteLine($"Area of my rectangle is: {rectangle.CalculateArea()}");
            Console.WriteLine($"Circumference of my rectangle is: {rectangle.CalculateCircumference()}");

            // Writing to file - change to a fitting path for your computer:
            rectangle.SaveToFile(@"C:\_Code\HK\VAL227\02_TaskSolutions\RectangleData.txt");

            // Changing the size to something else:
            rectangle.LongSide = 10;
            rectangle.ShortSide = 5;
            Console.WriteLine($"Area of my rectangle is: {rectangle.CalculateArea()}");
            Console.WriteLine($"Circumference of my rectangle is: {rectangle.CalculateCircumference()}");

            // Reading from file - change to a fitting path for your computer:
            rectangle.ReadFromFile(@"C:\_Code\HK\VAL227\02_TaskSolutions\RectangleData.txt");
            Console.WriteLine($"Area of my rectangle is: {rectangle.CalculateArea()}");
            Console.WriteLine($"Circumference of my rectangle is: {rectangle.CalculateCircumference()}");


            // Task 2.7 & 2.10 - CIRCLE
            // ========================

            Circle circle = new(2.5);  // Chose to use decimal numbers for circles.
            Console.WriteLine();
            Console.WriteLine($"Area of my circle is: {circle.CalculateArea()}");
            Console.WriteLine($"Circumference of my circle is: {circle.CalculateCircumference()}");


            // Task 2.7 & 2.10 - TRIANGLE
            // ==========================

            Triangle triangle = new(2.0, 3.0, 4.0);  // Chose to use decimal numbers for trinagles as well.
            Console.WriteLine();  // To insert a blank line.
            Console.WriteLine($"Area of my triangle is: {triangle.CalculateArea()}");
            Console.WriteLine($"Circumference of my triangle is: {triangle.CalculateCircumference()}");
        }
    }
}


