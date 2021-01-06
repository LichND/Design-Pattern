using System;

namespace Memento
{
    public class CareTaker<T> where T : IOriginator
    {
        private class Node<TT>
        {
            private class Holder<TTT>
            {
                public TTT Hold { get; set; }
            }
            public Node<TT> Next { get; set; } = null;
            public Node<TT> Previous { get; set; } = null;

            private Holder<TT> _value = null;
            public TT Value
            {
                get
                {
                    if (_value is null)
                    {
                        throw new System.Exception("NullPointerException");
                    }
                    return _value.Hold;
                }
                set
                {
                    if (_value is null)
                        _value = new Holder<TT>();
                    _value.Hold = value;
                }
            }

            public Node(TT item)
            {
                Value = item;
            }
            public Node()
            {
            }
        }
        private Node<IMemento> now, first;
        private T originator;

        public CareTaker(T originator)
        {
            this.originator = originator;
            first = new Node<IMemento>();
        }

        public void Backup()
        {
            IMemento item = originator.Backup();
            if (now is null)
            {
                now = new Node<IMemento>(item);
                first.Next = now;
            }
            else
            {
                now.Next = new Node<IMemento>(item);
                now.Next.Previous = now;
                now = now.Next;
            }
        }

        public void Undo()
        {
            now = now.Previous;
            originator.Restore(now.Value);
        }
        public bool TryUndo()
        {
            try
            {
                this.Undo();
                return true;
            }
            catch
            {
                Console.WriteLine("Nothing to Undo");
                return false;
            }
        }

        public void Redo()
        {
            if (now is null)
            {
                now = first;
            }
            if (now.Next is null)
            {
                throw new Exception("NullPointerException");
            }
            now = now.Next;
            originator.Restore(now.Value);
        }
        public bool TryRedo()
        {
            try
            {
                this.Redo();
                return true;
            }
            catch
            {
                Console.WriteLine("Nothing to Redo");
                return false;
            }
        }
    }
}