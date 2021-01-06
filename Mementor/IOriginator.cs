namespace Memento
{
    public interface IOriginator
    {
        IMemento Backup();
        void Restore(IMemento Memento);
    }
}