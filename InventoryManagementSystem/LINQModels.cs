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

    [Table(Name = "JXFP进项发票")]
    public class JXFP进项发票
    {
        [Column]
        public int XH序号 { get; set; }

        [Column]
        public string FPDM发票代码 { get; set; }

        [Column]
        public string FPHM发票号码 { get; set; }

        [Column]
        public string SH税号 { get; set; }

        [Column]
        public DateTime KPSJ开票时间 { get; set; }

        [Column]
        public decimal JE金额 { get; set; }

        [Column]
        public decimal SE税额 { get; set; }

        [Column]
        public DateTime RZSJ认证时间 { get; set; }

        [Column]
        public string MC名称 { get; set; }

        [Column]
        public int LX类型 { get; set; }

        [Column]
        public string RKDH入库单号 { get; set; }
    }

    [Table(Name = "XXFP销项发票")]
    public class XXFP销项发票
    {
        [Column]
        public int XH序号 { get; set; }

        [Column]
        public string FPDM发票代码 { get; set; }

        [Column]
        public string FPHM发票号码 { get; set; }

        [Column]
        public string SH税号 { get; set; }

        [Column]
        public DateTime KPSJ开票时间 { get; set; }

        [Column]
        public decimal JE金额 { get; set; }

        [Column]
        public decimal SE税额 { get; set; }

        [Column]
        public DateTime BSSJ报送时间 { get; set; }

        [Column]
        public string MC名称 { get; set; }

        [Column]
        public int LX类型 { get; set; }

        [Column]
        public string CKDH出库单号 { get; set; }
    }

    [Table(Name = "JCB基础表")]
    public class JCB基础表
    {
        [Column]
        public string MC名称 { get; set; }

        [Column]
        public string SH税号 { get; set; }

        [Column]
        public DateTime YF月份 { get; set; }
    }
}
