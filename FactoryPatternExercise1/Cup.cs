using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise1
{
    public class Cup : IPourable
    {
        public virtual string TipOver()
        {
            return "spills everywhere";
        }
    }
}
