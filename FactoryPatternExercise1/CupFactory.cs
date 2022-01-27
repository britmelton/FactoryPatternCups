using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise1
{
    public class CupFactory 
    {


        //write a method that will produce a cup of whatever type we need 
        public static Cup GetCupType() 
        {
            Console.WriteLine($"What type of cup do you have?");
            var answer = Console.ReadLine();

            switch (answer.ToLower())
            {
                case "sippy cup":
                    return new SippyCup();
                case "mug":
                    return new Mug();
                case "tumbler":
                    return new Tumbler();
                default:
                    return new Cup();

            }
        }

     
    }
}
