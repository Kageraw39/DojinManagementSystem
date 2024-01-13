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
    class BookOmumibusInfoRepository
    {
        DBConection _Connection = new DBConection();
        
        /// <summary>
        /// select(id指定)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<TableBookOmunibusInfo> SelectById(int id)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select   
    book_id as BookId,
    put_order as PutOrder,
    put_title as PutTitle,
    put_book_id as PutBookId
from
    t_omunibus_inf
where
    book_id = @id
order by
    put_order
";
                return db.Query<TableBookOmunibusInfo>(sql, new { id = id }).ToList();
            }
        }

        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="tableBookInfo"></param>
        /// <returns></returns>
        public void Insert(TableBookOmunibusInfo tableBookOmunibusInfo)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
insert into t_omunibus_inf
(
    book_id,
    put_order,
    put_title,
    put_book_id
)
values
(
    @book_id,
    @put_order,
    @put_title,
    @put_book_id
);
";
                db.Execute
                   (sql,
                   new
                   {
                       book_id = tableBookOmunibusInfo.BookId,
                       put_order = tableBookOmunibusInfo.PutOrder,
                       put_title = tableBookOmunibusInfo.PutTitle,
                       put_book_id = tableBookOmunibusInfo.PutBookId
                   });
            }
        }       

        /// <summary>
        /// Delete(BookID指定)
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
delete from t_omunibus_inf
where
    book_id = @id
";
                db.Execute(sql, new { id = id });
            }
        }       
    }
}
