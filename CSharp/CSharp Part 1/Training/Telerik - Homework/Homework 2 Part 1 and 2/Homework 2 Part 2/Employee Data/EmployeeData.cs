using System;

class EmployeeData
{
    static void Main()
    {
        string FirstName = "Svetlin";
        string LastName = "Nakov";
        int age = 26;
        string gender = "male";
        long personalID = 8306112507;
        int uniqueEmployee = 27560000;

        Console.WriteLine("FirstName:" + FirstName);
        Console.WriteLine("LastName:" + LastName);
        Console.WriteLine("age:" + age);
        Console.WriteLine("gender:" + gender);
        Console.WriteLine("personalID:" + personalID);
        Console.WriteLine("uniqueEmployee:" + uniqueEmployee);

        //Console print:
        //FirstName = Svetlin
        //LastName = Nakov
        //age = null
        //gender = male
        //personalID = 8306112507
        //uniqueEmployee = 27560000
    }
}