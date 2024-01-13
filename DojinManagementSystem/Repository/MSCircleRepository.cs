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
    class MSCircleRepository
    {
        DBConection _Connection = new DBConection();

        /// <summary>
        /// select(全て)
        /// </summary>
        /// <returns></returns>
        public List<MastaCircle> Select()
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select
    id as Id,
    circle_name as CircleName,
    circle_master as CircleMaster
from
    ms_circle
order by
    id
";
                return db.Query<MastaCircle>(sql).ToList();
            }
        }

        /// <summary>
        /// select(id指定)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public MastaCircle SelectById(int id)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select
    id as Id,
    circle_name as CircleName,
    circle_master as CircleMaster
from
    ms_circle
where
    id = @id
";
                return db.Query<MastaCircle>(sql,new {id = id }).SingleOrDefault();
            }
        }

        /// <summary>
        /// insert
        /// </summary>
        /// <param name="circleName"></param>
        /// <param name="circleMaster"></param>
        public void Insert(string circleName, string circleMaster)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
insert into ms_circle
(
    id,
    circle_name,
    circle_master
)
values
(
    null,
    @circle_name,
    @circle_master
)
";
                db.Execute(sql, new { circle_name = circleName, circle_master = circleMaster });
            }
        }

        /// <summary>
        /// update(id指定)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="circleName"></param>
        /// <param name="circleMaster"></param>
        public void Update(int id,string circleName, string circleMaster)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
update ms_circle
set
    circle_name = @circle_name,
    circle_master = @circle_master
where
    id = @id
";
                db.Execute(sql, new { id = id, circle_name = circleName, circle_master = circleMaster });
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
delete from ms_circle
where
    id = @id
";
                db.Execute(sql, new { id = id });
            }
        }

        /// <summary>
        /// マスタ検索
        /// </summary>
        /// <param name="id"></param>
        /// <param name="circleName"></param>
        /// <param name="circleMasterName"></param>
        /// <returns></returns>
        public List<MastaCircle> Search(int? id,string circleName, string circleMasterName)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select
    id as Id,
    circle_name as CircleName,
    circle_master as CircleMaster
from
    ms_circle
where
    0=0
";
                if(id != null)
                {
                    sql += $" and id = @id";
                }
                if(String.IsNullOrEmpty(circleName) == false)
                {
                    sql += $" and circle_name like @circle_name";
                }
                if(string.IsNullOrEmpty(circleMasterName) == false)
                {
                    sql += $" and circle_master like @circle_master";
                }
                sql += " order by id";

                return db.Query<MastaCircle>(sql,
                    new {id = id , 
                        circle_name = "%" + circleName + "%", 
                        circle_master =  "%" + circleMasterName + "%"}
                    ).ToList();
            }
        }

        /// <summary>
        /// 検索（入力時照会用）
        /// </summary>
        /// <param name="masterName"></param>
        /// <returns></returns>
        public List<MastaCircle> SearchInquiry(string masterName)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select
    id as Id,
    circle_name as CircleName,
    circle_master as CircleMaster
from
    ms_circle
where
    0=0
";                
                if (string.IsNullOrEmpty(masterName) == false)
                {
                    sql += $" and circle_master = @circle_master";
                }
                sql += " order by id";

                return db.Query<MastaCircle>(sql,
                    new
                    {                       
                        circle_master = masterName
                    }
                    ).ToList();
            }
        }
    }
}
