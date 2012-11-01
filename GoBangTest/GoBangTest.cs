using GoBang;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoBangTest
{

    [TestClass]
    public class GoBangTest
    {
        private TestContext testContextInstance;

        [TestMethod]
        public void TestMethod1()
        {
            Chessboard board = new Chessboard();
            string boardString = board.DumpBoard();
            string boardExcepted = "0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0";

            Assert.AreEqual(boardString, boardExcepted);
        }
    }
}
