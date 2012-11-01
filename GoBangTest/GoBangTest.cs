using GoBang;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoBangTest
{

    [TestClass]
    public class GoBangTest
    {
        private TestContext testContextInstance;

        [TestMethod]
        public void Show_Empty_ChessBoard_Should_Be_Ok()
        {
            Chessboard board = new Chessboard();
            string boardString = board.DumpBoard();
            string boardExcepted = "0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0";

            Assert.AreEqual(boardString, boardExcepted);
        }

        [TestMethod]
        public void Place_A_Piece_Should_Be_Ok()
        {
            Chessboard board = new Chessboard();
            ChessPresenter presenter = new ChessPresenter();
            board.AddObserver(presenter);
            
            string boardString = board.DumpBoard();
            string boardExcepted = "0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0";

            Assert.AreEqual(boardString, boardExcepted);
        }
    }
}
