namespace Observer
{
    class TextEditor
    {
        public EventManager events;
        File file;

        public TextEditor() { this.events = new EventManager(); }
        public void openFile(string path)
        {
            this.file = new File(path);
            events.notify("File open", "data");
        }
        public void saveFile(string path)
        {
            this.file.write();
            events.notify("File save", "data");
        }
    }
}