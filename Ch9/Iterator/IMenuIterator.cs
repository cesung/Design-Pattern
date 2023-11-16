namespace Iterator
{
    public interface IMenuIterator
    {
        bool HasNext();
        IMenu Next();
    }
}