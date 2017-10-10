namespace DoFactory.HeadFirst.Template.SimpleBarista
{
    using System;

    public class Tea
    {
        public void PrepareRecipe()
        {
            BoilWater();
            SteepTeaBag();
            PourInCup();
            AddLemon();
        }

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void SteepTeaBag()
        {
            Console.WriteLine("Steeping the tea");
        }

        public void AddLemon()
        {
            Console.WriteLine("Adding Lemon");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}