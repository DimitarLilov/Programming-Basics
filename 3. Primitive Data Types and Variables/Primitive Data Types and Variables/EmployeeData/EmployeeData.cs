using System;


    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Dimitar";
            string lastName = "Lilov";
            byte age = 23;
            string gender = "m";
            ulong  personalID = 8306112507;
            ulong  number = 27563571;
            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " +lastName);
            Console.WriteLine("Age: " +age);
            Console.WriteLine("Gender: " +gender);
            Console.WriteLine("Personal ID: " +personalID);
            Console.WriteLine("Unique Employee number: " +number);
            //option two
            // Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID: {4}\nUnique Employee number: {5}", firstName, lastName, age, gender, personalID, number);

        }
    }

