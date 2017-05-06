using System;

class EmployeeData2
{
    static void Main()
    {
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter your age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Enter your gender (m/f): ");
        char gender = char.Parse(Console.ReadLine());
        Console.Write("Enter your personal ID: ");
        long personalID = long.Parse(Console.ReadLine());
        int uniqueEmployeeNumber = 0;
        do
        {
            Console.WriteLine("Enter unique employee number within scope (27560000…27569999): ");
            uniqueEmployeeNumber = int.Parse(Console.ReadLine());
        }
        while (uniqueEmployeeNumber < 27560000 || uniqueEmployeeNumber > 27569999);
        Console.WriteLine("\nYour personal data is: \nFirst name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID: {4}\nUniqueEmployeeNumber: {5}", firstName, lastName, age, gender, personalID, uniqueEmployeeNumber);
    }
}