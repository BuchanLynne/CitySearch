using CitySearch;
using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SearchTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCitiesBang()
        {
            //arrange
            string searchTerm = "bang";
            ICityResult city = new CityResult();
            city.NextCities = new Collection<string>() {"BANGUI", "BANGKOK", "BANGALORE" };
            ICityFinder finder = new CityFinder();

            //act
            var result = finder.Search(searchTerm);

            //assert
            CollectionAssert.AreEqual(city.NextCities.ToList(), result.NextCities.ToList());
        }

        [TestMethod]
        public void TestLettersBang()
        {
            //arrange
            string searchTerm = "bang";
            ICityResult city = new CityResult();
            city.NextLetters = new Collection<string>() { "U", "K", "A" };
            ICityFinder finder = new CityFinder();

            //act
            var result = finder.Search(searchTerm);

            //assert
            CollectionAssert.AreEqual(city.NextLetters.ToList(), result.NextLetters.ToList());

        }

        [TestMethod]
        public void TestCitiesLa()
        {
            //arrange
            string searchTerm = "la";
            ICityResult city = new CityResult();
            city.NextCities = new Collection<string>() { "LA PAZ", "LA PLATA", "LAGOS" };
            ICityFinder finder = new CityFinder();

            //act
            var result = finder.Search(searchTerm);

            //assert
            CollectionAssert.AreEqual(city.NextCities.ToList(), result.NextCities.ToList());

        }

        [TestMethod]
        public void TestLettersLa()
        {
            //arrange
            string searchTerm = "la";
            ICityResult city = new CityResult();
            city.NextLetters = new Collection<string>() { " ", "G" };
            ICityFinder finder = new CityFinder();

            //act
            var result = finder.Search(searchTerm);

            //assert
            CollectionAssert.AreEqual(city.NextLetters.ToList(), result.NextLetters.ToList());

        }

        [TestMethod]
        public void TestCitiesZe()
        {
            //arrange
            string searchTerm = "ze";
            ICityResult city = new CityResult();
            city.NextCities = new Collection<string>() { };
            ICityFinder finder = new CityFinder();

            //act
            var result = finder.Search(searchTerm);

            //assert
            CollectionAssert.AreEqual(city.NextCities.ToList(), result.NextCities.ToList());

        }

        [TestMethod]
        public void TestLettersZe()
        {
            //arrange
            string searchTerm = "ze";
            ICityResult city = new CityResult();
            city.NextLetters = new Collection<string>() {  };
            ICityFinder finder = new CityFinder();

            //act
            var result = finder.Search(searchTerm);

            //assert
            CollectionAssert.AreEqual(city.NextLetters.ToList(), result.NextLetters.ToList());

        }

        [TestMethod]
        public void TestCitiesGivenFullCity()
        {
            //arrange
            string searchTerm = "zhughai";
            ICityResult city = new CityResult();
            city.NextCities = new Collection<string>() { "ZHUGHAI" };
            ICityFinder finder = new CityFinder();

            //act
            var result = finder.Search(searchTerm);

            //assert
            CollectionAssert.AreEqual(city.NextCities.ToList(), result.NextCities.ToList());

        }

        [TestMethod]
        public void TestLettersGivenFullCity()
        {
            //arrange
            string searchTerm = "zhughai";
            ICityResult city = new CityResult();
            city.NextLetters = new Collection<string>() { };
            ICityFinder finder = new CityFinder();

            //act
            var result = finder.Search(searchTerm);

            //assert
            CollectionAssert.AreEqual(city.NextLetters.ToList(), result.NextLetters.ToList());

        }

        [TestMethod]
        public void TestCitiesGivenEmptyString()
        {
            //arrange
            string searchTerm = "";
            ICityResult city = new CityResult();
            
            for (int i = 0; i < 1000000; i++)
            {
                city.NextCities.Add(i.ToString());
            }

            city.NextCities.Add("BANDUNG");
            city.NextCities.Add("BANGUI");
            city.NextCities.Add("BANGKOK");
            city.NextCities.Add("BANGALORE");
            city.NextCities.Add("LA PAZ");
            city.NextCities.Add("LA PLATA");
            city.NextCities.Add("LAGOS");
            city.NextCities.Add("LEEDS");
            city.NextCities.Add("ZARIA");
            city.NextCities.Add("ZHUGHAI");
            city.NextCities.Add("ZIBO");

            ICityFinder finder = new CityFinder();

            //act
            var result = finder.Search(searchTerm);

            //assert
            CollectionAssert.AreEqual(city.NextCities.ToList(), result.NextCities.ToList());

        }

        [TestMethod]
        public void TestLettersGivenEmptyString()
        {
            //arrange
            string searchTerm = "";
            ICityResult city = new CityResult();
            city.NextLetters = new Collection<string>() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "B", "L", "Z" };
            ICityFinder finder = new CityFinder();

            //act
            var result = finder.Search(searchTerm);

            //assert
            CollectionAssert.AreEqual(city.NextLetters.ToList(), result.NextLetters.ToList());

        }

    }
}
