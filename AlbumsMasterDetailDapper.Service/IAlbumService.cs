using AlbumsMasterDetailDapperModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumsMasterDetailDapper.Service
{
    public interface IAlbumService
    {
        List<Album> GetAlbums();
        bool SaveAlbum(Album album);
        bool DeleteAlbum(Album album);
    }
}
