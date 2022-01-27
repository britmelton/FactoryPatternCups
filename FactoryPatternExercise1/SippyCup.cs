using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise1
{
    public class SippyCup : Cup
    {
        public bool SpoutLid { get; set; }

        public override string TipOver()
        {
            return "spills a drop";
        }
      
    }
}
