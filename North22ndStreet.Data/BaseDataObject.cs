using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Collections.Specialized;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace North22ndStreet.Data
{
    public class BaseDataObject
    {
        private Database _db;

        protected string ConnectionString;

        public Database ConnectedDatabase
        {
            get { return _db; }
        }

        public BaseDataObject(string connectionString)
        {
            //NameValueCollection appSettings = ConfigurationManager.AppSettings;
            ConnectionStringSettingsCollection connectionStrings = ConfigurationManager.ConnectionStrings;

            this.ConnectionString = ConfigurationManager.ConnectionStrings[connectionString].ToString();

            try
            {
                _db = DatabaseFactory.CreateDatabase(connectionString);
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to create database with connection string value of " + connectionString, ex);
            }
        }

               
        /// <summary>
        /// Fill a dataset through the Microsoft Fill Dataset method for use with a strong typed dataset
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="procedureName"></param>
        /// <param name="tableNames"></param>
        /// <param name="parms"></param>
        /// <returns></returns>
        protected DataSet FillDataSet(DataSet ds, string procedureName, string[] tableNames, object[] parms)
        {
            _db.LoadDataSet(procedureName, ds, tableNames, parms);
            return ds;
        }

        protected DataSet FillDataSet(DataSet ds, string procedureName, string[] tableNames)
        {
            _db.LoadDataSet(procedureName, ds, tableNames);
            return ds;
        }

        protected DataSet FillDataSet(string procedureName, string[] tableNames)
        {
            DataSet ds = new DataSet();
            return FillDataSet(ds, procedureName, tableNames);
        }

        protected DataSet FillDataSet(string procedureName, string[] tableNames, object[] parms)
        {
            DataSet ds = new DataSet();
            return FillDataSet(ds, procedureName, tableNames, parms);
        }

        protected DataTable FillDataTable(string procedureName, object[] parms)
        {
            DataSet ds = FillDataSet(procedureName, new string[] { "Records" }, parms);
            return ds.Tables["Records"];
        }

        protected DataTable FillDataTable(string procedureName)
        {
            DataSet ds = FillDataSet(procedureName, new string[] { "Records" });
            return ds.Tables["Records"];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlText"></param>
        /// <returns></returns>
        protected DataTable FIllDataTableSQL(string sqlText)
        {
            DataSet ds = new DataSet();
            _db.LoadDataSet(CommandType.Text, sqlText, ds, new string[]{"Records"});
            return ds.Tables["Records"];
        }

        protected DataTable FillDataTable(DataSet ds, string procedureName, string tableName)
        {
            ds = FillDataSet(ds, procedureName, new string[] { tableName });
            return ds.Tables[tableName];
        }

        protected DataTable FillDataTable(DataSet ds, string procedureName, object[] parms, string tableName)
        {
            ds = FillDataSet(ds, procedureName, new string[] { tableName }, parms);
            return ds.Tables[tableName];
        }
    }
}
