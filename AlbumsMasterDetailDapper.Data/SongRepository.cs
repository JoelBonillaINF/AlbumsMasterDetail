using AlbumsMasterDetailDapperModels;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumsMasterDetailDapper.Data
{
    public class SongRepository : GenericRepository, ISongRepository
    {
        public bool DeleteSong(Song song)
        {
            throw new NotImplementedException();
        }

        public bool InsertSong(Song song)
        {
            var db = dbConnection();

            var sql = @" insert into Song (AlbumId, Name, Minutes)" +
                "Values (@AlbumId,@Name,@Minutes)";

            var result = db.Execute(sql, new
            {
                song.AlbumId,
                song.Name,
                song.Minutes
            });

            return result > 0;
        }

        public List<Song> Songs()
        {
            throw new NotImplementedException();
        }

        public bool UpdateSong(Song song)
        {
            throw new NotImplementedException();
        }
    }
}
