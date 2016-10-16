using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Dojo_38
{
    public class Rock : Thing
    {
        public override bool? Beats(Thing other)
        {
            if (other is Rock) return null;
            if (other is Paper) return false;
            return true;
        }

    }
}
