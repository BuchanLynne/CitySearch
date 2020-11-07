using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CitySearch
{
    public class CityFinder: ICityFinder
    {
        
        public ICityResult Search(string searchString)
        {
            searchString = searchString.ToUpper();

            ICollection<string> cities = new HashSet<string>();

            for (int i = 0; i < 1000000; i++)
            {
                cities.Add(i.ToString());
            }


            cities.Add("BANDUNG");
            cities.Add("BANGUI");
            cities.Add("BANGKOK");
            cities.Add("BANGALORE");
            cities.Add("LA PAZ");
            cities.Add("LA PLATA");
            cities.Add("LAGOS");
            cities.Add("LEEDS");
            cities.Add("ZARIA");
            cities.Add("ZHUGHAI");
            cities.Add("ZIBO");


            ICityResult cityResult = new CityResult();

            foreach (string c in cities)
            {
                if (c.Contains(searchString))
                {
                    cityResult.NextCities.Add(c);

                    if (searchString != c)
                    {
                        string letter = c.Substring(searchString.Length, 1);

                        if (!cityResult.NextLetters.Contains(letter))
                        {
                            cityResult.NextLetters.Add(letter);
                        }    
                    }              
                }
            }
            return cityResult;
        }
    }
}
