namespace DoFactory.HeadFirst.Combined.MVC
{
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    ///     BeatPanel supports Beat events
    /// </summary>
    public class BeatPanel : Panel, IBeatable
    {
        public void Beat(Model sender, BeatEventArgs e)
        {
            // Depending on beatsPerMinute set color anywhere 
            // between red and yellow
            int red = 255;
            int green = 255 - (e.BeatsPerMinute + 55);
            int blue = 0;

            BackColor = Color.FromArgb(red, green, blue);
        }
    }
}