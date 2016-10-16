using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Code_Dojo_38.Tests
{
    [TestClass()]
    public class PaperTests
    {
        Paper me;

        [TestInitialize]
        public void Initialize() {
            me = new Paper();
        }

        [TestMethod()]
        public void PaperBeatsRockTest()
        {
            Rock other = new Rock();
            Assert.AreEqual(me.Beats(other), true);
        }

        [TestMethod()]
        public void PaperBeatsScissorTest()
        {
            Scissors other = new Scissors();
            Assert.AreEqual(me.Beats(other), false);
        }
        [TestMethod()]
        public void PaperBeatsPaperTest()
        {
            Paper other = new Paper();
            Assert.AreEqual(me.Beats(other),null);
        }
    }
}