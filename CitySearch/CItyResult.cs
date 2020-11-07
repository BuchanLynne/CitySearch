using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CitySearch
{
    public class CityResult : ICityResult
    {
        public ICollection<string> NextLetters { get; set; }
        public ICollection<string> NextCities { get; set; }

        public CityResult()
        {
            NextLetters = new Collection<string>();
            NextCities = new Collection<string>(); 
        }
    }

       
}
