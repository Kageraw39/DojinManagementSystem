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
    class BookJointInfoRepository
    {
        DBConection _Connection = new DBConection();
        
        /// <summary>
        /// select(id指定)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<TableBookJointInfo> SelectById(int id)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select   
    book_id as BookId,
    join_order as JoinOrder,
    join_name as JoinName,
    join_circle_id as JoinCircleId
from
    t_joint_inf
where
    book_id = @id
order by
    join_order 

";
                return db.Query<TableBookJointInfo>(sql, new { id = id }).ToList();
            }
        }

        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="tableBookInfo"></param>
        /// <returns></returns>
        public void Insert(TableBookJointInfo tableBookJointInfo)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
insert into t_joint_inf
(
    book_id,
    join_order,
    join_name,
    join_circle_id
)
values
(
    @book_id,
    @join_order,
    @join_name,
    @join_circle_id
);
";
                db.Execute
                   (sql,
                   new
                   {
                      book_id = tableBookJointInfo.BookId,
                      join_order = tableBookJointInfo.JoinOrder,
                      join_name = tableBookJointInfo.JoinName,
                      join_circle_id = tableBookJointInfo.JoinCircleId
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
delete from t_joint_inf
where
    book_id = @id
";
                db.Execute(sql, new { id = id });
            }
        }       
    }
}
