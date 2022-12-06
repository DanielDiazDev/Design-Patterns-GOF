namespace Facade
{
    public class BitrateReader
    {
        internal static string Convert(string buffer, CompressionCodec destinationCodec)
        {
            return $"{nameof(destinationCodec)}: {buffer}";
        }

        internal static string Read(string fileName, CompressionCodec sourceCodec)
        {
            return $"{nameof(sourceCodec)}: {fileName}";
        }
    }
}