using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Devices_Database
{
    class Call
    {
        //field 
        private DateTime time;
        private int duration;
        private string phoneNumber;

        //constructor
        private Call()
        {
        }
        public Call(DateTime time, int duration, string phoneNumber)
        {
            this.Time = time;
            this.Duration = duration;
            this.PhoneNumber = phoneNumber;
        }

        //property
        public DateTime Time
        {
            get { return time; }
            set
            {
                time = value;
            }
        }
        public int Duration
        {
            get { return duration; }
            set
            {
                duration = value;
            }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                phoneNumber = value;
            }
        }

        //method
        
        public override string ToString()
        {
            StringBuilder callInformation = new StringBuilder();
            callInformation.AppendLine(@"  Call Information");
            callInformation.AppendLine(@"------------------------------------------------------------------------------------------------------------------------------------------------------------");
            callInformation.Append("| Time: " + this.time + " ");
            callInformation.Append("| Duration: " + this.duration + "sec. ");
            callInformation.AppendLine("| Dialed number: " + this.phoneNumber);
            callInformation.AppendLine(@"------------------------------------------------------------------------------------------------------------------------------------------------------------");
            return callInformation.ToString();
        }
    }
}
