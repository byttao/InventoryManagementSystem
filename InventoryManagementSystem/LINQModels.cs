using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Data.SQLite;
using System.Text;

namespace InventoryManagementSystem
{
    public class SqliteDataContext : DataContext
    {
        public SqliteDataContext(string connection, MappingSource mappingSource) :
        base(connection, mappingSource)
        {
        }
        public SqliteDataContext(IDbConnection connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
        }
        public SqliteDataContext(string connectionString) :
            base(new SQLiteConnection(@"Data Source=" + connectionString + @".db;Version=3;"))
        {
        }
        public SqliteDataContext(IDbConnection connection) :
            base(connection)
        {
        }
    }

    [Table(Name = "Users")]  //特性表示将highscores类与数据库中名称为highscores的表
    public class Users
    {
        //[Column(IsPrimaryKey =true)]
        [Column]  //特性则对应数据库中的列
        public string username { get; set; }

        [Column]
        public string userpassword { get; set; }
    }

    [Table(Name = "Accounts")]  //特性表示将账套存放的表格
    public class Accounts
    {
        //[Column(IsPrimaryKey =true)]
        [Column]  //特性则对应数据库中的列
        public int ID { get; set; }

        [Column]
        public string name { get; set; }
    }
}
