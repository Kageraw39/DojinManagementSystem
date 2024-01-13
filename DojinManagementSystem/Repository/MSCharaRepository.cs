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
    class MSCharaRepository
    {
        DBConection _Connection = new DBConection();

        /// <summary>
        /// select(すべて)
        /// </summary>
        /// <returns></returns>
        public List<MastaChara> Select()
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select
    id as Id,
    chara_name as CharaName,
    flg_r18 as FlgR18
from
    ms_chara
order by
    id
";
                return db.Query<MastaChara>(sql).ToList();
            }
        }

        /// <summary>
        /// select(id指定)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public MastaChara SelectById(int id)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select
    id as Id,
    chara_name as CharaName,
    flg_r18 as FlgR18
from
    ms_chara
where
    id = @id
";
                return db.Query<MastaChara>(sql, new { id = id }).SingleOrDefault();
            }
        }

        /// <summary>
        /// insert
        /// </summary>
        /// <param name="charaName"></param>
        /// <param name="flgR18"></param>
        public void Insert(string charaName,bool flgR18)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
insert into ms_chara
(
    id,
    chara_name,
    flg_r18
)
values
(
    null,
    @chara_name,
    @flg_r18
)
";
                db.Execute(sql, new { chara_name = charaName, flg_r18 = flgR18 });
            }
        }

        /// <summary>
        /// update(id指定)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="charaName"></param>
        /// <param name="flgR18"></param>
        public void Update(int id,string charaName,bool flgR18)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
update ms_chara
set
    chara_name = @chara_name,
    flg_r18 = @flg_r18
where
    id = @id
";
                db.Execute(sql, new { id = id, chara_name = charaName, flg_r18 = flgR18 });
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
delete from ms_chara
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
        /// <param name="charaName"></param>
        /// <param name="existAllAge"></param>
        /// <param name="existR18"></param>
        /// <returns></returns>
        public List<MastaChara> Search(int? id,string charaName,bool existAllAge, bool existR18)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select
    id as Id,
    chara_name as CharaName,
    flg_r18 as FlgR18
from
    ms_chara
where
    0=0
";
                if(id != null)
                {
                    sql += $" and id = @id";
                }
                if (String.IsNullOrEmpty(charaName) == false)
                {
                    sql += $" and chara_name like @chara_name";
                }
                //existFlgの有無によって追加するsqlを追加する方針とする
                if (existAllAge == true && existR18 == false)
                {
                    sql += $" and flg_r18 = 0";
                }
                else if (existAllAge == false && existR18 == true)
                {
                    sql += $" and flg_r18 = 1";
                }
                sql += " order by id";

                return db.Query<MastaChara>(sql,
                    new
                    {
                        id = id,
                        chara_name = "%" + charaName + "%",
                    }
                    ).ToList();

            }
        }
    }
}
