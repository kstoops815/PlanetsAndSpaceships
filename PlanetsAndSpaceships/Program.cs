using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");


            List<string> lastTwoPlanets = new List<string>() { "Uranus", "Neptune"};

            planetList.AddRange(lastTwoPlanets);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");

            Console.WriteLine("All planets list");
            foreach (var item in planetList)
            {
                Console.WriteLine(item);
            }

            //Use getRange to remove the rocky planets and create a rockyPlanets list

            List<string> rockyPlanets = planetList.GetRange(0, 3);

            Console.WriteLine("Rocky Planets list");
            foreach (var rockyPlanet in rockyPlanets)
            {
                Console.WriteLine(rockyPlanet);

            }
            //Remove Pluto from planet list
            Console.WriteLine("Pluto removed from list");

            planetList.Remove(planetList.Last());

            foreach (var planet in planetList)
            {
                Console.WriteLine(planet);
            }
            
            Console.Read();
        }
    }
}
