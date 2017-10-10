namespace DoFactory.HeadFirst.Iterator.DinerMerger
{
    using System;

    public class AlternatingDinerMenuIterator : Iterator
    {
        private MenuItem[] _list;
        private int _position;

        #region CONSTRUCTORS

        public AlternatingDinerMenuIterator(MenuItem[] list)
        {
            _list = list;
            _position = int.Parse(DateTime.Now.DayOfWeek.ToString()) % 2;
        }

        #endregion

        public object Next()
        {
            MenuItem menuItem = _list[_position];
            _position = _position + 2;
            return menuItem;
        }

        public bool HasNext()
        {
            if (_position >= _list.Length || _list[_position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string ToString()
        {
            return "Alternating Diner Menu Iterator";
        }
    }
}