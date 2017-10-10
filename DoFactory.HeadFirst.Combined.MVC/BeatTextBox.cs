namespace DoFactory.HeadFirst.Combined.MVC
{
    using System.Windows.Forms;

    /// <summary>
    ///     BeatTextBox supports beat events
    /// </summary>
    public class BeatTextBox : TextBox, IBeatable
    {
        public void Beat(Model sender, BeatEventArgs e)
        {
            Text = e.BeatsPerMinute.ToString();
        }
    }
}