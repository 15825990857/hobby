using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace hobby.Data
{
    public abstract class DataBase
    {
        public abstract string ConnectionString { get;  }

        //public virtual DbProviderFactory DbProvider { get;  }
         
        public   DbParameter CreateParameter(DbCommand cmd,String pName, Object value, System.Data.DbType type)
        {
            var p = cmd.CreateParameter();
            p.ParameterName = pName;
            p.Value = (value == null ? DBNull.Value : value);
            p.DbType = type;
            return p;
        }

        public abstract DbCommand CreateCommand();


        public abstract DbConnection CreateConnection();
        
 

        public List<T> Select<T>(string sql,  Object paramObject=null)
        {
             
            DbConnection conn = null;
            try
            {
                conn = CreateConnection();
                conn.Open();
                var list=  Dapper.SqlMapper.Query<T>(conn, sql, paramObject);
                return list.ToList<T>();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }

        }
        public GridReader SelectMultiple(string sql, Object paramObject)
        {

            DbConnection conn = null;
            try
            {
                conn = CreateConnection();
                conn.Open();
                var list = Dapper.SqlMapper.QueryMultiple(conn, sql, paramObject);
                // return list.ToList<T>();
                return list;

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }

        }

        public List<dynamic> Select(string sql, Object paramObject=null)
        {

            DbConnection conn = null;
            try
            {
                conn = CreateConnection();
                conn.Open();
                var list = Dapper.SqlMapper.Query(conn, sql, paramObject);
                return list.ToList<dynamic>();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }

        }


        public  dynamic   Single(string sql, Object paramObject=null)
        {

            DbConnection conn = null;
            try
            {
                conn = CreateConnection();
                conn.Open();
                var list = Dapper.SqlMapper.QuerySingleOrDefault(conn, sql, paramObject);
                return list.ToList<dynamic>();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }

        }

        public T  Single<T>(string sql, Object paramObject=null)
        {

            DbConnection conn = null;
            try
            {
                conn = CreateConnection();
                conn.Open();
                var list = Dapper.SqlMapper.QuerySingleOrDefault<T>(conn, sql, paramObject);
                return list;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return default(T);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }

        }
        public T ExecuteScalar<T>(string sql, Object paramObject=null)
        {

            DbConnection conn = null;
            try
            {
                conn = CreateConnection();
                conn.Open();
                T t = Dapper.SqlMapper.ExecuteScalar<T>(conn, sql, paramObject);
                return t;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return default(T);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }

        }

        public int Execute(string sql , Object paramObject=null)
        {
 
            DbConnection conn = null;
            try
            {
                conn = CreateConnection();
                conn.Open();
                int count = Dapper.SqlMapper.Execute(conn, sql, paramObject);
                return count;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return 0;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        /// <summary>
        /// 自行维护事务和连接
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="sql"></param>
        /// <param name="paramObject"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public int ExecuteTran(DbConnection conn, string sql, Object paramObject, DbTransaction transaction)
        {
            int count = Dapper.SqlMapper.Execute(conn, sql, paramObject, transaction);
            return count;
        }


        public int Execute_Tran(DbConnection conn, string sql, Object paramObject, DbTransaction transaction)
        {
            int count = Dapper.SqlMapper.Execute(conn, sql, paramObject, transaction);
            return count;
        }


        public List<T> ExecuteStoredProcedure<T>(string sql, Object paramObject)
        {

            DbConnection conn = null;
            try
            {
                conn = CreateConnection();
                conn.Open();
                var list = Dapper.SqlMapper.Query<T>(conn, sql, paramObject,null,true,null, System.Data.CommandType.StoredProcedure);
                return list.ToList<T>();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }

        }

        public GridReader ExecuteStoredProcedureMultiple (string sql, Object paramObject)
        {

            DbConnection conn = null;
            try
            {
                conn = CreateConnection();
                conn.Open();
                var list = Dapper.SqlMapper.QueryMultiple(conn, sql, paramObject, null, null, System.Data.CommandType.StoredProcedure);
                // return list.ToList<T>();
                return list;
               
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }

        }


    }
}
