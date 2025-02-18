namespace DoFactory.HeadFirst.Combined.MVC
{
    /// <summary>
    ///     The Controller class in the MVC pattern
    /// </summary>
    public class Controller
    {
        private FormMain _view;
        private Model _model = new Model();

        public int BeatsPerMinute
        {
            set {
                _model.BeatsPerMinute = value;

                // Enable stop button on View
                _view.ButtonStop.Enabled = true;
            }
            get { return _model.BeatsPerMinute; }
        }

        #region CONSTRUCTORS

        // Constructor
        public Controller(FormMain view)
        {
            _view = view;
        }

        #endregion

        public void Start()
        {
            _model.Start();
        }

        public void Stop()
        {
            _model.Stop();

            // Disable stop button on View
            _view.ButtonStop.Enabled = false;
        }

        public void Attach(IBeatable beatable)
        {
            _model.Attach(beatable);
        }

        public void Detach(IBeatable beatable)
        {
            _model.Detach(beatable);
        }
    }
}