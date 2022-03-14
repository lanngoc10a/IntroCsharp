using System;
using System.Collections.Generic;
using E2_10.Objects;

namespace TheShapeTasks
{
    public class Program
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

            // From the example in the lesson - RECTANGLE
            // =======================================

            List<Rectangle> rectangleList = new();

            // Adding a square to the list:
            Rectangle myRectangle = new(3, 2);  // Giving the new square a starting length of 2 (for it's sides).
            myRectangle.SetLength(-3);  // This one (-3) will be corrected by the Setter-method, as negative values are not allowed according to that method.
            myRectangle.SetWidth(-3);
            rectangleList.Add(myRectangle);

            // Adding another square, through slightly shorter syntax:
            rectangleList.Add(new(4,3));

            Console.WriteLine($"Area of my 1st regtangle is: {rectangleList[0].CalculateArea()}");
            Console.WriteLine($"Circumference of my 1st rectangle is: {rectangleList[0].CalculateCircumference()}");
            Console.WriteLine($"Area of my 2nd rectangle is: {rectangleList[1].CalculateArea()}");
            Console.WriteLine($"Circumference of my 2nd rectangle is: {rectangleList[1].CalculateCircumference()}");
        }
    }
}

