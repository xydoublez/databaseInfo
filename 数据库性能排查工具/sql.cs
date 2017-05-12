using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 数据库性能排查工具
{
    public class sql
    {
        public const string  查看当前挂起的IO请求= @"SELECT 
        DB_NAME(S.database_id) AS DBName,
        S.file_id,
        S.io_stall,
        R.io_pending_ms_ticks
        FROM sys.dm_io_pending_io_requests R
        INNER JOIN sys.dm_io_virtual_file_stats(NULL,NULL) S
        ON R.io_handle=S.file_handle";
    }
}
