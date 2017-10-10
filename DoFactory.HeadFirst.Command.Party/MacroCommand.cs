namespace DoFactory.HeadFirst.Command.Party
{
    public class MacroCommand : ICommand
    {
        private ICommand[] _commands;

        #region CONSTRUCTORS

        public MacroCommand(ICommand[] commands)
        {
            _commands = commands;
        }

        #endregion

        public void Execute()
        {
            for (int i = 0; i < _commands.Length; i++)
            {
                _commands[i].Execute();
            }
        }

        public void Undo()
        {
            for (int i = 0; i < _commands.Length; i++)
            {
                _commands[i].Undo();
            }
        }
    }
}