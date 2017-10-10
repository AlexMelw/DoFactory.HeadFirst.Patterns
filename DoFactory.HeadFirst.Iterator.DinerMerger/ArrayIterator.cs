namespace DoFactory.HeadFirst.Iterator.DinerMerger
{
    public class ArrayIterator : Iterator
    {
        private MenuItem[] _items;
        private int _position = 0;

        #region CONSTRUCTORS

        // Constructore
        public ArrayIterator(MenuItem[] items)
        {
            _items = items;
        }

        #endregion

        public object Next()
        {
            MenuItem menuItem = _items[_position];
            _position = _position + 1;
            return menuItem;
        }

        public bool HasNext()
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
    }
}