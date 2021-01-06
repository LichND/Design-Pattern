namespace MyIterator
{
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }
}       