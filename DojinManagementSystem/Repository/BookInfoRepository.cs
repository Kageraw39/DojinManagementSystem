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
    class BookInfoRepository
    {
        DBConection _Connection = new DBConection();

        /// <summary>
        /// select（すべて）
        /// </summary>
        /// <returns></returns>
        public List<TableBookInfo> Select()
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select
    book_id as BookId,
    book_name as BookName,
    series_no as SeriesNo,
    first_name as FirstName,
    first_id as FirstId,
    circle_id as CircleId,
    author as Author,
    event_id as EventId,
    publish_date as PublishDate,
    genre_id as GenreId,
    original_id as OriginalId,
    flg_r18 as FlgR18,
    flg_omnibus as FlgOmnibus,
    flg_joint as FlgJoint,
    flg_copy as FlgCopy,
    size_id as SizeId,
    buy_date as BuyDate,
    price as Price,
    buyway_id as BuyWayId,
    memo as Memo,
    flg_delete as FlgDelete,
    create_date as CreateDate,
    update_date as UpdateDate
from
    t_book_inf
order by 
    book_id    
";
                return db.Query<TableBookInfo>(sql).ToList();
            }
        }

        /// <summary>
        /// select(id指定)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TableBookInfo SelectById(int id)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select
    book_id as BookId,
    book_name as BookName,
    series_no as SeriesNo,
    first_name as FirstName,
    first_id as FirstId,
    circle_id as CircleId,
    author as Author,
    event_id as EventId,
    publish_date as PublishDate,
    genre_id as GenreId,
    original_id as OriginalId,
    flg_r18 as FlgR18,
    flg_omnibus as FlgOmnibus,
    flg_joint as FlgJoint,
    flg_copy as FlgCopy,
    size_id as SizeId,
    buy_date as BuyDate,
    price as Price,
    buyway_id as BuyWayId,
    memo as Memo,
    flg_delete as FlgDelete,
    create_date as CreateDate,
    update_date as UpdateDate
from
    t_book_inf
where
    book_id = @id
";
                return db.Query<TableBookInfo>(sql, new { id = id }).SingleOrDefault();
            }
        }

        /// <summary>
        /// Insert（挿入Idを返却）
        /// </summary>
        /// <param name="tableBookInfo"></param>
        /// <returns></returns>
        public int Insert(TableBookInfo tableBookInfo)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
insert into t_book_inf
(
    book_id,
    book_name,
    series_no,
    first_name,
    first_id,
    circle_id,
    author,
    event_id,
    publish_date,
    genre_id,
    original_id,
    flg_r18,
    flg_omnibus,
    flg_joint,
    flg_copy,
    size_id,
    buy_date,
    price,
    buyway_id,
    memo,
    flg_delete,
    create_date,
    update_date
)
values
(
    null,
    @book_name,
    @series_no,
    @first_name,
    @first_id,
    @circle_id,
    @author,
    @event_id,
    @publish_date,
    @genre_id,
    @original_id,
    @flg_r18,
    @flg_omnibus,
    @flg_joint,
    @flg_copy,
    @size_id,
    @buy_date,
    @price,
    @buyway_id,
    @memo,
    @flg_delete,
    @create_date,
    @update_date
);
select cast(LAST_INSERT_ID() as unsigned integer);
";
                int ret;
                 ret = db.Query<int>
                    (sql,
                    new {book_name = tableBookInfo.BookName,
                        series_no = tableBookInfo.SeriesNo,
                        first_name = tableBookInfo.FirstName,
                        first_id = tableBookInfo.FirstId,
                        circle_id = tableBookInfo.CircleId,
                        author = tableBookInfo.Author,
                        event_id = tableBookInfo.EventId,
                        publish_date = tableBookInfo.PublishDate,
                        genre_id = tableBookInfo.GenreId,
                        original_id = tableBookInfo.OriginalId,
                        flg_r18 = tableBookInfo.FlgR18,
                        flg_omnibus = tableBookInfo.FlgOmnibus,
                        flg_joint = tableBookInfo.FlgJoint,
                        flg_copy = tableBookInfo.FlgCopy,
                        size_id = tableBookInfo.SizeId,
                        buy_date = tableBookInfo.BuyDate,
                        price = tableBookInfo.Price,
                        buyway_id = tableBookInfo.BuyWayId,
                        memo = tableBookInfo.Memo,
                        flg_delete = tableBookInfo.FlgDelete,
                        create_date = DateTime.Now.ToString(),
                        update_date = DateTime.Now.ToString()
                    }).Single();
                return ret;
            }
        }

        /// <summary>
        /// Update(ID指定)
        /// </summary>
        /// <param name="tableBookInfo"></param>
        public void Update(TableBookInfo tableBookInfo)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
update t_book_inf
set   
    book_name = @book_name,
    series_no = @series_no,
    first_name = @first_name,
    first_id = @first_id,
    circle_id = @circle_id,
    author = @author,
    event_id = @event_id,
    publish_date = @publish_date,
    genre_id = @genre_id,
    original_id = @original_id,
    flg_r18 = @flg_r18,
    flg_omnibus = @flg_omnibus,
    flg_joint = @flg_joint,
    flg_copy = @flg_copy,
    size_id = @size_id,
    buy_date = @buy_date,
    price = @price,
    buyway_id = @buyway_id,
    memo = @memo,
    flg_delete = @flg_delete,
    update_date = @update_date
where
    book_id = @book_id
";
                db.Execute(sql,
                    new 
                    {
                        book_id = tableBookInfo.BookId,
                        book_name = tableBookInfo.BookName,
                        series_no = tableBookInfo.SeriesNo,
                        first_name = tableBookInfo.FirstName,
                        first_id = tableBookInfo.FirstId,
                        circle_id = tableBookInfo.CircleId,
                        author = tableBookInfo.Author,
                        event_id = tableBookInfo.EventId,
                        publish_date = tableBookInfo.PublishDate,
                        genre_id = tableBookInfo.GenreId,
                        original_id = tableBookInfo.OriginalId,
                        flg_r18 = tableBookInfo.FlgR18,
                        flg_omnibus = tableBookInfo.FlgOmnibus,
                        flg_joint = tableBookInfo.FlgJoint,
                        flg_copy = tableBookInfo.FlgCopy,
                        size_id = tableBookInfo.SizeId,
                        buy_date = tableBookInfo.BuyDate,
                        price = tableBookInfo.Price,
                        buyway_id = tableBookInfo.BuyWayId,
                        memo = tableBookInfo.Memo,
                        flg_delete = tableBookInfo.FlgDelete,
                        update_date = DateTime.Now.ToString()
                    });
            }
        }

        /// <summary>
        /// Delete(ID指定)
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
delete from t_book_inf
where
    book_id = @id
";
                db.Execute(sql, new { id = id });
            }
        }

        /// <summary>
        /// 同人情報簡易検索
        /// 空のdatasource設定用に結果が一つも帰ってこないsqlを生成できるようにする
        /// </summary>
        /// <param name="id"></param>
        /// <param name="bookName"></param>
        /// <param name="circleId"></param>
        /// <param name="originalId"></param>
        /// <returns></returns>
        public List<TableBookInfo> SearchLite(int? id,string bookName,int? circleId,int? originalId,bool? flgR18,bool getEmpty)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select
    book_id as BookId,
    book_name as BookName,
    series_no as SeriesNo,
    first_name as FirstName,
    first_id as FirstId,
    circle_id as CircleId,
    author as Author,
    event_id as EventId,
    publish_date as PublishDate,
    genre_id as GenreId,
    original_id as OriginalId,
    flg_r18 as FlgR18,
    flg_omnibus as FlgOmnibus,
    flg_joint as FlgJoint,
    flg_copy as FlgCopy,
    size_id as SizeId,
    buy_date as BuyDate,
    price as Price,
    buyway_id as BuyWayId,
    memo as Memo,
    flg_delete as FlgDelete,
    create_date as CreateDate,
    update_date as UpdateDate
from
    t_book_inf
where
    0=0
";
                if (id != null)
                {
                    sql += $" and book_id = @id";
                }
                if (String.IsNullOrEmpty(bookName) == false)
                {
                    sql += $" and book_name like @book_name";
                }
                if (circleId != null)
                {
                    sql += $" and circle_id = @circle_id";
                }
                if (originalId != null)
                {
                    sql += $" and original_id = @original_id";
                }
                if(flgR18 != null)
                {
                    if(flgR18 == true)
                    {
                        sql += $" and flg_r18 = 1";
                    }
                    else if(flgR18 == false)
                    {
                        sql += $" and flg_r18 = 0";
                    }
                }
                if (getEmpty == true)
                {
                    sql += $" and 1=0";
                }
                sql += $" order by book_id";

                return db.Query<TableBookInfo>(sql,
                    new
                    {
                        id = id,
                        book_name = "%" + bookName + "%",
                        circle_id = circleId,
                        original_id = originalId
                    }).ToList();                   
            }
        }

        /// <summary>
        /// 同人情報検索(入力時の照会用)
        /// </summary>       
        /// <param name="bookName"></param>        
        /// <returns></returns>
        public List<TableBookInfo> SearchInquiry(string bookName)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select
    book_id as BookId,
    book_name as BookName,
    series_no as SeriesNo,
    first_name as FirstName,
    first_id as FirstId,
    circle_id as CircleId,
    author as Author,
    event_id as EventId,
    publish_date as PublishDate,
    genre_id as GenreId,
    original_id as OriginalId,
    flg_r18 as FlgR18,
    flg_omnibus as FlgOmnibus,
    flg_joint as FlgJoint,
    flg_copy as FlgCopy,
    size_id as SizeId,
    buy_date as BuyDate,
    price as Price,
    buyway_id as BuyWayId,
    memo as Memo,
    flg_delete as FlgDelete,
    create_date as CreateDate,
    update_date as UpdateDate
from
    t_book_inf
where
    0=0
";               
                if (String.IsNullOrEmpty(bookName) == false)
                {
                    sql += $" and book_name = @book_name";
                }                
                sql += $" order by book_id";

                return db.Query<TableBookInfo>(sql,
                    new
                    {                       
                        book_name = bookName                       
                    }).ToList();
            }
        }

        /// <summary>
        /// 同人誌検索用（一覧画面検索用）
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public List<ViewBookInfoAbstract> SearchAbstracts(SearchEntity entity)
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select distinct
    tb.book_id as BookId
    ,tb.book_name as BookName
    ,mc.circle_name as CircleName
    ,mg.genre_name as GenreName
    ,mo.original_name as OriginalName
    ,tb.publish_date as PublishDate
    ,tb.flg_r18 as FlgR18
    ,tb.flg_omnibus as FlgOmnibus
    ,tb.flg_joint as FlgJoint
from
    t_book_inf as tb
    left join t_chara_inf as  tc on tb.book_id = tc.book_id
    left join ms_circle as mc on tb.circle_id = mc.id
    left join ms_genre as mg on tb.genre_id = mg.id
    left join ms_original as mo on tb.original_id = mo.id          
where
    0=0
";
                //以下検索条件
                //タイトル
                if (String.IsNullOrEmpty(entity.Title) == false)
                {
                    sql += $" and tb.book_name like @book_name";
                }
                //サークルID
                if (entity.CircleId != null)
                {
                    sql += $" and tb.circle_id = @circle_id";
                }
                //サークル名と作者名（サークルID空白の場合）
                else
                {
                    if(string.IsNullOrEmpty(entity.CircleName) == false)
                    {
                        sql += $" and mc.circle_name = @circle_name";
                    }
                    if(string.IsNullOrEmpty(entity.Author) == false)
                    {
                        sql += $" and tb.author = @author";
                    }
                }
                //イベントID
                if(entity.EventId != null)
                {
                    sql += $" and tb.event_id = @event_id";
                }
                //発行日(From)
                if(entity.PubulishDateFrom != null)
                {
                    sql += $" and tb.publish_date >= @publish_date_from";
                }
                //発行日(To)
                if(entity.PubulishDateTo != null)
                {
                    sql += $" and tb.publish_date <= @publish_date_to";
                }
                //ジャンルID
                if(entity.GenreId != null)
                {
                    sql += $" and tb.genre_id = @genre_id";
                }
                //原作ID
                if(entity.OriginalId != null)
                {
                    sql += $" and tb.original_id = @original_id";
                }
                //特徴
                if(entity.CharaId != null)
                {
                    sql += $" and tc.chara_id = @chara_id";
                }
                //R18フラグ
                if(entity.FlgR18 != null)
                {
                    sql += $" and flg_r18 = @flg_r18";
                }
                //総集編フラグ
                if(entity.FlgOmnibus != null)
                {
                    sql += $" and flg_omnibus = @flg_omnibus";
                }
                //合同誌フラグ
                if(entity.FlgJoint != null)
                {
                    sql += $" and flg_joint = @flg_joint";
                }
                //コピー誌フラグ
                if(entity.FlgCopy != null)
                {
                    sql += $" and flg_copy = @flg_copy";
                }
                sql += $" order by tb.book_id";

                return db.Query<ViewBookInfoAbstract>(sql,
                    new
                    {
                        book_name = "%" + entity.Title + "%",
                        circle_id = entity.CircleId,
                        circle_name = entity.CircleName,
                        author = entity.Author,
                        event_id = entity.EventId,
                        publish_date_from = entity.PubulishDateFrom,
                        publish_date_to = entity.PubulishDateTo,
                        genre_id = entity.GenreId,
                        original_id = entity.OriginalId,
                        chara_id = entity.CharaId,
                        flg_r18 = entity.FlgR18,
                        flg_omnibus = entity.FlgOmnibus,
                        flg_joint = entity.FlgJoint,
                        flg_copy = entity.FlgCopy,
                    }).ToList();                
            }
        }

        /// <summary>
        /// 同人誌情報検索
        /// </summary>
        /// <param name="tableBookInfo"></param>
        /// <returns></returns>
        public List<TableBookInfo> SearchFull()
        {
            using (var db = new MySqlConnection(_Connection.GetConnection()))
            {
                var sql = $@"
select
    book_id as BookId,
    book_name as BookName,
    series_no as SeriesNo,
    first_name as FirstName,
    first_id as FirstId,
    circle_id as CircleId,
    author as Author,
    event_id as EventId,
    publish_date as PublishDate,
    genre_id as GenreId,
    original_id as OriginalId,
    flg_r18 as FlgR18,
    flg_omnibus as FlgOmnibus,
    flg_joint as FlgJoint,
    flg_copy as FlgCopy,
    size_id as SizeId,
    buy_date as BuyDate,
    price as Price,
    buyway_id as BuyWayId,
    memo as Memo,
    flg_delete as FlgDelete,
    create_date as CreateDate,
    update_date as UpdateDate
from
    t_book_inf
where
    0=0
";
                return null;
            }
        }
    }
}
