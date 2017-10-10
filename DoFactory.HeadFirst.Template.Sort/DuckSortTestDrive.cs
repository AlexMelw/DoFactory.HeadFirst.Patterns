namespace DoFactory.HeadFirst.Template.Sort
{
    using System;

    class DuckSortTestDrive
    {
        public static void Display(Duck[] ducks)
        {
            foreach (var duck in ducks)
            {
                Console.WriteLine(duck);
            }
        }

        static void Main(string[] args)
        {
            Duck[] ducks =
            {
                new Duck("Daffy", 8),
                new Duck("Dewey", 2),
                new Duck("Howard", 7),
                new Duck("Louie", 2),
                new Duck("Donald", 10),
                new Duck("Huey", 2)
            };

            Console.WriteLine("Before sorting:");
            Display(ducks);

            Array.Sort(ducks);

            Console.WriteLine("\nAfter sorting:");
            Display(ducks);

            // Wait for user
            Console.ReadKey();
        }
    }

    #region Duck

    #endregion
}