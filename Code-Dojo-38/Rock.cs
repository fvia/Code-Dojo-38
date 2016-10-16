using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Dojo_38
{
    public class Rock : Thing
    {
        public override bool? Beats(Rock other)
        {
            return null;
        }

        public override bool? Beats(Paper other)
        {
            return false;
        }
        public override bool? Beats(Scissors other)
        {
            return true;
        }

    }
}
