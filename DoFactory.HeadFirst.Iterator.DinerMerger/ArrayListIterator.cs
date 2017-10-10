namespace DoFactory.HeadFirst.Iterator.DinerMerger
{
    using System.Collections;

    public class ArrayListIterator : Iterator
    {
        private ArrayList _items;
        private int _position = 0;

        #region CONSTRUCTORS

        // Constructor
        public ArrayListIterator(ArrayList items)
        {
            _items = items;
        }

        #endregion

        public object Next()
        {
            object o = _items[_position];
            _position = _position + 1;
            return o;
        }

        public bool HasNext()
        {
            if (_position >= _items.Count)
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