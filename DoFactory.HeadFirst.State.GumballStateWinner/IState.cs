namespace DoFactory.HeadFirst.State.GumballStateWinner
{
    public interface IState
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
    }
}