namespace DoFactory.HeadFirst.Template.WindowsService
{
    using System.ComponentModel;
    using System.ServiceProcess;

    // NOTE: this app will not run as a standalone application.

    public class HeadFirstService : ServiceBase
    {
        private Container _components = null;

        #region CONSTRUCTORS

        public HeadFirstService()
        {
            InitializeComponent();
        }

        #endregion

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_components != null)
                {
                    _components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        // Design Patterns: Template method

        protected override void OnStart(string[] args)
        {
            // TODO: Add code here to start your service.
        }

        // Design Patterns: Template method

        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
        }

        // The main entry point for the process
        static void Main()
        {
            ServiceBase[] ServicesToRun;

            ServicesToRun = new ServiceBase[] { new HeadFirstService() };

            Run(ServicesToRun);
        }

        private void InitializeComponent()
        {
            _components = new Container();
            ServiceName = "HeadFirstService";
        }
    }
}