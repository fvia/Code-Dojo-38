﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Code_Dojo_38.Tests
{
    [TestClass()]
    public class ScissorsTests
    {
        Scissors me;

        [TestInitialize]
        public void Initialize()
        {
            me = new Scissors();
        }

        [TestMethod()]
        public void ScissorsBeatsRockTest()
        {
            Rock other = new Rock();
            Assert.AreEqual(me.Beats(other), false);
        }

        [TestMethod()]
        public void ScissorsBeatsScissorTest()
        {
            Scissors other = new Scissors();
            Assert.AreEqual(me.Beats(other), null);
        }

        [TestMethod()]
        public void ScissorsBeatsPaperTest()
        {
            Paper other = new Paper();
            Assert.AreEqual(me.Beats(other), true);
        }

    }
}