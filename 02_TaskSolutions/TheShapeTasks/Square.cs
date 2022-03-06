namespace TheShapeTasks
{
    public class Square
    {
        private int length;


        // Constructor, called once when an instance of the class is made.
        public Square(int theLength)
        {
            SetLength(theLength);
        }


        public void SetLength(int theLength)
        {
            if (theLength >= 0) {
                length = theLength;
            } else {
                // In real life, we could throw an Exception (error message) here.
                length = 0;
            }
        }


        public int GetLength()
        {
            return length;
        }


        public int CalculateArea()
        {
            int area = length * length;
            return area;  // Or just: return length * length;
        }


        public int CalculateCircumference()
        {
            int area = 4 * length;
            return area;  // Or just: return 4 * length;
        }
    }
}
