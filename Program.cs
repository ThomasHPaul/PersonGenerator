using System;

namespace PersonGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            string[] lastNames = new string[10];
            string[] maleFirstNames = new string[10];
            string[] femailFirstNames = new string[10];
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