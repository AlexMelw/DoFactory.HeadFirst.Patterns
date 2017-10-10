namespace DoFactory.HeadFirst.Iterator.DinerMergerI
{
    using System;
    using System.Collections;

    public class AlternatingDinerMenuIterator : IEnumerator
    {
        private MenuItem[] _items;
        private int _position;

        #region CONSTRUCTORS

        public AlternatingDinerMenuIterator(MenuItem[] items)
        {
            _items = items;
            _position = int.Parse(DateTime.Now.DayOfWeek.ToString()) % 2;
        }

        #endregion

        public object Current
        {
            get {
                MenuItem menuItem = _items[_position];
                _position = _position + 2;
                return menuItem;
            }
        }

        public bool MoveNext()
        {
            if (_position >= _items.Length || _items[_position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Reset()
        {
            Console.WriteLine("Alternating Diner Menu Iterator does not support reset()");
        }
    }
}