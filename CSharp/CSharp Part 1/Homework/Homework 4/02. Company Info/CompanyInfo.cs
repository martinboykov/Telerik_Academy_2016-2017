using System;

class CompanyInfo
{
    static void Main()
    {
        //Console.Write("Enter company’s name: ");
        string companyName = Console.ReadLine();

        //Console.Write("Enter company’s address: ");
        string companyAddress = Console.ReadLine();

        //Console.Write("Enter company’s phone number: ");
        string companyPhone = Console.ReadLine();

        //Console.Write("Enter company’s fax number: ");
        string companyFax = Console.ReadLine();
        
        //Console.Write("Enter company’s web site: ");
        string companySite = Console.ReadLine();

        //Console.Write("Enter manager’s first name: ");
        string managerFirstName = Console.ReadLine();

        //Console.Write("Enter manager’s second name: ");
        string managerSecondName = Console.ReadLine();

        //Console.Write("Enter manager’s age: ");
        string managerAge = Console.ReadLine();

        //Console.Write("Enter manager’s phone number: ");
        string managerPhone = Console.ReadLine();
        if (companyFax=="")
        {
            companyFax = "(no fax)";
        }

        Console.WriteLine();
        Console.WriteLine("{0}", companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", companyPhone);
        Console.WriteLine("Fax: {0}", companyFax);
        Console.WriteLine("Web site: {0}", companySite);
        Console.Write("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerSecondName, managerAge, managerPhone);
    }
}