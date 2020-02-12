using System;
using System.Collections.Generic;
using System.IO;

namespace PersonGenerator
{
    class Program
    {

        static void Main() /* Rosalyn analyzer recommended removal of Main( parameters ) */
        {
            string name;
            string address;
            string phone;
            int gender;
            string domain;
            int randomGender;
            bool isMale;

            StreamReader sr;
            List<string> femaleFirstNames = new List<string>();
            List<string> lastNames = new List<string>();
            List<string> maleFirstNames = new List<string>();
            List<string> streetAddresses = new List<string>();
            List<string> emailDomains = new List<string>();
            List<string> phoneNumbers = new List<string>();

            //string femaleFirstNamesPath = @"C:\Users\TPaul9\source\repos\PersonGenerator\data\femaleFirstNames.txt";
            //string lastNamesPath = @"C:\Users\TPaul9\source\repos\PersonGenerator\data\lastNames.txt";
            //string maleFirstNamesPath = @"C:\Users\TPaul9\source\repos\PersonGenerator\data\maleFirstNames.txt";
            //string streetAddressPath = @"C:\Users\TPaul9\source\repos\PersonGenerator\data\streetAddress.txt";
            //string emailDomainsPath = @"C:\Users\TPaul9\source\repos\PersonGenerator\data\emailDomains.txt";
            //string phoneNumbersPath = @"C:\Users\TPaul9\source\repos\PersonGenerator\data\phoneNumber.txt";

            string femaleFirstNamesPath = @"C:\Users\Hyper10n\source\repos\PersonGenerator\data\femaleFirstNames.txt";
            string lastNamesPath = @"C:\Users\Hyper10n\source\repos\PersonGenerator\data\lastNames.txt";
            string maleFirstNamesPath = @"C:\Users\Hyper10n\source\repos\PersonGenerator\data\maleFirstNames.txt";
            string streetAddressPath = @"C:\Users\Hyper10n\source\repos\PersonGenerator\data\streetAddress.txt";
            string emailDomainsPath = @"C:\Users\Hyper10n\source\repos\PersonGenerator\data\emailDomains.txt";
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

            using (sr = new StreamReader(emailDomainsPath))
            {
                while ((domain = sr.ReadLine()) != null)
                {
                    emailDomains.Add(domain);
                }
            }

            using (sr = new StreamReader(phoneNumbersPath))
            {
                while ((phone = sr.ReadLine()) != null)
                {
                    phoneNumbers.Add(phone);
                }
            }

            Console.WriteLine("Do you want to generate 1: Males or 2: Females or 3: Both?");
            bool validInt = int.TryParse(Console.ReadLine(), out gender);
            if (!validInt)
            {
                Console.WriteLine("Please enter a whole number ex. 1 or 2");
                Environment.Exit(0);
            }

            Console.WriteLine($"How many people do you want to print to console?"); // FIXME: change in future version to offer printing to console or text file (or passing to another application?)
            validInt = int.TryParse(Console.ReadLine(), out int userInputInt);

            if (!validInt)
            {
                Console.WriteLine("Please enter a whole number ex. 1, 2, 50, etc...");
                Environment.Exit(0);
            }

            string firstName;
            string lastName;
            int age;
            string streetAddress;
            string emailAddress;
            string phoneNumber;

            Random rnd = new Random();

            for (int i = 0; i < userInputInt; ++i)
            {
                if (gender == 1)
                {
                    /*  male  */
                    firstName = maleFirstNames[rnd.Next(maleFirstNames.Count)];
                    isMale = true;
                    
                }
                else if (gender == 2)
                {
                    /* female */
                    firstName = femaleFirstNames[rnd.Next(femaleFirstNames.Count)];
                    isMale = false;
                }
                else // Gender == 3 or any other integer
                {
                    randomGender = rnd.Next(1, 3);
                    if (randomGender == 1)
                    {
                        firstName = maleFirstNames[rnd.Next(maleFirstNames.Count)];
                        isMale = true;
                    }
                    else
                    {
                        firstName = femaleFirstNames[rnd.Next(femaleFirstNames.Count)];
                        isMale = false;
                    }
                }
                lastName = lastNames[rnd.Next(lastNames.Count)];

                name = $"{firstName}  {lastName}";
                age = rnd.Next(90);
                streetAddress = streetAddresses[rnd.Next(streetAddresses.Count)];
                emailAddress = (firstName.Substring(0, 1) + lastName + (age * 2).ToString()).ToLower() + "@" + emailDomains[rnd.Next(emailDomains.Count)];
                phoneNumber = phoneNumbers[rnd.Next(phoneNumbers.Count)];

                Person person = new Person(name, isMale, age, streetAddress, emailAddress, phoneNumber);
                person.Print();
            }
        }
    }
}


//1. ask user if they want to generate males, females, or both
//2. ask the user how many they want to generate
//3. ask the user if they want to print to console
//4. ask the user if they want to write results to file(ask for input)
//5. return the full path to file

//versionA: DONE - print results to console
//versionB: DONE - offer to print both genders
//verisonC: DONE - emailAddress is function of name and age @someDomain.topLevelDomain ex. first char of firstName + lastName @ some domain name
//versionD: offer to store results in file
//versionE: ask for file paths to name for male, female, last names
//versionF: use console application
//versionG: use sqlite database to store(with LINQ) normalize to 3rd normal form (separate address for people, address)

// Consider making area code align to address? (go by state?)