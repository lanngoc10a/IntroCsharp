using System;

namespace TheShapeTasks
{
    internal class Triangle
    {
        // Fields
        // ------

        private double _sideA;
        private double _sideB;
        private double _sideC;


        // Properties
        // ----------

        public double SideA {
            get {
                return _sideA;
            }
            set {
                if (value >= 0) {
                    _sideA = value;
                } else {
                    _sideA = 0;
                }
            }
        }

        public double SideB {
            get {
                return _sideB;
            }
            set {
                if (value >= 0) {
                    _sideB = value;
                } else {
                    _sideB = 0;
                }
            }
        }

        public double SideC {
            get {
                return _sideC;
            }
            set {
                if (value >= 0) {
                    _sideC = value;
                } else {
                    _sideC = 0;
                }
            }
        }


        // Methods
        // -------

        // Constructor
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double CalculateArea()
        {
            // Using Heron's Formula: https://www.cuemath.com/herons-formula/
            double semiPerimeter = CalculateCircumference() / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }

        public double CalculateCircumference()
        {
            return SideA + SideB + SideC;
        }
    }
}
