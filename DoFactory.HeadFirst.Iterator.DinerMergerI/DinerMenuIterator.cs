namespace DoFactory.HeadFirst.Iterator.DinerMergerI
{
    using System;
    using System.Collections;

    public class DinerMenuIterator : IEnumerator
    {
        private MenuItem[] _list;
        private int _position = 0;

        #region CONSTRUCTORS

        public DinerMenuIterator(MenuItem[] list)
        {
            _list = list;
        }

        #endregion

        public object Current
        {
            get {
                MenuItem menuItem = _list[_position];
                _position = _position + 1;
                return menuItem;
            }
        }

        public bool MoveNext()
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

        public void Reset()
        {
            if (_position <= 0)
            {
                throw new ApplicationException
                    ("You can't remove an item until you've done at least one Next()");
            }
            if (_list[_position - 1] != null)
            {
                for (int i = _position - 1; i < _list.Length - 1; i++)
                {
                    _list[i] = _list[i + 1];
                }
                _list[_list.Length - 1] = null;
            }
        }
    }
}