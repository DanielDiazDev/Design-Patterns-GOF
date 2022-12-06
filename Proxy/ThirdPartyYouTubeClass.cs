using System.Collections.Generic;
using System.IO;

namespace Proxy
{
    class ThirdPartyYouTubeClass : ThirdPartyYouTubeLib
    {
        public List<Stream> listVideos()
        {
            return null;
        }

        public string getVideoInfo(int id)
        {
            return string.Empty;
        }

        public Stream downloadVideo(int id)
        {
            return Stream.Null;
        }
    }
}