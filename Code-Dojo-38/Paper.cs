using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Dojo_38
{
    public class Paper : Thing
    {
        public override bool? Beats(Thing other)
        {
            if (other is Paper) return null;
            if (other is Scissors) return false;
            return true;

        }
    }
}
