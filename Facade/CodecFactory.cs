namespace Facade
{
    public class CodecFactory
    {
        internal static CompressionCodec Extract(VideoFile videoFile)
        {
            return videoFile.CompressionCodec;
        }
    }
}