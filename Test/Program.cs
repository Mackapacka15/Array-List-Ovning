using System.Collections.Generic;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string> { "Bowser", "Khaos", "Donkey Kong" };

            Random generator = new Random();

            System.Console.WriteLine(Names[generator.Next(0, Names.Count)]);

            string newName = "";
            while (newName != "exit")
            {
                for (int i = 0; i < Names.Count; i++)
                {
                    Console.WriteLine(Names[i]);
                }
                System.Console.WriteLine("Vem ska man lägga till?");
                newName = Console.ReadLine();
                Names.Add(newName);

            }



        }
    }
}
