using AlbumsMasterDetailDapperModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumsMasterDetailDapper.Service
{
    public interface ISongService
    {
        List<Song> GetSongs();
        bool SaveSong(Song song);
        bool DeleteSong(Song song);
    }
}
