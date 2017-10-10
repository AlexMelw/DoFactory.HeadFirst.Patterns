namespace DoFactory.HeadFirst.Command.Undo
{
    using System.Text;

    public class RemoteControlWithUndo
    {
        private ICommand[] _onCommands;
        private ICommand[] _offCommands;
        private ICommand _undoCommand;

        #region CONSTRUCTORS

        // Constructor
        public RemoteControlWithUndo()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
            _undoCommand = noCommand;
        }

        #endregion

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            _undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder stringBuff = new StringBuilder();
            stringBuff.Append("\n------ Remote Control -------\n");
            for (int i = 0; i < _onCommands.Length; i++)
            {
                stringBuff.Append("[slot " + i + "] " + _onCommands[i].GetType().Name
                                  + "    " + _offCommands[i].GetType().Name + "\n");
            }
            stringBuff.Append("[undo] " + _undoCommand.GetType().Name + "\n");
            return stringBuff.ToString();
        }
    }
}