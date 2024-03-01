namespace Memento
{
    public interface IMemento
    {
        string GetGuid();

        DateTime GetDate();

        string GetText();

        (int x, int y) GetCursorCoordinate();

        int GetCursorScrollPosition();
    }
}