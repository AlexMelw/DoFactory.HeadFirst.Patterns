namespace DoFactory.HeadFirst.Iterator.DinerMergerI
{
    using System.Collections;

    public interface Menu
    {
        IEnumerator CreateIterator();
    }
}