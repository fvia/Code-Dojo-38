using Microsoft.VisualStudio.TestTools.UnitTesting;
using Code_Dojo_38;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Dojo_38.Tests
{
    [TestClass()]
    public class RockTests
    {
        [TestMethod()]
        public void RockBeatsRockTest()
        {
            Rock me = new Rock();
            Rock other = new Rock();
            Assert.IsNull( me.Beats(other) );
        }

        [TestMethod()]
        public void RockBeatsScissorTest()
        {
            Rock me = new Rock();
            Scissors other = new Scissors();
            Assert.AreEqual(   me.Beats(other) ,true );
        }
        [TestMethod()]
        public void RockBeatsPaperTest()
        {
            Rock me = new Rock();
            Paper other = new Paper();
            Assert.AreEqual(me.Beats(other), false);
        }

    }
}