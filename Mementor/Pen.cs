using System;

namespace Memento
{
    public class Pen : IOriginator // Originator
    {
        private class PenMemento : IMemento
        {
            public PenState state { get; set; }
            public PenMemento(PenState state)
            {
                this.state = state;
            }
        }
        private PenState state;

        public Pen()
        {
            state = new PenState(0, 0);
        }

        public Pen(int x, int y)
        {
            state = new PenState(x, y);
        }

        public void Move(int x, int y)
        {
            state = new PenState(x, y);
        }

        public void MoveAndCheck(int x, int y)
        {
            this.Move(x, y);
            this.Check();
        }

        public void Check()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Now pen at ({state.x}; {state.y})";
        }

        public IMemento Backup() => new PenMemento(state);
        public void Restore(IMemento Memento) => state = (Memento as PenMemento)?.state;
    }
}