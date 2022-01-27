using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise1
{
    public class Tumbler : Cup
    {
        public bool Insulation { get; set; }

        public override string TipOver()
        {
            return "spills a little";
        }
  
    }
}
