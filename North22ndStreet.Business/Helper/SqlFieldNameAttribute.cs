using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace North22ndStreet.Business
{
    /// <summary>
    /// Defines which properties should be binded from DataTable
    /// </summary>
    public class SqlFieldNameAttribute : Attribute
    {
        /// <summary>
        /// Name of field from database
        /// </summary>
        public readonly string FieldName = String.Empty;

        /// <summary>
        /// Create new instance of SqlFieldNameAttribute
        /// </summary>
        /// <param name="pFieldName"></param>
        public SqlFieldNameAttribute(string pFieldName)
        {
            FieldName = pFieldName;
        }
    }
}
