// Replacement for the Java 'Swing example'

namespace DoFactory.HeadFirst.Observer.Swing
{
    using System;

    class DotNetObserverExample
    {
        static void Main()
        {
            // Create listeners
            var angel = new ActionListener("Angel");
            var devil = new ActionListener("Devil");

            // Create Button and attach listeners
            var button = new Button("Click Me");
            button.Attach(angel);
            button.Attach(devil);

            // Simulate clicks on button
            button.Push(1, 3);
            button.Push(5, 4);
            button.Push(8, 5);

            // Wait for user
            Console.ReadKey();
        }
    }

    #region EventArgs

    // Custom event arguments

    #endregion

    #region Controls

    // Base class for UI controls

    // Button control

    #endregion

    #region ActionListener

    #endregion
}