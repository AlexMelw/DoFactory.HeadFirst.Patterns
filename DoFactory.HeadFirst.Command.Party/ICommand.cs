namespace DoFactory.HeadFirst.Command.Party
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}