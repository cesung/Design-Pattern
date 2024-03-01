using System.Text;

namespace Memento
{
    public class Memento : IMemento
    {
        private string m_guid;

        private DateTime m_dateTime;

        private string m_text;

        private (int x, int y) m_cursorCoordinate;

        private int m_cursorScrollPosition;

        public Memento(string text, (int, int) cursorPosition, int cursorScrollPosition)
        {
            m_guid = System.Guid.NewGuid().ToString();
            m_text = text;
            m_cursorCoordinate = cursorPosition;
            m_cursorScrollPosition = cursorScrollPosition;
        }

        public string GetGuid()
        {
            return m_guid;
        }

        public DateTime GetDate()
        {
            return m_dateTime;
        }

        public string GetText()
        {
            return m_text;
        }

        public (int x, int y) GetCursorCoordinate()
        {
            return m_cursorCoordinate;
        }

        public int GetCursorScrollPosition()
        {
            return m_cursorScrollPosition;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Class: {base.ToString()}");
            stringBuilder.AppendLine($"UUID: {GetGuid()}");
            stringBuilder.AppendLine($"DateTime: {GetDate().ToString()}");
            stringBuilder.AppendLine($"Text: {GetText()}");
            stringBuilder.AppendLine($"Cursor Position: {GetCursorCoordinate()}");
            stringBuilder.Append($"Cursor Scroll Position: {GetCursorScrollPosition()}");

            var toString = stringBuilder.ToString();
            stringBuilder.Remove(0, stringBuilder.Length);

            return toString;
        }
    }
}