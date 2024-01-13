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
    class MSEventRepository
    {
        DBConection _Connection = new DBConection();

        /// <summary>
        /// select(すべて)
        /// </summary>
        /// <returns></returns>
        public List<MastaEvent> Select()
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select
    id as Id,
    event_name as EventName,
    event_date as EventDate
from
    ms_event
order by
    id
";
                return db.Query<MastaEvent>(sql).ToList();
            }
        }

        /// <summary>
        /// select(id指定)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public MastaEvent SelectById(int id)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select
    id as Id,
    event_name as EventName,
    event_date as EventDate
from
    ms_event
where
    id = @id
";
                return db.Query<MastaEvent>(sql, new { id = id }).SingleOrDefault();
            }
        }

        /// <summary>
        /// insert
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="eventDate"></param>
        public void Insert(string eventName,DateTime eventDate)
        {
            //datetimeを日付のみのstirngに変換
            string ShortDate = eventDate.ToShortDateString();

            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
insert into ms_event
(
    id,
    event_name,
    event_date
)
values
(
    null,
    @event_name,
    @event_date
)
";
                db.Execute(sql, new { event_name = eventName, event_date = ShortDate });
            }
        }

        /// <summary>
        /// update(id指定)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="eventName"></param>
        /// <param name="eventDate"></param>
        public void Update(int id,string eventName,DateTime eventDate)
        {
            //datetimeを日付のみのstirngに変換
            string ShortDate = eventDate.ToShortDateString();

            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
update ms_event
set
    event_name = @event_name,
    event_date = @event_date
where
    id = @id
";
                db.Execute(sql, new { id = id, event_name = eventName, event_date = ShortDate });
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
delete from ms_event
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
        /// <param name="eventName"></param>
        /// <param name="eventDateFrom"></param>
        /// <param name="eventDateTo"></param>
        /// <returns></returns>
        public List<MastaEvent> Search(int? id,string eventName,DateTime? eventDateFrom,DateTime? eventDateTo)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select
    id as Id,
    event_name as EventName,
    event_date as EventDate
from
    ms_event
where
    0=0
";
                if(id != null)
                {
                    sql += $" and id = @id";
                }
                if(String.IsNullOrEmpty(eventName) == false)
                {
                    sql += $" and event_name like @event_name";
                }
                if(eventDateFrom != null)
                {
                    sql += $" and event_date >= @event_date_from";
                }
                if(eventDateTo != null)
                {
                    sql += $" and event_date <= @event_date_to";
                }
                sql += " order by id";

                return db.Query<MastaEvent>(sql,
                    new
                    {
                        id = id,
                        event_name = "%" + eventName + "%",
                        event_date_from = eventDateFrom,
                        event_date_to = eventDateTo
                    }
                    ).ToList();
            }
        }
    }
}
