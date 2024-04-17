using System;
using System.Data.SqlClient;

namespace CRUD_MATRICULA
{
    internal class SqlCommandr
    {
        private string sql;
        private SqlConnection sqlConnection;

        public SqlCommandr(string sql, SqlConnection sqlConnection)
        {
            this.sql = sql;
            this.sqlConnection = sqlConnection;
        }

        public static implicit operator SqlCommand(SqlCommandr v)
        {
            throw new NotImplementedException();
        }
    }
}