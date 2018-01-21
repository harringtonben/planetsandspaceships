using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planetsandspaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            

            List<string> lastPlanets = new List<string>() { "Uranus", "Neptune", "Pluto" };

            planetList.AddRange(lastPlanets);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            List<string> rockyPlanets = planetList.GetRange(0, 4).ToList();

            planetList.Remove("Pluto");

            foreach (var planet in planetList)
            {
                Console.WriteLine(planet);
            }

            Console.WriteLine();
            foreach (var planet in rockyPlanets)
            {
                Console.WriteLine(planet);
            }
        }
    }
}
