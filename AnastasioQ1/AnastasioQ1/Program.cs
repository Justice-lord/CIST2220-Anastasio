/* Programmer: Tucker Anastasio (tanastasio@student.cnm.edu)
 * Program: Force calc between two objects
 * Date: 6/8/2026*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AnastasioQ1
{
    class Program
    {
        // helper functions
        private static string GetInput(string prompt)
        {
            Console.Write($"\n{prompt}: ");
            return Console.ReadLine();
        }
        public static void Main(string[] args)
        {
            string doAnother;
            do
            {
                // user input
                GravitationalForce UserForce = new GravitationalForce();

                UserForce.Name1 = GetInput("Name of Object 1");
                UserForce.Mass1 = double.Parse(GetInput($"Mass of {UserForce.Name1} in kg"));
                UserForce.Name2 = GetInput("Name of Object 2");
                UserForce.Mass2 = double.Parse(GetInput($"Mass of {UserForce.Name2} in kg"));
                UserForce.Distance = double.Parse(GetInput($"Distance between {UserForce.Name1} and {UserForce.Name2} in m"));

                // display results
                Console.WriteLine(UserForce.ToString());


                Console.Write("\nDo another? (Y/n)");
                doAnother = Console.ReadLine();

            } while (doAnother.ToUpper() == "Y");

            Console.WriteLine("\nThanks for using my program");
        }
    }
}
