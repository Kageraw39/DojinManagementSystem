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
    class BookCharaInfoRepository
    {
        DBConection _Connection = new DBConection();

        /// <summary>
        /// select（すべて）
        /// </summary>
        /// <returns></returns>
        public List<TableBookCharaInfo> Select()
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select   
    book_id as BookId,
    chara_order as CharaOrder,
    chara_name as CharaName,
    chara_id as CharaId
from
    t_chara_inf
order by 
    book_id,chara_order    
";
                return db.Query<TableBookCharaInfo>(sql).ToList();
            }
        }

        /// <summary>
        /// select(id指定)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<TableBookCharaInfo> SelectById(int id)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select
    book_id as BookId,
    chara_order as CharaOrder,
    chara_name as CharaName,
    chara_id as CharaId
from
    t_chara_inf
where
    book_id = @id
order by
    chara_order
";
                return db.Query<TableBookCharaInfo>(sql, new { id = id }).ToList();
            }
        }

        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="tableBookInfo"></param>
        /// <returns></returns>
        public void Insert(TableBookCharaInfo tableBookCharaInfo)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
insert into t_chara_inf
(
    book_id,
    chara_order,
    chara_name,
    chara_id
)
values
(
    @book_id,
    @chara_order,
    @chara_name,
    @chara_id
);
";
                db.Execute
                   (sql,
                   new
                   {
                       book_id = tableBookCharaInfo.BookId,
                       chara_order = tableBookCharaInfo.CharaOrder,
                       chara_name = tableBookCharaInfo.CharaName,
                       chara_id = tableBookCharaInfo.CharaId
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
delete from t_chara_inf
where
    book_id = @id
";
                db.Execute(sql, new { id = id });
            }
        }       
    }
}
