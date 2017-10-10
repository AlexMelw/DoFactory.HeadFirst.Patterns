namespace DoFactory.HeadFirst.Command.Party
{
    public class NoCommand : ICommand
    {
        public void Execute() { }
        public void Undo() { }
    }
}