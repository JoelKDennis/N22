using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using North22ndStreet.Data;

namespace North22ndStreet.Business
{
    public class StreetBusiness
    {
        #region Private Members

        public static StreetBusinessDO SBD = new StreetBusinessDO();

        #endregion Private Members

        #region Constructors

        /// <summary>
        /// Create empty instance of class
        /// </summary>
        public StreetBusiness() { }

        #endregion Constructors

        #region Properties



        #endregion Properties

        #region Methods

        /// <summary>
        /// Get values for RadTreeView
        /// </summary>
        /// <returns>DataTable containing values</returns>
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public static DataTable TreeValues()
        {
            return SBD.TreeValues();
        }

        #endregion Methods
    }
}
