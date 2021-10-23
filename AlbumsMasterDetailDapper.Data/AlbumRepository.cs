using AlbumsMasterDetailDapperModels;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumsMasterDetailDapper.Data
{
    public class AlbumRepository : GenericRepository, IAlbumRepository
    {
        public bool DeleteAlbum(Album album)
        {
            throw new NotImplementedException();
        }

        public List<Album> GetAlbums()
        {
            throw new NotImplementedException();
        }

        public bool InsertAlbum(Album album)
        {
            var db = dbConnection();

            var sql = @" insert into Album (Id, Name, Author, ReleaseDate)" +
                "Values (@Id,@Name,@Author, @ReleaseDate)";

            var result = db.Execute(sql, new
               {    album.Id, 
                    album.Name, 
                    album.Author, 
                    album.ReleaseDate
                    });

            return result > 0;
        }

        public bool UpdateAlbum(Album album)
        {
            throw new NotImplementedException();
        }
    }
}
