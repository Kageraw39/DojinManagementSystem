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
    class MSSizeRepository
    {
        DBConection _Connection = new DBConection();

        /// <summary>
        /// select（すべて）
        /// </summary>
        /// <returns></returns>
        public List<MastaSize> Select()
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select
    id as Id,
    size_name as SizeName,
    height as Height,
    width as Width
from
    ms_size
order by 
    id    
";
                return db.Query<MastaSize>(sql).ToList();
            }
        }

        /// <summary>
        /// select(id指定)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public MastaSize SelectById(int id)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select
    id as Id,
    size_name as SizeName,
    height as Height,
    width as Width
from
    ms_size
where
    id = @id
";
                return db.Query<MastaSize>(sql, new { id = id }).SingleOrDefault();
            }
        }

        /// <summary>
        /// insert
        /// </summary>
        /// <param name="sizeName"></param>
        /// <param name="height"></param>
        /// <param name="width"></param>
        public void Insert(string sizeName,double? height,double? width)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
insert into ms_size
(
    id,
    size_name,
    height,
    width
)
values
(
    null,
    @size_name,
    @height,
    @width
)
";
                db.Execute
                    (sql,new {size_name = sizeName,height = height,width = width });
            }
        }

        /// <summary>
        /// update（id指定）
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sizeName"></param>
        /// <param name="height"></param>
        /// <param name="width"></param>
        public void Update(int id,string sizeName,double? height,double? width)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
update ms_size
set
    size_name = @size_name,
    height = @height,
    width = @width
where
    id = @id
";
                db.Execute(sql, new { id = id, size_name = sizeName, height = height, width = width });
            }
        }

        public void Delete(int id)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
delete from ms_size
where
    id = @id
";
                db.Execute(sql, new { id = id });
            }
        }
    }
}
