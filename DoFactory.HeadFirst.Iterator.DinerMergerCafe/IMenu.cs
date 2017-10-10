namespace DoFactory.HeadFirst.Iterator.DinerMergerCafe
{
    using System.Collections.Generic;

    public interface IMenu
    {
        IEnumerator<MenuItem> CreateIterator();
    }
}