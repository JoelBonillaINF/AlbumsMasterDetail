using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumsMasterDetailDapper.Data
{
    public abstract class GenericRepository
    {
        protected SqlConnection dbConnection()
        {
            return new SqlConnection("Data Source=JOEL-PC;Initial Catalog=AlbumMasterDetail;Integrated Security=True");
        }
    }
}
