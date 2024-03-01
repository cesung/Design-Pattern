namespace Memento
{
    public class Program
    {
        public static void Main()
        {
            Editor editor = new();
            // caretaker
            EditHistory editHistory = new(editor);

            editor.Update("Hello World", 100, 100, 20);
            editor.ShowCurrentState();
            editHistory.Save(editor.Save());

            editor.UpdateCursorScrollPosition(40);
            editor.ShowCurrentState();
            editHistory.Save(editor.Save());

            editor.UpdateCursorCoordinate(26, 33);
            editor.ShowCurrentState();
            editHistory.Save(editor.Save());

            // show history
            editHistory.ShowHistory();

            editor.UpdateText("23333");
            editor.ShowCurrentState();

            editHistory.Undo();
            editor.ShowCurrentState();

            editHistory.Undo();
            editor.ShowCurrentState();

            editHistory.Undo();
            editor.ShowCurrentState();
        }
    }
}