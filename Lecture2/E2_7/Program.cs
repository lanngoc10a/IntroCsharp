

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
           
        }
    }
}
