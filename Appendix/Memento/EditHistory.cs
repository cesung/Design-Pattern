namespace Memento
{
    public class EditHistory
    {
        private Stack<IMemento> m_memento = new();
        private Editor m_editor;

        public EditHistory(Editor editor)
        {
            m_editor = editor;
        }

        public void Save(IMemento memento)
        {
            Console.WriteLine($"Saving {memento.GetGuid()}\n");
            m_memento.Push(memento);
        }

        public void Undo()
        {
            if (m_memento.Count == 0)
            {
                return;
            }

            var memento = m_memento.Pop();
            Console.WriteLine($"Restoring {memento.GetGuid()}\n");

            m_editor.Restore(memento);
        }

        public void ShowHistory()
        {
            foreach (var memento in m_memento)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine(memento);
                Console.WriteLine("-------------------\n");
            }
        }
    }
}