namespace Memento
{
    public class PenState
    {
        public int x { get; set; }
        public int y { get; set; }

        public PenState()
        {
            this.x = 0;
            this.y = 0;
        }
        public PenState(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}