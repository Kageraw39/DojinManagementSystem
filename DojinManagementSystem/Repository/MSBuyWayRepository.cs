using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;
using static DojinManagementSystem.Global;
using System.Configuration;

namespace DojinManagementSystem.Repository
{
    public class MSBuyWayRepository
    {
        DBConection _Connection = new DBConection();

        /// <summary>
        /// select(すべて)
        /// </summary>
        /// <returns></returns>
        public List<MastaBuyWay> Select()
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select
    id as Id,
    buy_way as BuyWay
from
    ms_buy_way
order by
    id
";
                return db.Query<MastaBuyWay>(sql).ToList();            
            }
        }

        /// <summary>
        /// select(id指定)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public MastaBuyWay SelectById(int id)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select
    id as Id,
    buy_way as BuyWay
from
    ms_buy_way
where
    id = @id
";
                return db.Query<MastaBuyWay>(sql, new { id = id }).SingleOrDefault();
            }
        }

        /// <summary>
        /// insert
        /// </summary>
        /// <param name="buyWay"></param>
        public void Insert(string buyWay)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
insert into ms_buy_way
(
    id,
    buy_way
)
values
(
    null,
    @buy_way
)
";
                db.Execute(sql, new { buy_way = buyWay });
            }
        }

        /// <summary>
        /// update(id指定)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="buyWay"></param>
        public void Update(int id,string buyWay)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
update ms_buy_way
set   
    buy_way = @buy_way
where
    id = @id
";
                db.Execute(sql, new {id = id, buy_way = buyWay });
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
delete from ms_buy_way
where
    id = @id
";
                db.Execute(sql, new { id = id });
            }
        }
    }
}
