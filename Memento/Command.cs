using System;

namespace Memento
{
    public class Command
    {
        private Snapshot backup { get; set; }

        public void makeBackup(Editor editor)
        {
            backup = editor.createSnapshot();
        }

        public void undo()
        {
            if (backup != null)
                backup.restore();
        }
    }
}