using System;

    class BankAccountData
    {
        static void Main()
        {
            string firstName = "Dimitar";
            string middleName = "Kirilov";
            string lastName = "Lilov";
            int available = 1000000;
            int balance = 1000000;
            string bankName = "Unicredit Bulbank";
            string iban = "BG80 BNBG 9661 1020 3456 78";
            ulong cardNumber1 = 5322201225297013;
            ulong cardNumber2 = 5322201225297014;
            ulong cardNumber3 = 5322201225297017;
            Console.WriteLine("First Name: {0}\nMiddle Name: {1}\nLast Name {2}\nAvailable: {3:C}\nBalance: {4:C}\nBank Name: {5}\nIBAN: {6}\nCard Number 1: {7}\nCard Number 2: {8}\nCard Number 3: {9}",firstName, middleName, lastName, available, balance, bankName, iban, cardNumber1, cardNumber2, cardNumber3);

        }
    }

