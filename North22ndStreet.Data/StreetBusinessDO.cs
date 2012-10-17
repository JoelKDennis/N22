using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;

namespace North22ndStreet.Data
{
    public class StreetBusinessDO : BaseDataObject
    {
        public StreetBusinessDO() : base("North22") { }

        public DataTable TreeValues()
        {
            return FillDataTable("BUSINESSCATEGORY_TREE_SELECT_PROC");
        }


    }
}
