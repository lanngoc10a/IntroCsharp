using System;

namespace TheShapeTasks
{
    public class Circle
    {
        // Fields
        // ------

        private double _radius;


        // Properties
        // ----------

        public double Radius {
            get {
                return _radius;
            }
            set {
                if (value >= 0) {
                    _radius = value;
                } else {
                    _radius = 0;
                }
            }
        }


        // Methods
        // -------

        // Constructor
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
