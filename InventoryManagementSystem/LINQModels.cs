﻿using System;
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

    [Table(Name = "YH用户")]  //特性表示将highscores类与数据库中名称为highscores的表
    public class YH用户
    {
        //[Column(IsPrimaryKey =true)]
        [Column]  //特性则对应数据库中的列
        public string YHMC用户名称 { get; set; }

        [Column]
        public string YHMM用户密码 { get; set; }
    }

    [Table(Name = "ZT账套")]  //特性表示将账套存放的表格
    public class ZT账套
    {
        //[Column(IsPrimaryKey =true)]
        [Column]  //特性则对应数据库中的列
        public int XH序号 { get; set; }

        [Column]
        public string MC名称 { get; set; }
    }

    [Table(Name = "CK仓库")]
    public class CK仓库
    {
        [Column]
        public int XH序号 { get; set; }

        [Column]
        public string MC名称 { get; set; }

        [Column]
        public string DZ地址 { get; set; }
    }

}
