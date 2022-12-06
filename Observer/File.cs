using System;

namespace Observer
{
    class File
    {
        string filename;

        public string Filename { get => filename; set => filename = value; }
        public File(string filename) { this.filename = filename; }

        public void write()
        {
            
        }
    }
}