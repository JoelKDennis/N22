using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace North22ndStreet.Data
{
    /// <summary>
    /// Contains all methods to connect to database for Business, Category and BusinessCategory  data
    /// </summary>
    public class BusinessCategoryData : BaseDataObject
    {
        public BusinessCategoryData() : base("North22") { }

        #region Business Methods

        public DataTable SelectBusiness(object[] parms)
        {
            return FillDataTable("dbo.BUSINESS_SELECT_PROC", parms);
        }

        public DataTable SelectBusinessByCategory(object[] parms)
        {
            return FillDataTable("dbo.BUSINESSCATEGORY_BUSINESSES_SELECT_PROC", parms);
        }

        public void UpdateBusiness(object[] parms)
        {
            int x = ConnectedDatabase.ExecuteNonQuery("dbo.BUSINESS_UPDATE_PROC", parms);
        }

        public void InsertBusiness(object[] parms)
        {
            int x = ConnectedDatabase.ExecuteNonQuery("dbo.BUSINESS_INSERT_PROC", parms);
        }

        public void DeleteBusiness(object[] parms)
        {
            int x = ConnectedDatabase.ExecuteNonQuery("dbo.BUSINESS_DELETE_PROC", parms);
        }

        #endregion Business Methods

        #region Category Methods

        public DataTable SelectCategory(object[] parms)
        {
            return FillDataTable("dbo.CATEGORY_SELECT_PROC", parms);
        }

        public DataTable SelectCategoryByAbbr(object[] parms)
        {
            return FillDataTable("dbo.CATEGORY_BYABBR_SELECT_PROC", parms);
        }

        public void InsertCategory(object[] parms)
        {
            int x =ConnectedDatabase.ExecuteNonQuery("dbo.CATEGORY_INSERT_PROC", parms);
        }

        public void DeleteCategory(object[] parms)
        {
            int x = ConnectedDatabase.ExecuteNonQuery("dbo.CATEGORY_DELETE_PROC", parms);
        }

        public void UpdateCategory(object[] parms)
        {
            int x = ConnectedDatabase.ExecuteNonQuery("dbo.CATEGORY_UPDATE_PROC", parms);
        }
               
        #endregion Category Methods

        #region BusinessCategory Methods

        public DataTable SelectBusinessCategory(object[] parms)
        {
            return FillDataTable("dbo.BUSINESSCATEGORY_SELECT_PROC", parms);
        }

        public DataTable SelectBusinessCategoryTree()
        {
            return FillDataTable("dbo.BUSINESSCATEGORY_TREE_SELECT_PROC");
        }

        public object SelectBusinessIDFromBusinessCategory(object[] parms)
        {
            return ConnectedDatabase.ExecuteScalar("dbo.BUSINESSCATEGORY_BUSINESSID_SELECT_PROC", parms);
        }

        public void InsertBusinessCategory(object[] parms)
        {
            int x = ConnectedDatabase.ExecuteNonQuery("dbo.BUSINESSCATEGORY_INSERT_PROC", parms);
        }

        public void DeleteBusinessCategory(object[] parms)
        {
            int x = ConnectedDatabase.ExecuteNonQuery("dbo.BUSINESSCATEGORY_DELETE_PROC", parms);
        }

        #endregion BusinessCategory Methods

    }
}
