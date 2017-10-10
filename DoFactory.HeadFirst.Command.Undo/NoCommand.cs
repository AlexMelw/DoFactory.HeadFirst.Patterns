namespace DoFactory.HeadFirst.Command.Undo
{
    public class NoCommand : ICommand
    {
        public void Execute() { }
        public void Undo() { }
    }
}