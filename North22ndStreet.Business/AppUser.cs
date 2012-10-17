using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using North22ndStreet.Data;

namespace North22ndStreet.Business
{
    /// <summary>
    /// 
    /// </summary>
    public class AppUser
    {
        #region Public Properies

        /// <summary>
        /// ID of user
        /// </summary>
        [SqlFieldName("UserID")]
        public int UserID { get; set; }

        /// <summary>
        /// First name of user
        /// </summary>
        [SqlFieldName("FirstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name of user
        /// </summary>
        [SqlFieldName("LastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Email address of user
        /// </summary>
        [SqlFieldName("EmailAddress")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// IP Address of user
        /// </summary>
        public string IPAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Authenticated { get; set; }

        #endregion Public Properies

        #region Methods

        /// <summary>
        /// Return List of Users from database
        /// </summary>
        /// <returns>List of User objects</returns>
        public static List<AppUser> UserList()
        {
            SecurityDO sDO = new SecurityDO();
            return BusinessDataBinder.BindData<List<AppUser>>(sDO.GetUser(new object[] { DBNull.Value }));
        }

        /// <summary>
        /// Get User
        /// </summary>
        /// <param name="userID">ID of user</param>
        /// <returns>User object</returns>
        public static AppUser GetUser(int userID)
        {
            SecurityDO sDO = new SecurityDO();
            return BusinessDataBinder.BindData<AppUser>(sDO.GetUser(new object[] { userID }));
        }

        #endregion Methods
    }
}
