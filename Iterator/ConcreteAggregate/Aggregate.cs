using System.Collections;

namespace MyIterator
{
    public class Aggregate<T> : IAggregate<T>
    {
        private ArrayList _array = new ArrayList();
        public IIterator<T> CreateIterator() => new Iterator<T>(this);

        public T this[int index]
        {
            get { return (T)_array[index]; }
            set { _array.Insert(index, value); }
        }
        public int Count => _array.Count;
    }
}