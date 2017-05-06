using System;

class InstanceMethods //вързани с конкретни обекти
{
    static void Main()
    {
        //<object_name>.<method_name>(<parameters>)
        String sampleLower = new String('a', 5);
        String sampleUpper = sampleLower.ToUpper();

        Console.WriteLine(sampleLower); // aaaaa
        Console.WriteLine(sampleUpper); // AAAAA

        DateTime now = DateTime.Now;
        DateTime later = now.AddHours(8);

        Console.WriteLine("Now: {0}", now);
        Console.WriteLine("8 hours later: {0}", later);
    }
}
