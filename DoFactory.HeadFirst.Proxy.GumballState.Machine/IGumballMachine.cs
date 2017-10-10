namespace DoFactory.HeadFirst.Proxy.GumballState.Machine
{
    using System.ServiceModel;

    [ServiceContract(Name = "GumballMachine", Namespace = "http://www.mycompany.com/headfirst/2008/07",
        SessionMode = SessionMode.Required)]
    public interface IGumballMachine
    {
        [OperationContract]
        void StartWithQuarters(int count);

        [OperationContract]
        void InsertQuarter();

        [OperationContract]
        void TurnCrank();

        [OperationContract]
        void EjectQuarter();

        [OperationContract]
        string GetReport();
    }
}