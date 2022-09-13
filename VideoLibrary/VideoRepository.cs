using System;
using System.Collections.Generic;
using System.Text;

namespace VideoLibrary
{
    public class VideoRepository : IRepository
    {
        List<VideoDto> _videos;
        public VideoRepository()
        {
            _videos = new List<VideoDto>
            {
                new VideoDto{Id=1,Name="Bahara",Path="~/Videos/HD/Bahara.mp4"},
                new VideoDto{Id=2,Name="Bedardi Raja",Path="~/Videos/HD/BedardiRaja.mp4"},
                new VideoDto{Id=3,Name="Bekhauff",Path="~/Videos/HD/Bekhauff.mp4"},
                new VideoDto{Id=4,Name="Naina",Path="~/Videos/HD/Naina.mp4"},
                new VideoDto{Id=5,Name="Piya Se Naina",Path="~/Videos/HD/PiyaSeNaina.mp4"}
            };
        }
        public IList<VideoDto> GetAllVideoDetail()
        {
            return _videos;
        }

        public string GetVideoPath(int id)
        {
            string path = string.Empty;
            foreach(var item in _videos)
            {
                if (item.Id == id)
                {
                    path = item.Path;
                    break;
                }
            }
            return path;
        }
    }
}
