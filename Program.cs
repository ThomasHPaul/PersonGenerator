using System;
using System.Collections.Generic;
using System.IO;

namespace PersonGenerator
{
    class Program
    {




        static void Main(string[] args)
        {
            string userInputString;
            int userInputInt;
            string name;
            string address;
            string email;
            string phone;
            string gender;
            StreamReader sr;
            List<string> femaleFirstNames = new List<string>();
            List<string> lastNames = new List<string>();
            List<string> maleFirstNames = new List<string>();
            List<string> streetAddresses = new List<string>();
            List<string> emailAddresses = new List<string>();
            List<string> phoneNumbers = new List<string>();

            //string femaleFirstNamesPath = @"C:\Users\TPaul9\source\repos\PersonGenerator\data\femaleFirstNames.txt";
            //string lastNamesPath = @"C:\Users\TPaul9\source\repos\PersonGenerator\data\lastNames.txt";
            //string maleFirstNamesPath = @"C:\Users\TPaul9\source\repos\PersonGenerator\data\maleFirstNames.txt";
            //string streetAddressPath = @"C:\Users\TPaul9\source\repos\PersonGenerator\data\streetAddress.txt";
            //string emailAddressPath = @"C:\Users\TPaul9\source\repos\PersonGenerator\data\emailAddress.txt";
            //string phoneNumbersPath = @"C:\Users\TPaul9\source\repos\PersonGenerator\data\phoneNumber.txt";

            string femaleFirstNamesPath = @"C:\Users\Hyper10n\source\repos\PersonGenerator\data\femaleFirstNames.txt";
            string lastNamesPath = @"C:\Users\Hyper10n\source\repos\PersonGenerator\data\lastNames.txt";
            string maleFirstNamesPath = @"C:\Users\Hyper10n\source\repos\PersonGenerator\data\maleFirstNames.txt";
            string streetAddressPath = @"C:\Users\Hyper10n\source\repos\PersonGenerator\data\streetAddress.txt";
            string emailAddressPath = @"C:\Users\Hyper10n\source\repos\PersonGenerator\data\emailAddress.txt";
            string phoneNumbersPath = @"C:\Users\Hyper10n\source\repos\PersonGenerator\data\phoneNumber.txt";

            using (sr = new StreamReader(femaleFirstNamesPath))
            {
                while ((name = sr.ReadLine()) != null)
                {
                    femaleFirstNames.Add(name);
                }
            }

            using (sr = new StreamReader(lastNamesPath))
            {
                while ((name = sr.ReadLine()) != null)
                {
                    lastNames.Add(name);
                }
            }

            using (sr = new StreamReader(maleFirstNamesPath))
            {
                while ((name = sr.ReadLine()) != null)
                {
                    maleFirstNames.Add(name);
                }
            }

            using (sr = new StreamReader(streetAddressPath))
            {
                while ((address = sr.ReadLine()) != null)
                {
                    streetAddresses.Add(address);
                }
            }

            using (sr = new StreamReader(emailAddressPath))
            {
                while ((email = sr.ReadLine()) != null)
                {
                    emailAddresses.Add(email);
                }
            }

            using (sr = new StreamReader(phoneNumbersPath))
            {
                while ((phone = sr.ReadLine()) != null)
                {
                    phoneNumbers.Add(phone);
                }
            }

            Console.WriteLine("Do you want to generate 1: Males or 2: Females?");
            userInputString = Console.ReadLine();

            bool validInt = int.TryParse(userInputString, out userInputInt);
            if (!validInt)
            {
                Console.WriteLine("Please enter a whole number ex. 1 or 2");
                Environment.Exit(0);
            }

            switch(userInputInt)
            {
                case 1:
                    gender = "male";
                    break;
                case 2:
                    gender = "female";
                    break;
                default:
                    Console.WriteLine("Please enter 1 or 2 only. System exiting");
                    Environment.Exit(0);
                    break; // maintains code compliance
            }

            userInputString = "";
            userInputInt = -1;
            Console.WriteLine($"How many {gender}s do you want to print to console?"); // FIXME: change in future version to offer printing to console or text file (or passing to another application?)
            Console.ReadLine(userInputString);

            validInt = false;
            validInt = int.TryParse(userInputString, out userInputInt);

            if (!validInt)
            {
                Console.WriteLine("Please enter a whole number ex. 1, 2, 50, etc...");
                Environment.Exit(0);
            }



            TryGet
            //Console.ReadLine(""); // FIXME: Add error checking should only be 1 or 2 (use switch) use tryParse with out keyword & variable

        }
    }
}


//1. ask user if they want to generate males, females, or both
//2. ask the user how many they want to generate
//3. ask the user if they want to print to console
//4. ask the user if they want to write results to file(ask for input)
//5. return the full path to file

//versionA: print results to console
//versionB: offer to store results in file
//versionC: ask for file paths to name for male, female, last names
//versionD: use console application
//versionE: use sqlite database to store(with LINQ) normalize to 3rd normal form (separate address for people, address)