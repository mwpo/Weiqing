namespace GoBang
{
    public interface IChessNotify
    {
        void Notify(int x, int y, char status);
    }

    public class ChessPresenter : IChessNotify
    {
        public void Notify(int x, int y, char status)
        {
            
        }
    }
}
