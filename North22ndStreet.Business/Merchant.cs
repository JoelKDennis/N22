using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;
using North22ndStreet.Data;

namespace North22ndStreet.Business
{
    /// <summary>
    /// Represents a Business
    /// </summary>
    [Serializable()]
    public class Merchant
    {
        #region Properties

        /// <summary>
        /// Database generated business ID
        /// </summary>
        [SqlFieldName("BusinessID")]
        public int ID { get; set; }
        /// <summary>
        /// Name of Business
        /// </summary>
        [SqlFieldName("BusinessName")]
        public string Name { get; set; }
        /// <summary>
        /// STreet Address of business
        /// </summary>
        [SqlFieldName("Address")]
        public string Address { get; set; }
        /// <summary>
        /// CIty of business
        /// </summary>
        [SqlFieldName("City")]
        public string City { get; set; }
        /// <summary>
        /// State of business
        /// </summary>
        [SqlFieldName("State")]
        public string State { get; set; }
        /// <summary>
        /// Zip Code
        /// </summary>
        [SqlFieldName("Zip")]
        public string Zip { get; set; }

        /// <summary>
        /// Category associated with Business.
        /// </summary>
        [SqlFieldName("CategoryName")]
        public string CategoryName { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Get List of all Businesses
        /// </summary>
        /// <returns>List of Business objects</returns>
        public static List<Merchant> GetBusinessList()
        {
            BusinessCategoryData bcd = new BusinessCategoryData();            
            return BusinessDataBinder.BindData<List<Merchant>>(bcd.SelectBusiness(new object[] { DBNull.Value, DBNull.Value }));
        }

        /// <summary>
        /// Get List of Businesses within a selected category
        /// </summary>
        /// <param name="categoryAbbr">Specified Category Abbreviation</param>
        /// <returns>List of Business objects</returns>
        public static List<Merchant> GetBusinessList(string categoryName)
        {
            BusinessCategoryData bcd = new BusinessCategoryData();
            return BusinessDataBinder.BindData<List<Merchant>>(bcd.SelectBusinessByCategory(new object[] { categoryName }));
        }

        /// <summary>
        /// Get single business
        /// </summary>
        /// <param name="businessID">ID of business</param>
        /// <returns>Business object</returns>
        public static Merchant GetBusiness(int businessID)
        {
            BusinessCategoryData bcd = new BusinessCategoryData();
            return BusinessDataBinder.BindData<Merchant>(bcd.SelectBusiness(new object[] { businessID, DBNull.Value }));
        }

        /// <summary>
        /// Get single business
        /// </summary>
        /// <param name="businessName">Name of business</param>
        /// <returns>Business object</returns>
        public static Merchant GetBusiness(string businessName)
        {
            BusinessCategoryData bcd = new BusinessCategoryData();
            return BusinessDataBinder.BindData<Merchant>(bcd.SelectBusiness(new object[] { DBNull.Value, businessName }));
        }

        /// <summary>
        /// Get Business ID based on given BusinessCategoryID from node value in tree
        /// </summary>
        /// <param name="businessCategoryID">ID from tree</param>
        /// <returns>integer value</returns>
        public static int GetBusinessID(int businessCategoryID)
        {
            BusinessCategoryData bcd = new BusinessCategoryData();
            return (int)bcd.SelectBusinessIDFromBusinessCategory(new object[] { businessCategoryID });
        }

        /// <summary>
        /// Insert new business
        /// </summary>
        /// <param name="name">Name of business</param>
        /// <param name="address">Address of business</param>
        /// <param name="city">CIty</param>
        /// <param name="state">State</param>
        /// <param name="zip">Zip code</param>
        public static void Insert(string name, string address, string city, string state, string zip)
        {
            BusinessCategoryData bcd = new BusinessCategoryData();
            bcd.InsertBusiness(new object[] { name, address, city, state, zip });
        }

        /// <summary>
        /// Insert current instance of Business
        /// </summary>
        public void Insert()
        {
            Insert(Name, Address, City, State, Zip);
        }

        /// <summary>
        /// Update existing business
        /// </summary>
        /// <param name="businessID">ID of business to update</param>
        /// <param name="name">Name of business</param>
        /// <param name="address">Address of business</param>
        /// <param name="city">City</param>
        /// <param name="state">State</param>
        /// <param name="zip">Zip code </param>
        public static void Update(int businessID, string name, string address, string city, string state, string zip)
        {
            BusinessCategoryData bcd = new BusinessCategoryData();
            bcd.UpdateBusiness(new object[] { businessID, name, address, city, state, zip });
        }

        /// <summary>
        /// Update current instance of Business
        /// </summary>
        public void Update()
        {
            Update(ID, Name, Address, City, State, Zip);
        }

        /// <summary>
        /// Delete business from database
        /// </summary>
        /// <param name="businessID">ID of business</param>
        public static void Delete(int businessID)
        {
            BusinessCategoryData bcd = new BusinessCategoryData();
            bcd.DeleteBusiness(new object[] { businessID });
        }

        /// <summary>
        /// Delete current ID
        /// </summary>
        public void Delete()
        {
            Delete(ID);
        }

        #endregion Methods
    }
}
