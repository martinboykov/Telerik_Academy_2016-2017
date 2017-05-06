//Problem 2. Print Company Information

//A company has name, address, phone number, fax number, web site and manager.The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.
//Example input:

//program user
//Company name:	Telerik Academy
//Company address:	31 Al.Malinov, Sofia
//Phone number:	+359 888 55 55 555
//Fax number:	
//Web site:	http://telerikacademy.com/
//Manager first name:	Nikolay
//Manager last name:	Kostov
//Manager age:	25
//Manager phone:	+359 2 981 981
//Example output:

//Telerik Academy
//Address: 231 Al.Malinov, Sofia
//Tel. +359 888 55 55 555
//Fax: (no fax)
//Web site: http://telerikacademy.com/
//Manager: Nikolay Kostov(age: 25, tel. +359 2 981 981)

using System;

class PrintInformation
{
    static void Main()
    {
        Console.Write("Enter company’s name: ");
        string companyName = Console.ReadLine();

        Console.Write("Enter company’s address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Enter company’s phone number: ");
        string companyPhone = Console.ReadLine();

        string companyFax = null;
        Console.WriteLine("Do your company have a fax number?");
        Console.Write("Type 'Y' and 'y' for yes or 'N' and 'n' for no: ");
        char input = Console.ReadKey().KeyChar;
        Console.WriteLine();

        while (input != 'Y' & input != 'N' & input != 'y' & input != 'n')
        {

            Console.WriteLine();
            Console.Write("Type 'Y' and 'y' for yes or 'N' and 'n' for no: ");
            input = Console.ReadKey().KeyChar;
        }
        if (input == 'Y' || input == 'y')
        {
            Console.WriteLine();
            Console.Write("Enter company’s fax number: ");
            companyFax = Console.ReadLine();
        }
        else if (input == 'N' || input == 'n')
        {
            companyFax = "(no fax)";
            Console.WriteLine(companyFax);
        }
        Console.Write("Enter company’s web site: ");
        string companySite = Console.ReadLine();

        Console.Write("Enter manager’s first name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Enter manager’s second name: ");
        string managerSecondName = Console.ReadLine();

        Console.Write("Enter manager’s age: ");
        string managerAge = Console.ReadLine();

        Console.Write("Enter manager’s phone number: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Company name: {0}", companyName);
        Console.WriteLine("Company address: {0}", companyAddress);
        Console.WriteLine("Phone number: {0}", companyPhone);
        Console.WriteLine("Fax number: {0}", companyFax);
        Console.WriteLine("Web site: {0}", companySite);
        Console.Write("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerSecondName, managerAge, managerPhone);
    }
}