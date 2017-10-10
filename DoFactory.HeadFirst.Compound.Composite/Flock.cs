namespace DoFactory.HeadFirst.Compound.Composite
{
    using System.Collections.Generic;

    public class Flock : IQuackable
    {
        private readonly List<IQuackable> _quackers = new List<IQuackable>();

        public void Quack()
        {
            foreach (IQuackable quacker in _quackers)
            {
                quacker.Quack();
            }
        }

        public void Add(IQuackable quacker) => _quackers.Add(quacker);

        public override string ToString() => "Flock of Quackers";
    }
}