using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Memento
{
    public class Editor
    {
        [NotNull]
        public string Text { get; set; } = string.Empty;

        [NotNull]
        public (int x, int y) CursorCoordinate { get; set; } = (0, 0);

        [NotNull]
        public int CursorScrollPosition { get; set; } = 0;

        public void Update(string text, int cursorCoordinateX, int cursorCoordinateY, int cursorScrollPosition)
        {
            UpdateText(text);
            UpdateCursorCoordinate(cursorCoordinateX, cursorCoordinateY);
            UpdateCursorScrollPosition(cursorScrollPosition);
            Console.WriteLine("");
        }

        public void UpdateText(string text)
        {
            Console.WriteLine($"Update Text from {Text} to {text}");
            Text = text;
        }

        public void UpdateCursorCoordinate(int x, int y)
        {
            Console.WriteLine($"Update Cursor Coordinate form ({CursorCoordinate.x}, {CursorCoordinate.y}) to ({x},{y})");
            CursorCoordinate = (x, y);
        }

        public void UpdateCursorScrollPosition(int cursorScrollPos)
        {
            Console.WriteLine($"Update Cursor Scroll Position from {CursorScrollPosition} to {cursorScrollPos}");
            CursorScrollPosition = cursorScrollPos;
        }

        public IMemento Save()
        {
            return new Memento(Text, CursorCoordinate, CursorScrollPosition);
        }

        public void Restore(IMemento memento)
        {
            if (memento is not Memento)
            {
                throw new Exception($"\n[Error] Unknown memento class {memento.ToString()}\n");
            }

            Text = memento.GetText();
            CursorCoordinate = memento.GetCursorCoordinate();
            CursorScrollPosition = memento.GetCursorScrollPosition();
        }

        public void ShowCurrentState()
        {
            Console.WriteLine($"Text: {Text}");
            Console.WriteLine($"CursorCoordinate: ({CursorCoordinate.x}, {CursorCoordinate.y})");
            Console.WriteLine($"CursorScrollPosition: {CursorScrollPosition}\n");
        }
    }


}