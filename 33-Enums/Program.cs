using System;

namespace _33_Enums
{
    internal class Program
    {
        // Enums = special "class" that represents a group of constants (unchangeable/read-only variables).
        static void Main(string[] args)
        {
            Console.WriteLine(Planets.Earth + " is planet #" + (int)Planets.Earth);

            string name = PlanetRadius.Earth.ToString();
            int radius = (int)PlanetRadius.Earth;
            double volume = Volume(PlanetRadius.Earth);

            Console.WriteLine("planet: " + name);
            Console.WriteLine("radius: " + radius + " km");
            Console.WriteLine("volume: " + volume + " km^3 \n");

            foreach(PlanetRadius p in Enum.GetValues(typeof(PlanetRadius)))
            {
                Console.WriteLine($"{p} radius: {(int)p} km");
                Console.WriteLine($"{p} volume: {Volume(p)} km^3 \n");
            }

            Console.ReadKey();
        }

        public static double Volume(PlanetRadius radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }
    }

    enum Planets
    {
        Mercury = 1,
        Venus = 2,
        Earth = 3,
        Mars = 4,
        Jupiter = 5,
        Saturn = 6,
        Uranus = 7,
        Neptune = 8,
        Pluto = 9
    }

    enum PlanetRadius 
    {
        // in kilometers
        Mercury = 2439,      
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622,
        Pluto = 1188
    }
}
