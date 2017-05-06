using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Devices_Database
{
    class GSM
    {
        //field
        internal static readonly GSM iphone4S = new GSM("IPhone 4S", "Apple", 999.99m, "Steve Jobs", new Battery("A345PRW",68, 12,BatteryType.NiMH), new Display(5, 1600000));
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        Battery battery;
        Display display;
        private static decimal pricePerMinute = 0.37m;
        private List<Call> calls = new List<Call>();



        //constructor
        private GSM()
        {
            //not optional ---> must have a model and manufacturer
        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }
        public GSM(string model, string manufacturer, decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
        }
        public GSM(string model, string manufacturer, decimal price, string owner) : this(model, manufacturer, price, owner, null, null)
        {
        }
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery) : this(model, manufacturer, price, owner, battery, null)
        {
        }
        public GSM(string model, string manufacturer, decimal price, string owner, Display display) : this(model, manufacturer, price, owner, null, display)
        {
        }
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }


        //properties
        //#1
        public static GSM Iphone4S
        {
            get { return iphone4S; }
        }

        public string Model
        {
            get { return model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be empty!");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentException("Model too short! It should be at least 2 letters");
                }
                if (value.Length >= 50)
                {
                    throw new ArgumentException("Model too long! It should be less than 50 letters");
                }
                this.model = value;
            }
        }
        //#2
        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer' name cannot be empty!");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentException("Manufacturer' name is too short! It should be at least 2 letters");
                }
                if (value.Length >= 30)
                {
                    throw new ArgumentException("Manufacturer' name is too long! It should be less than 50 letters");
                }
                this.manufacturer = value;
            }
        }

        //#3
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0 || value > 5000)
                {
                    throw new ArgumentException("Invalid price! It should be in the range [0...5000].");
                }
                this.price = value;
            }
        }

        //#4
        public string Owner
        {
            get { return owner; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Owners' name is too short! It should be at least 2 letters");
                }
                if (value.Length >= 50)
                {
                    throw new ArgumentException("Owners' name is too long! It should be less than 50 letters");
                }
                foreach (char ch in value)
                {
                    if (!IsLetterAllowedInNames(ch))
                    {
                        throw new ArgumentException("Invalid owener's name! Use only letters, space and hyphen");
                    }
                }
                this.owner = value;
            }
        }
        //#5
        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }
        //#6
        public Display Display
        {
            get
            {
                return this.display;
            }
            private set
            {
                this.display = value;
            }
        }
        private bool IsLetterAllowedInNames(char ch)
        {
            bool isAllowed =
                char.IsLetter(ch) || ch == '-' || ch == ' ';
            return isAllowed;
        }


        //#7
        public List<Call> CallHistory
        {
            get
            {
                return new List<Call>(this.calls);
            }
        }




        //methods
        //#1
        public void AddCall(Call call)
        {
            this.calls.Add(call);
        }

        //#2
        public void DeleteCall(int callIndex)
        {
            calls.RemoveAt(callIndex);
        }

        //#3
        public void DeleteLongestCall()
        {
            double longestDuration = double.MinValue;
            Call selectedElement = null;
            foreach (Call call in this.calls)
            {
                if (call.Duration > longestDuration)
                {
                    longestDuration = call.Duration;
                    selectedElement = call;
                }
            }
            if (selectedElement != null)
            {
                this.calls.Remove(selectedElement);
            }
        }

        //#4
        public void ClearCallHistory()
        {
            calls.Clear();
        }



        //#5
        public void TotalCallPrice()
        {
            decimal allCallsInSecs = (decimal) (this.calls.Select(x => x.Duration).Sum());
            Console.WriteLine(@"  Total cost of calls");
            Console.WriteLine(new String('-', 156)); 
            Console.WriteLine("| {0}",((pricePerMinute * (allCallsInSecs / 60.0m)).ToString("C2", CultureInfo.CreateSpecificCulture(name: "bg-BG"))));
            Console.WriteLine(new String('-', 156));
        }



        //#6
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(@"  Mobile Phone Device");
            builder.AppendLine(new String('-', 156));
            builder.AppendLine(@"| Model          | " + this.model);
            builder.AppendLine(new String('-', 156));
            builder.AppendLine(@"| Manufacturer   | " + this.manufacturer);
            builder.AppendLine(new String('-', 156));
            if (price != 0)
            {
                builder.AppendLine(@"| Price          | " + this.price.ToString("C2", CultureInfo.CreateSpecificCulture(name: "bg-BG")));
                builder.AppendLine(new String('-', 156));
            }
            if (owner != null)
            {
                builder.AppendLine(@"| Owner          | " + this.owner);
                builder.AppendLine(new String('-', 156));
            }
            if (battery != null)
            {
                builder.AppendLine(@"| Battery        | " + this.battery);
                builder.AppendLine(new String('-', 156));
            }
            if (display != null)
            {
                builder.AppendLine(@"| Display        | " + this.display);
                builder.AppendLine(new String('-', 156));
            }

            return builder.ToString();
        }
       
    }
}
