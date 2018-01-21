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

            Dictionary<string, string> probes = new Dictionary<string, string>()
            {

                    { "Mariner 10", "Mercury" },
                    { "Messenger", "Mercury" },
                    { "BepiColombo", "Mercury" },
                    { "Venera 1", "Venus" },
                    { "Mariner 1", "Veuns" },
                    { "Sputnik 19", "Venus" },
                    { "Giotto", "Earth"},
                    { "Galileo", "Earth" },
                    { "Rosetta", "Earth" },
                    { "Mars 1", "Mars" },
                    { "Mariner 3", "Mars" },
                    { "Zond 2", "Mars" },
                    { "Voyager 1", "Jupiter" },
                    { "Pioneer 10", "Jupiter" },
                    { "Juno", "Jupiter" },
                    { "Voyager 2", "Saturn" },
                    { "Titan", "Saturn" },
                    { "Huygens", "Saturn" }
            };

            foreach (var planet in planetList)
            {
                Console.Write($"{planet}:");
                foreach (var probe in probes)
                {
                    if (probe.Value == planet)
                    {
                        Console.Write($" {probe.Key},");
                    }
                }
                Console.Write("\b \b");
                Console.WriteLine();
            }
        }
    }
}
