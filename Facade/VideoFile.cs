namespace Facade
{
    public class VideoFile
    {
        private readonly string _fileName;
        private object result;

        public CompressionCodec CompressionCodec { get; set; }

        public VideoFile(string fileName)
        {
            _fileName = fileName;
        }
    }
}