using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.Context
{
    public class MSSqlDB : IDB
    {
        private SqlConnection DB;
        private string strcon;

        public MSSqlDB(IDBConfiguration config)
        {
            strcon = config.ConnectionString;
        }
        public void Dispose()
        {
            DB.Close();
            DB.Dispose();
        }

        public IDbConnection GetCon()
        {
            DB = new SqlConnection(strcon);
            return DB;
        }
    }
}
