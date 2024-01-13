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
    class MSOriginalRepository
    {
        DBConection _Connection = new DBConection();

        /// <summary>
        /// select(すべて)
        /// </summary>
        /// <returns></returns>
        public List<MastaOriginal> Select()
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select
    id as Id,
    original_name as OriginalName
from
    ms_original
order by
    id
";
                return db.Query<MastaOriginal>(sql).ToList();
            }
        }


        /// <summary>
        /// select(id指定)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public MastaOriginal SelectById(int id)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select
    id as Id,
    original_name as OriginalName
from
    ms_original
where
    id = @id
";
                return db.Query<MastaOriginal>(sql, new {id = id }).SingleOrDefault();
            }
        }

        /// <summary>
        /// insert
        /// </summary>
        /// <param name="originalName"></param>
        public void Insert(string originalName)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
insert into ms_original
(
    id,
    original_name
)
values
(
    null,
    @original_name
)
";
                db.Execute(sql, new { original_name = originalName });
            }
        }

        /// <summary>
        /// update(id指定)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="originalName"></param>
        public void Update(int id,string originalName)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
update ms_original
set
    original_name = @original_name
where
    id = @id
";
                db.Execute(sql, new { id = id, original_name = originalName });
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
delete from ms_original
where
    id = @id
";
                db.Execute(sql, new { id = id });
            }
        }

        /// <summary>
        /// 検索
        /// </summary>
        /// <param name="id"></param>
        /// <param name="originalName"></param>
        /// <returns></returns>
        public List<MastaOriginal> Search(int? id, string originalName)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select
    id as Id,
    original_name as OriginalName
from
    ms_original
where
    0=0
";
                if(id != null)
                {
                    sql += $" and id = @id";
                }
                if(String.IsNullOrEmpty(originalName) == false)
                {
                    sql += $" and original_name like @original_name";
                }
                sql += " order by id";

                return db.Query<MastaOriginal>(sql,
                    new
                    {
                        id = id,
                        original_name = "%" + originalName + "%"
                    }
                    ).ToList();
            }
        }

        /// <summary>
        /// 検索（入力時照会用）
        /// </summary>
        /// <param name="originalName"></param>
        /// <returns></returns>
        public List<MastaOriginal> SearchInquiry(string originalName)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select
    id as Id,
    original_name as OriginalName
from
    ms_original
where
    0=0
";                
                if (String.IsNullOrEmpty(originalName) == false)
                {
                    sql += $" and original_name = @original_name";
                }
                sql += " order by id";

                return db.Query<MastaOriginal>(sql,
                    new
                    {                        
                        original_name = originalName
                    }
                    ).ToList();
            }
        }
    }
}
