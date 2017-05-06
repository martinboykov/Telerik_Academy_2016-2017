using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Devices_Database
{
    public enum BatteryType
    {
        Li_Ion, NiMH, NiCd
    }
    class Battery
    {
        //Fields
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        public BatteryType type;


        //Constructors
        public Battery()
        {
        }
        public Battery(string model) : this(model, 0, 0, 0)
        {
            this.Model = model;
        }
        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType type)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.type = type;
        }

        //Properties
        public string Model
        {
            get { return model; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Models' name is too short! It should be at least 2 letters");
                }
                if (value.Length >= 20)
                {
                    throw new ArgumentException("Models' name is too long! It should be less than 50 letters");
                }
                this.model = value;
            }
        }
        
        public int HoursIdle
        {
            get { return hoursIdle; }
            set
            {
                if (value < 0 || value > 1000)
                {
                    throw new ArgumentException("Invalid hours for idle time! It should be in the range [0...1000].");
                }
                this.hoursIdle = value;
            }
        }
        public int HoursTalk
        {
            get { return hoursTalk; }
            set
            {
                if (value < 0 || value > 1000)
                {
                    throw new ArgumentException("Invalid hours for talk time! It should be in the range [0...1000].");
                }
                this.hoursTalk = value;
            }
        }
        public BatteryType Type
        {
            get { return type; }
        }
        //methods
        public override string ToString()
        {
            StringBuilder batteryInfo = new StringBuilder();
            
                batteryInfo.Append("Model: " + this.model);
            if (hoursIdle != 0)
                batteryInfo.Append(", Hours idle: " + this.hoursIdle);
            if (hoursTalk != 0)
                batteryInfo.Append(", Hours talk: " + this.hoursTalk);
            if (type != 0)
                batteryInfo.Append(", Type: " + this.type);

            return batteryInfo.ToString();
        }

    }
}
