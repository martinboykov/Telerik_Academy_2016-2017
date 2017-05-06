//Problem 11. Bank Account Data

//A bank account has a holder name(first name, middle name and last name), available amount of money(balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Martin";
        string middleName = "Boykov";
        string lastName = "Martinov";
        decimal balance = 131213.14m;
        string bankName = "DSK";
        string IBAN = "BG80 BNBG 9661 1020 3456 78";
        long creditCardN1 = 1234567890123456;
        long creditCardN2 = 1234567890123457;
        long creditCardN3 = 1234567890123458;

        Console.WriteLine("first name: {0} \nmiddle name: {1} \nlast name: {2} \n\navailable amount of money(balance): {3} \n\nbank name: {4} \n\nIBAN: {5} \n\n3 credit card numbers: \ncredit card number one: {6} \ncredit card number two: {7} \ncredit card number three: {8}", firstName, middleName, lastName, balance, bankName, IBAN, creditCardN1, creditCardN2, creditCardN3);
    }
}