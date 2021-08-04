using System;
using System.Collections.Generic;

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
        }
    }
}
