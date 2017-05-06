using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Devices_Database
{
    class Display
    {
        //Fields
        private double size;
        private long numberOfColors;


        //Constructors
        public Display()
        {
        }
        public Display(double size)
        {
            this.Size = size;
        }
        public Display(double size, long numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        //Properties
        public double Size
        {
            get { return size; }
            set
            {
                if (value < 3 || value > 10)
                {
                    throw new ArgumentException("Invalid size of the display! It should be in the range [3...10].");
                }

                this.size = value;
            }
        }
        public long NumberOfColors
        {
            get { return numberOfColors; }
            set
            {
                if (value < 0 || value > 10000000000)
                {
                    throw new ArgumentException("Invalid number of the colors! It should be in the range [0...100000000000].");
                }
                this.numberOfColors = value;
            }
        }

        //Methods
        public override string ToString()
        {
            StringBuilder displayInfo = new StringBuilder();

            displayInfo.Append("Size: " + this.size + @"""");

            if (NumberOfColors != 0)
                displayInfo.Append(", Number of colors: " + this.numberOfColors.ToString("0.0E+0"));

            return displayInfo.ToString();
        }
    }
}
