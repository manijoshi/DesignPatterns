using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoLibrary;

namespace VideoGalleryPresentation.Proxy
{
    public class ProxyRepository : IRepository
    {
        public bool IsHDRequested { get; set; }
        List<VideoDto> _videos;
        public ProxyRepository()
        {
            _videos = new List<VideoDto>
            {
                new VideoDto{Id=1,Name="Bahara",Path="~/Videos/Bahara.mp4"},
                new VideoDto{Id=2,Name="Bedardi Raja",Path="~/Videos/BedardiRaja.mp4"},
                new VideoDto{Id=3,Name="Bekhauff",Path="~/Videos/Bekhauff.mp4"},
                new VideoDto{Id=4,Name="Naina",Path="~/Videos/Naina.mp4"},
                new VideoDto{Id=5,Name="Piya Se Naina",Path="~/Videos/PiyaSeNaina.mp4"}
            };
        }
        public IList<VideoDto> GetAllVideoDetail()
        {
            return _videos;
        }

        public string GetVideoPath(int id)
        {
            string path = string.Empty;
            if (IsHDRequested)
            {
                var hdRepository = new VideoRepository();
                path = hdRepository.GetVideoPath(id);
            }
            else
            {

                foreach (var item in _videos)
                {
                    if (item.Id == id)
                    {
                        path = item.Path;
                        break;
                    }
                }
            }
            return path;
        }
    }
}
