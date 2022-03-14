using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_10.Objects
{
    public class Rectangle
    {
        private int length;
        private int width;


        // Constructor, called once when an instance of the class is made.
        public Rectangle(int theLength, int theWidth)
        {
            SetLength(theLength);
            SetWidth(theWidth);
        }


        public void SetLength(int theLength)
        {
            if (theLength >= 0)
            {
                length = theLength;
            }
            else
            {
                // In real life, we could throw an Exception (error message) here.
                length = 0;
            }
        }

        public void SetWidth(int theWidth)
        {
            if (theWidth >= 0)
            {
                width = theWidth;
            }
            else
            {
                // In real life, we could throw an Exception (error message) here.
                width = 0;
            }
        }

        public int GetLength()
        {
            return length;
        }


        public int CalculateArea()
        {
            int area = length * width;
            return area;  // Or just: return length * length;
        }


        public int CalculateCircumference()
        {
            int area = 2 * (length + width);
            return area;  // Or just: return 4 * length;
        }
    }
}
