using System;

namespace Proxy
{
    class Program
    {
        static void Main()
        {
            var youtubeService = new ThirdPartyYouTubeClass();
            var proxy = new CachedYouTubeClass(youtubeService);

            const int videoId = 10;
            
            var manager = new YouTubeManager(proxy);
            manager.reactOnUserInput(videoId);
                
            Console.ReadKey();
        }
    }
}