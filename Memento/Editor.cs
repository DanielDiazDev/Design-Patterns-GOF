namespace Memento
{
    public class Editor
    {
        private string text { get; set; }
        private int curX { get; set; }
        private int curY { get; set; }
        private int selectionWidth { get; set; }

        public void setText(string text)
        {
            this.text = text;
        }

        public void setCursor(int x, int y)
        {
            this.curX = x;
            this.curY = y;
        }

        public void setSelectionWidth(int width)
        {
            this.selectionWidth = width;
        }
        
        public Snapshot createSnapshot()
        {
            return new Snapshot(this, text, curX, curY, selectionWidth);
        }
    }
}