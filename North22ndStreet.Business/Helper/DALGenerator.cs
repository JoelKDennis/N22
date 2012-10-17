using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using North22ndStreet.Data;

namespace North22ndStreet.Business
{
    /// <summary>
    /// Class used to connect to Database
    /// </summary>
    public class DataConnector : BaseDataObject
    {
        public DataConnector() : base("North22") { }

        public DataTable ProcNames()
        {
            return FIllDataTableSQL("Select name from sys.objects where type = 'P'");
        }

        public DataTable Parameters(string procName)
        {
            return FIllDataTableSQL("select * from INFORMATION_SCHEMA.PARAMETERS where SPECIFIC_NAME = '" + procName + "' order by ORDINAL_POSITION");
        }
    }
    
    public class DALGenerator
    {
        private List<StoredProc> StoredProcs = new List<StoredProc>();
        
        public DALGenerator()
        {
            StoredProcs = StoredProc.StoredProcData();            
        }

        
        public List<string> GenerateMethods()
        {
            List<string> generatedMethods = new List<string>();

            StringBuilder sb = new StringBuilder();
            foreach (var s in StoredProcs)
            {
                sb.Append("public ");
                switch (s.ProcType)
                {
                    case StoredProc.Operation.SELECT:
                        generatedMethods.Add(SelectMethod(s));
                        break;
                    case StoredProc.Operation.INSERT:
                        generatedMethods.Add(InsertMethod(s));
                        break;
                    case StoredProc.Operation.UPDATE:
                        generatedMethods.Add(UpdateMethod(s));
                        break;
                    case StoredProc.Operation.DELETE:
                        generatedMethods.Add(DeleteMethod(s));
                        break;
                }
            }
            return generatedMethods;
        }

        public string InsertMethod(StoredProc sp)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("public void Insert" + sp.TableModified + "(");
            
            return sb.ToString();
        }

        public string UpdateMethod(StoredProc sp)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("public void Update" + sp.TableModified + "(");
            return sb.ToString();
        }

        public string SelectMethod(StoredProc sp)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("public DataTable Get" + sp.TableModified + "(");
            return sb.ToString();
        }

        public string DeleteMethod(StoredProc sp)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("public void Delete" + sp.TableModified + "(");
            return sb.ToString();
        }

        public string BuildParameterList(List<Parameter> lp)
        {
            string dataType = string.Empty;

            foreach (Parameter p in lp)
            {
                switch (p.SqlType)
                {
                    case SqlDbType.BigInt:
                    case SqlDbType.Int:
                    case SqlDbType.SmallInt:
                    case SqlDbType.TinyInt:
                        dataType = "int";
                        break;
                    case SqlDbType.Bit:
                        dataType = "bool";
                        break;
                    case SqlDbType.Char:
                    case SqlDbType.NChar:
                    case SqlDbType.Text:
                    case SqlDbType.VarChar:
                    case SqlDbType.NVarChar:
                    case SqlDbType.NText:
                        dataType = "string";
                        break;
                    case SqlDbType.DateTime:
                    case SqlDbType.DateTime2:
                        dataType = "DateTime";
                        break;
                    case SqlDbType.Decimal:
                        dataType = "decimal";
                        break;
                    case SqlDbType.Float:
                        dataType = "float";
                        break;                    
                }
                
            }
            return "";
        }

        
    }

    /// <summary>
    /// Represents a Database Stored Procedure
    /// <remarks>Stored Proc should be named with the following pattern:
    /// TABLENAME_OPERATION_PROC</remarks>
    /// </summary>
    public class StoredProc
    {
        #region Properties

        #region Mapped Properties

        [SqlFieldName("name")]
        public string Name { get; set; }

        #endregion Mapped Properties

        #region Additional Properties

        public List<Parameter> ParameterList = new List<Parameter>();

        /// <summary>
        /// Table being modified
        /// </summary>
        public string TableModified { get; set; }

        /// <summary>
        /// Operation that the stored proc performs
        /// </summary>
        public Operation ProcType { get; set; }

        public bool Delete { get; set; }

        private static DataConnector dc = new DataConnector();

        #endregion Additional Properties

        #endregion Properties

        public enum Operation
        {
            SELECT,
            INSERT,
            UPDATE,
            DELETE
        }

        public static List<StoredProc> StoredProcData()
        {
            List<StoredProc> listInfo = BusinessDataBinder.BindData<List<StoredProc>>(dc.ProcNames());
            foreach (var s in listInfo)
            {
                s.SetAdditionalProperties();
                s.GetParameters();
            }
            var finalList = from s in listInfo
                            where s.Delete == false
                            select s;
            List<StoredProc> aL = finalList.ToList();
            return aL;
        }

        public void GetParameters()
        {
            ParameterList = Parameter.ParmList(Name);
        }

        /// <summary>
        /// Assign table name and operation type based on procedure name
        /// </summary>
        public void SetAdditionalProperties()
        {
            string[] procProps = Name.Split("_".ToCharArray());
            TableModified = procProps[0];
            Delete = false;
            try
            {
                ProcType = (Operation)Enum.Parse(typeof(Operation), procProps[1]);
            }
            catch
            {
                Delete = true;
            }
        }
    }

    public class Parameter
    {
        #region Mapped Properties

        [SqlFieldName("SPECIFIC_CATALOG")]
        public string SpecificCatalog { get; set; }

        [SqlFieldName("SPECIFIC_SCHEMA")]
        public string SpecificSchema { get; set; }

        [SqlFieldName("SPECIFIC_NAME")]
        public string ProcedureName { get; set; }

        [SqlFieldName("ORDINAL_POSITION")]
        public int OrdinalPosition { get; set; }

        [SqlFieldName("PARAMETER_MODE")]
        public string ParameterMode { get; set; }

        [SqlFieldName("IS_RESULT")]
        public string IsResult { get; set; }

        [SqlFieldName("AS_LOCATOR")]
        public string AsLocator { get; set; }

        [SqlFieldName("PARAMETER_NAME")]
        public string ParameterName { get; set; }

        [SqlFieldName("DATA_TYPE")]
        public string DataType { get; set; }

        [SqlFieldName("CHARACTER_MAXIMUM_LENGTH")]
        public int CharMaxLength { get; set; }

        [SqlFieldName("NUMERIC_PRECISION")]
        public int NumericPrecision { get; set; }

        [SqlFieldName("NUMERIC_SCALE")]
        public int NumericScale { get; set; }

        #endregion Mapped Properties

        public SqlDbType SqlType
        {
            get { return (SqlDbType)Enum.Parse(typeof(SqlDbType), DataType); }
        }

        private static DataConnector dc = new DataConnector();

        public static List<Parameter> ParmList(string procName)
        {
            return BusinessDataBinder.BindData<List<Parameter>>(dc.Parameters(procName));
        }
    }
}
