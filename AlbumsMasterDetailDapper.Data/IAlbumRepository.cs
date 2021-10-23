using AlbumsMasterDetailDapperModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumsMasterDetailDapper.Data
{
    public interface IAlbumRepository
    {

        List<Album> GetAlbums();
        bool InsertAlbum(Album album);
        bool UpdateAlbum(Album album);
        bool DeleteAlbum(Album album);
      

    }
}
