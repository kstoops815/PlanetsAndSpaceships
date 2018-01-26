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

            foreach (var item in planetList)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
