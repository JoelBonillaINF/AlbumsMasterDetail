using AlbumsMasterDetailDapperModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumsMasterDetailDapper.Data
{
    public interface ISongRepository
    {
        List<Song> Songs();
        bool InsertSong(Song song);
        bool UpdateSong(Song song);
        bool DeleteSong(Song song);
    }
}
