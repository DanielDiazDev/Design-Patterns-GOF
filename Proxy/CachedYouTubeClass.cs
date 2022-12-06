using System.Collections.Generic;
using System.IO;

namespace Proxy
{
    class CachedYouTubeClass : ThirdPartyYouTubeLib
    {
        private readonly ThirdPartyYouTubeLib _service;
        private List<Stream> _listCache;
        private string _videoCache;

        public CachedYouTubeClass(ThirdPartyYouTubeLib service)
        {
            _service = service;
        }

        public List<Stream> listVideos()
        {
            if (_listCache == null)
                _listCache = _service.listVideos();
            return _listCache;
        }

        public string getVideoInfo(int id)
        {
            if (_videoCache == null)
                _videoCache = _service.getVideoInfo(id);
            return _videoCache;
        }

        public Stream downloadVideo(int id)
        {
            var fileIndex = FindFileIndex(id);
            if (fileIndex != -1)
                _service.downloadVideo(id);

            return _listCache[fileIndex];
        }
        
        private static int FindFileIndex(int id)
        {
            return 0;
        }
    }
}