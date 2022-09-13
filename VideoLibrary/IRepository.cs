using System;
using System.Collections.Generic;
using System.Text;

namespace VideoLibrary
{
    public interface IRepository
    {
        IList<VideoDto> GetAllVideoDetail();
        string GetVideoPath(int id);
    }
}
