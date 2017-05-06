using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mobile_Devices_Database
{
    class GSMTest
    {
        public static void Run()
        {
            Console.WriteLine(new String('-', 156));
            Console.Write(new String('/', 72));
            Console.Write("| GSM TEST |");
            Console.WriteLine(new String('/', 72));
            Console.WriteLine(new String('-', 156));
            
             List<GSM> mobileDevices = new List<GSM>();
            
            // add Device №1
            try
            {
                mobileDevices.Add(new GSM(model: "S6", manufacturer: "Samsung", price: 999.99m, owner: "Dalai Lama", display: new Display(5.5)));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot create new device: " + ex);
            }
            // add Device №2
            try
            {
                mobileDevices.Add(new GSM(model: "One S", manufacturer: "Letv", price: 700.00m, owner: "Marlon Brando", battery: new Battery("S4Iop", 68, 9, BatteryType.Li_Ion), display: new Display(5.5, 16000000)));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot create new device: " + ex);
            }
            foreach (var device in mobileDevices)
            {
                Console.WriteLine(device);
            }
            // Device №3
            //Display information about IPhone 4S
            Console.WriteLine(GSM.iphone4S);

        }
    }
}
