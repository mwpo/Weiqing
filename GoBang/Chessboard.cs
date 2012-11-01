using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GoBang
{
    public partial class Chessboard : Form
    {
        protected char[,] chessBoard = null;  //0 null, A occupied by A, B occupied by B
        protected IChessNotify _observer = null;
        public Chessboard()
        {
            InitializeComponent();
        }
        
        public void SetBoard(char[,] board)
        {
            this.chessBoard = board;
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
