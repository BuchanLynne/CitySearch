using System;

namespace CitySearch
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the start of the city name");

            string searchString = Console.ReadLine();

            ICityFinder finder = new CityFinder();

            var result = finder.Search(searchString);

            foreach (string l in result.NextLetters)
            {
                Console.WriteLine(l);
            }

            foreach (string city in result.NextCities)
            {
                Console.WriteLine(city);
            }

        }
    }
}
