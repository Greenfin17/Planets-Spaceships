using System;
using System.Collections.Generic;
using System.Linq;

namespace Planets_Spaceships
{
    class Program
    {
        static void Main(string[] args)
        {
         
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            var lastTwoPlanets = new List<string>() { "Uranus", "Neptune" };
            planetList.AddRange(lastTwoPlanets);
            planetList.Insert(1, "Earth");
            planetList.Insert(1, "Venus");
            planetList.Add("Pluto");

            var rockyPlanets = planetList.GetRange(0, 4);
            Console.WriteLine("The planets are:");
            planetList.ForEach(planet => Console.WriteLine(planet));
            Console.WriteLine("The rocky planets are:");
            rockyPlanets.ForEach(planet => Console.WriteLine(planet));

            planetList.Remove("Pluto");

            Console.WriteLine("Pluto is no longer considered a planet.  Our new list is:");
            planetList.ForEach(planet => Console.WriteLine(planet));

            var probeList = new Dictionary<string, List<string>>();
            var mariner10 = new List<string>() { "Mercury" };
            var messenger = new List<string>() { "Mercury" };
            var spirit = new List<string>() { "Mars" };
            var opportunity = new List<string>() { "Mars" };
            var rosetta = new List<string>() { "Mars" };
            var phoenix = new List<string>() { "Mars" };
            var dawn = new List<string>() { "Mars" };
            var viking1 = new List<string>() { "Mars" };
            var viking2 = new List<string>() { "Mars" };
            var odyssey = new List<string>() { "Mars" };
            var pioneer10 = new List<string>() { "Jupiter"};
            var pioneer11 = new List<string>() { "Jupiter", "Saturn"};
            var voyager1 = new List<string>() { "Jupiter", "Saturn" };
            var voyager2 = new List<string>() { "Jupiter", "Saturn", "Uranus", "Neptune" };
            var ulysses = new List<string>() { "Jupiter"};
            var galileo = new List<string>() { "Jupiter"};
            var cassini = new List<string>() { "Jupiter", "Saturn" };

            probeList.Add("Mariner 10", mariner10);
            probeList.Add("Messenger", messenger);
            probeList.Add("Spirit", spirit);
            probeList.Add("Opportunityi", opportunity);
            probeList.Add("Rosetta", rosetta);
            probeList.Add("Phoenix", phoenix);
            probeList.Add("Dawn", dawn);
            probeList.Add("Viking1", viking1);
            probeList.Add("Viking2", viking2);
            probeList.Add("Odyssey", odyssey);
            probeList.Add("Pioneer10", pioneer10);
            probeList.Add("Pioneer11", pioneer11);
            probeList.Add("Voyager1", voyager1);
            probeList.Add("Voyager2", voyager2);
            probeList.Add("Ulysses", ulysses);
            probeList.Add("Galileo", galileo);
            probeList.Add("Cassini", cassini);


            foreach(var planet in planetList)
            {
                // bool found = false;
                Console.Write($"Spacecraft that have visited {planet}: ");
                var probes = probeList.Where(entry => entry.Value.Contains(planet));
                foreach (var probe in probes)
                {
                    if (probe.Value.Count > 0)
                    {
                        Console.Write($"{probe.Key}, ");
                    }
                } 
                if(probes.Count() == 0)
                {
                    Console.Write("No probes");
                }
                Console.Write('\n');
            }
        }
    }
}
