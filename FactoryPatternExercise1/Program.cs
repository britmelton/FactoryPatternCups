using System;

namespace FactoryPatternExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var newCup = CupFactory.GetCupType();
          
            Console.WriteLine(newCup.TipOver());

           

        }
    }
}
