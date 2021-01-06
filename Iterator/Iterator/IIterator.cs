namespace MyIterator
{
    public interface IIterator<T>
    {
        T First();
        T Next();
        bool IsDone();
        T CurrentItem();
    }
}