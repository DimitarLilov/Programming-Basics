using System;

    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Fax number: ");
            string faxNumber = Console.ReadLine();
            if (faxNumber == string.Empty)
            {
                faxNumber = "(no fax)";
            }
            Console.Write("Web site: ");
            string webSite = Console.ReadLine();
            Console.Write("Manager first name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Manager last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Manager age: ");
            byte managerAge = byte.Parse(Console.ReadLine());
            Console.Write("Manager number: ");
            string managerNumber = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}" ,companyAddress);
            Console.WriteLine("Tel. {0}" ,phoneNumber);
            Console.WriteLine("Fax: {0}" ,faxNumber);
            Console.WriteLine("Web site: {0}" ,webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2} , tel. {3})",managerFirstName ,managerLastName ,managerAge ,managerNumber);
        }
    }

