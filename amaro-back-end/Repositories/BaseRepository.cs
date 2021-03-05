using Dapper;
using Npgsql;
using System.Collections.Generic;
using System.Linq;

namespace amaro_back_end.Repositories
{
    public static class BaseRepository
    {
        public static List<T> QuerySql<T>(string sql, object[] param = null)
        {
            List<T> ret;

            using (var connection = new NpgsqlConnection("User ID=postgres;Password=root;Host=localhost;Port=5432;Database=fashion;"))
            {
                ret = connection.Query<T>(sql, param).ToList();
            }

            return ret;
        }
    }
}
