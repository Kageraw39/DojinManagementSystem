using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;
using static DojinManagementSystem.Global;

namespace DojinManagementSystem.Repository
{
    class MSGenreRepository
    {
        DBConection _Connection = new DBConection();

        /// <summary>
        /// select(全て)
        /// </summary>
        /// <returns></returns>
        public List<MastaGenre> Select()
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select 
    id as Id,
    genre_name as GenreName
from
    ms_genre
order by
    id
";
                return db.Query<MastaGenre>(sql).ToList();
            }
        }

        /// <summary>
        /// select(id指定)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public MastaGenre SelectById(int id)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select
    id as Id,
    genre_name as GenreName
from
    ms_genre
where
    id = @id
";
                return db.Query<MastaGenre>(sql, new { id = id }).SingleOrDefault();
            }
        }

        /// <summary>
        /// insert
        /// </summary>
        /// <param name="genreName"></param>
        public void Insert(string genreName)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
insert into ms_genre
(
    id,
    genre_name
)
values
(
    null,
    @genre_name
)
";
                db.Execute(sql, new { genre_name = genreName });
            }
        }

        /// <summary>
        /// updare(id指定)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="genreName"></param>
        public void Update(int id,string genreName)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
update ms_genre
set
    genre_name = @genre_name
where
    id = @id
";
                db.Execute(sql, new { id = id, genre_name = genreName });
            }
        }

        /// <summary>
        /// delete(id指定)
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
delete from ms_genre
where
    id = @id
";
                db.Execute(sql, new { id = id });
            }
        }
    }
}
