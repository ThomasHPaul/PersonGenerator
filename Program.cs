using System;
using System.Collections.Generic;
using System.IO;

namespace PersonGenerator
{
    class Program
    {




        static void Main(string[] args)
        {
            string name;
            StreamReader sr;
            List<string> femaleFirstNames = new List<string>();
            List<string> lastNames = new List<string>();
            List<string> maleFirstNames = new List<string>();

            string femaleFirstNamesPath = @"C:\Users\TPaul9\source\repos\PersonGenerator\data\femaleFirstNames.txt";
            string lastNamesPath = @"C:\Users\TPaul9\source\repos\PersonGenerator\data\lastNames.txt";
            string maleFirstNamesPath = @"C:\Users\TPaul9\source\repos\PersonGenerator\data\maleFirstNames.txt";

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