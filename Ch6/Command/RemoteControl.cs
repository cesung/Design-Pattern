using System.Text;

namespace Command
{
    public class RemoteControl
    {
        private const int c_numSlots = 8;
        public ICommand[] OnBtns = new ICommand[c_numSlots];
        public ICommand[] OffBtns = new ICommand[c_numSlots];
        public ICommand UndoBtn;

        public RemoteControl()
        {
            for (int idx = 0; idx < c_numSlots; idx++)
            {
                OnBtns[idx] = new NoCommand();
                OffBtns[idx] = new NoCommand();
            }
            UndoBtn = new NoCommand();
        }

        public void SetCommand(int slotId, ICommand onCommand, ICommand offCommand)
        {
            OnBtns[slotId] = onCommand;
            OffBtns[slotId] = offCommand;
        }

        public void OnOnBtnsPressed(int slotId)
        {
            OnBtns[slotId].Execute();
            UndoBtn = OnBtns[slotId];
        }

        public void OnOffBtnsPressed(int slotId)
        {
            OffBtns[slotId].Execute();
            UndoBtn = OffBtns[slotId];
        }

        public void OnUndoBtnPressed()
        {
            UndoBtn.Undo();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("\n------ Remote Control ------\n");
            for (int i = 0; i < c_numSlots; i++)
            {
                stringBuilder.Append($"[Slot {i}] {OnBtns[i]} {OffBtns[i]}\n");
            }
            stringBuilder.Append($"[Undo] {UndoBtn.GetType().Name}\n");

            return stringBuilder.ToString();
        }
    }
}