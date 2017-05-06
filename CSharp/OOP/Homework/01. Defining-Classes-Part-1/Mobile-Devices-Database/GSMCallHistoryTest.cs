using System;

namespace Mobile_Devices_Database
{
    class GSMCallHistoryTest
    {
        public static void Run()
        {
            Console.WriteLine(new String('-', 156));
            Console.Write(new String('/', 67));
            Console.Write("| CALL-HISTORY TEST |");
            Console.WriteLine(new String('/', 67));
            Console.WriteLine(new String('-', 156));
            GSM random = new GSM(model: "S6", manufacturer: "Samsung", price: 999.99m, owner: "Se moa", display: new Display(5.5));
            
            random.AddCall(new Call(new DateTime(year: 2016, month: 6, day: 6, hour: 12, minute: 35, second: 10), duration: 258, phoneNumber: "0877777777"));
            random.AddCall(new Call(new DateTime(year: 2016, month: 6, day: 7, hour: 21, minute: 44, second: 33), duration: 259, phoneNumber: "0889237239"));
            random.AddCall(new Call(new DateTime(year: 2016, month: 6, day: 8, hour: 01, minute: 24, second: 55), duration: 261, phoneNumber: "0885773452"));
            Console.WriteLine(random);
            for (int i = 0; i < random.CallHistory.Count; i++)
            {
                Console.WriteLine(random.CallHistory[i]);
            }
            random.TotalCallPrice();
            random.DeleteLongestCall();
            random.DeleteCall(1);
            random.TotalCallPrice();
            for (int i = 0; i < random.CallHistory.Count; i++)
            {
                Console.WriteLine(random.CallHistory[i]);
            }
        }
    }
}
