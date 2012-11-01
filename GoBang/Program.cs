using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GoBang
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Chessboard board = new Chessboard();
            ChessPresenter presenter = new ChessPresenter();
            
            Application.Run(new Chessboard());
        }
    }
}
