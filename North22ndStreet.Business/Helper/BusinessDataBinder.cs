using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;

namespace North22ndStreet.Business
{
    /// <summary>
    /// Bind data from DataTable to Developer Created Business Objects or List of Developer Created Business Objects.
    /// </summary>
    public class BusinessDataBinder
    {
        #region Properties

        private static Type ReturnType { get; set; }

        private static DataTable ReturnData { get; set; }

        private static object ReturnValue { get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Create new instance of BusinessDataBinder object
        /// </summary>
        public BusinessDataBinder() { }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Return User Defined Object or List of User Defined Objects populated with assigned data
        /// </summary>
        /// <typeparam name="TObject">Object or List of objects</typeparam>
        /// <param name="objData">DataTable containing data to be binded to object</param>
        /// <returns>Object or List of Objects with assigned data</returns>
        public static TObject BindData<TObject>(DataTable objData)
        {
            ReturnData = objData;
            ReturnType = typeof(TObject);
            if (ReturnType.GetInterface("IList") != null && ReturnType.IsGenericType)
            {
                Type argType = ReturnType.GetGenericArguments()[0];
                BindList(argType);
            }
            else
                BindObject(ReturnData.Rows[0]);
            return (TObject)ReturnValue;
        }

        /// <summary>
        /// Bind Data to object
        /// </summary>
        /// <param name="dr">DataRow containing data to bind</param>
        private static void BindObject(DataRow dr)
        {
            ReturnValue = Activator.CreateInstance(ReturnType);
            Type attrType = typeof(SqlFieldNameAttribute);
            PropertyInfo[] props = ReturnType.GetProperties();
            foreach (PropertyInfo prop in props)
            {
                object[] attrs = prop.GetCustomAttributes(attrType, true);
                if (attrs == null || attrs.Length == 0) continue;
                SqlFieldNameAttribute attr = attrs[0] as SqlFieldNameAttribute;

                if (dr.Table.Columns.Contains(attr.FieldName))
                {
                    if (dr[attr.FieldName] != DBNull.Value)
                        prop.SetValue(ReturnValue, dr[attr.FieldName], null);
                }
            }
        }

        /// <summary>
        /// Bind Data to list of objects
        /// </summary>
        /// <param name="pArgType">Generic Type argument</param>
        private static void BindList(Type pArgType)
        {
            IList list = Activator.CreateInstance(ReturnType) as IList;
            ReturnValue = list;
            PropertyInfo[] props = pArgType.GetProperties();
            Type attrtype = typeof(SqlFieldNameAttribute);
            foreach (DataRow dr in ReturnData.Rows)
            {
                object item = Activator.CreateInstance(pArgType);
                foreach (PropertyInfo prop in props)
                {
                    object[] attrs = prop.GetCustomAttributes(attrtype, true);
                    if (attrs == null || attrs.Length == 0) continue;
                    SqlFieldNameAttribute attr = attrs[0] as SqlFieldNameAttribute;

                    if (dr.Table.Columns.Contains(attr.FieldName))
                    {
                        if (dr[attr.FieldName] != DBNull.Value)
                            prop.SetValue(item, dr[attr.FieldName], null);
                    }
                }
                list.Add(item);
            }
        }

        #endregion Methods
    }
}
