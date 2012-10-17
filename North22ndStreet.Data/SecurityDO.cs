using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace North22ndStreet.Data
{
    /// <summary>
    /// Contains all security methods that interact with database
    /// </summary>
    public class SecurityDO : BaseDataObject
    {
        public SecurityDO() : base("North22") { }

        public DataTable Verify(object[] parms)
        {
            return FillDataTable("dbo.VERIFY_PASSWORD_PROC", parms);
        }

        public  DataTable GetUser(object[] parms)
        {
            return FillDataTable("dbo.APPUSER_SELECT_PROC", parms);
        }
    }
}
