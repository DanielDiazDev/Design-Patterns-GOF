namespace Iterator
{
    interface IProfileIterator
    {
        Profile getNext();
        bool hasMore();
    }
}