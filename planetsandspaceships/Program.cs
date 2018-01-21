using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>()
            {
                new Dictionary<string, string>
                {
                    { "Mariner 10", "Mercury"},
                    { "Messenger", "Mercury"},
                    { "BepiColombo", "Mercury"}
                },
                new Dictionary<string, string>
                {
                    { "Venera 1", "Venus"},
                    { "Mariner 1", "Veuns"},
                    { "Sputnik 19", "Venus"}
                }


            };

            
            

            //foreach (var planet in planetList)
            //{
            //    Console.WriteLine(planet);
            //}

            //Console.WriteLine();
            //foreach (var planet in rockyPlanets)
            //{
            //    Console.WriteLine(planet);
            //}
        }
    }
}
