using System.Collections.Generic;
using System.IO;

namespace Proxy
{
    class YouTubeManager
    {
        private readonly ThirdPartyYouTubeLib _service;

        public YouTubeManager(ThirdPartyYouTubeLib service)
        {
            _service = service;
        }

        private string RenderVideoPage(int id)
        {
            return _service.getVideoInfo(id);
        }

        private List<Stream> RenderListPanel()
        {
            return _service.listVideos();
        }

        public void reactOnUserInput(int id)
        {
            RenderVideoPage(id);
            RenderListPanel();
        }
    }
}