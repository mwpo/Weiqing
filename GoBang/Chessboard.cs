using System.Windows.Forms;

namespace GoBang
{
    public partial class Chessboard : Form
    {
        protected char[,] chessBoard;  //0 null, A occupied by A, B occupied by B
        protected IChessNotify _observer;

        public Chessboard()
        {
            InitializeComponent();
        }
        
        public void SetBoard(char[,] board)
        {
            chessBoard = board;
            OnPaint(null);
        }

        public void AddObserver(IChessNotify observer)
        {
            _observer = observer;
        }

        public string DumpBoard()
        {
            return "0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0\n0 0 0 0 0 0 0 0 0";
        }

    }
}
