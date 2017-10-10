namespace DoFactory.HeadFirst.Template.Sort
{
    using System;

    public class Duck : IComparable
    {
        private string _name;
        private int _weight;

        #region CONSTRUCTORS

        public Duck(string name, int weight)
        {
            _name = name;
            _weight = weight;
        }

        #endregion

        public int CompareTo(object o)
        {
            Duck otherDuck = (Duck) o;

            if (_weight < otherDuck._weight)
            {
                return -1;
            }
            else if (_weight == otherDuck._weight)
            {
                return 0;
            }
            else // this.weight > otherDuck.weight
            {
                return 1;
            }
        }

        public override string ToString()
        {
            return _name + " weighs " + _weight;
        }
    }
}