using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Dojo_38
{
    class Scissors : Thing
    {
        public override bool Beats(Thing other)
        {
            return true;
        }

    }
}
