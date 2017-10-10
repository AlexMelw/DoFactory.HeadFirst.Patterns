namespace DoFactory.HeadFirst.Command.Undo
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}