namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Pen p = new Pen();
            CareTaker<Pen> penCareTaker = new CareTaker<Pen>(p);

            p.MoveAndCheck(1,1);
            penCareTaker.Backup();

            p.MoveAndCheck(2,2);
            penCareTaker.Backup();

            penCareTaker.TryUndo();
            p.Check();

            penCareTaker.TryRedo();
            p.Check();

            penCareTaker.TryRedo();
        }
    }
}
