using System.IO;

namespace TheShapeTasks
{
    public class Rectangle
    {
        // Fields
        // ------

        private int _shortSide;
        private int _longSide;


        // Properties
        // ----------

        public int ShortSide {
            get { 
                return _shortSide;
            } 
            set {
                if (value >= 0) {
                    _shortSide = value;
                } else {
                    _shortSide = 0;
                }
            } 
        }
        
        public int LongSide {
            get {
                return _longSide;
            }
            set {
                if (value >= 0) {
                    _longSide = value;
                } else {
                    _longSide = 0;
                }
            }
        }


        // Methods
        // -------

        // Constructor
        public Rectangle(int shortSide, int longSide)
        {
            ShortSide = shortSide;
            LongSide = longSide;
        }

        public int CalculateArea()
        {
            return ShortSide * LongSide;
        }

        public int CalculateCircumference()
        {
            return (2 * ShortSide) + (2 * LongSide);
        }

        public void SaveToFile(string fileName)
        {
            StreamWriter fileWriter = new(fileName);
            fileWriter.WriteLine($"\"shortSide\": {ShortSide}");
            fileWriter.WriteLine($"\"longSide\": {LongSide}");
            fileWriter.Close();
        }

        public void ReadFromFile(string fileName)
        {
            using (StreamReader fileReader = new(fileName)) {
                string fileLine;
                while ((fileLine = fileReader.ReadLine()) != null) {
                    string[] lineSplit = fileLine.Split(':');
                    if (lineSplit[0].Trim() == "\"shortSide\"") {
                        ShortSide = int.Parse(lineSplit[1].Trim());
                    } else if (lineSplit[0].Trim() == "\"longSide\"") {
                        LongSide = int.Parse(lineSplit[1].Trim());
                    }
                }
            }
        }
    }
}
