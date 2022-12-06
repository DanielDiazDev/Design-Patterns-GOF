using System.Collections.Generic;
using System.IO;

namespace Proxy
{
    interface ThirdPartyYouTubeLib
    {
        List<Stream> listVideos();
        string getVideoInfo(int id);
        Stream downloadVideo(int id);
    }
}