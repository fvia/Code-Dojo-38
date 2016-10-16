using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Dojo_38
{
    public abstract class Thing
    {
        public abstract bool? Beats(Paper other);
        public abstract bool? Beats(Scissors other);
        public abstract bool? Beats(Rock other);
    }     
}
