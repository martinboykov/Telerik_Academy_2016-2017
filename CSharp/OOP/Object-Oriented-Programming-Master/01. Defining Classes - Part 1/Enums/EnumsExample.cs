using System;

public enum DayOfWeek
{
	Mon, Tue, Wed, Thu, Fri, Sat, Sun
  //  0   1    2    3    4    5   6
}

class EnumExample
{
	static void Main()
	{
		DayOfWeek day = DayOfWeek.Wed;
		Console.WriteLine(day); // Wed
		
		Console.WriteLine((int)day); // 2

		day = DayOfWeek.Mon;
		Console.WriteLine(++day); // Tue

		day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), "Mon");
		Console.WriteLine(day); // Mon
	}
}
