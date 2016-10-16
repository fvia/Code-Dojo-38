﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        Rock me;

        [TestInitialize]
        public void Initialize()
        {
            me = new Rock();
        }


        [TestMethod()]
        public void RockBeatsRockTest()
        {
            Rock other = new Rock();
            Assert.IsNull( me.Beats(other) );
        }

        [TestMethod()]
        public void RockBeatsScissorTest()
        {
            Scissors other = new Scissors();
            Assert.AreEqual(   me.Beats(other) ,true );
        }

        [TestMethod()]
        public void RockBeatsPaperTest()
        {
            Paper other = new Paper();
            Assert.AreEqual(me.Beats(other), false);
        }

    }
}