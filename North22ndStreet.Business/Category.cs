using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Reflection;
using North22ndStreet.Data;

namespace North22ndStreet.Business
{
    /// <summary>
    /// Represents a Category
    /// </summary>
    public class Category
    {
        #region Properties

        /// <summary>
        /// Database generated ID
        /// </summary>
        [SqlFieldName("CategoryID")]
        public int ID { get; set; }

        /// <summary>
        /// Category Name
        /// </summary>
        [SqlFieldName("CategoryName")]
        public string Name { get; set; }

        /// <summary>
        /// Category Abbreviation
        /// </summary>
        [SqlFieldName("CategoryAbbr")]
        public string Abbreviation { get; set; }

        /// <summary>
        /// Name of small category picture
        /// </summary>
        public string PictureNameSmall
        {
            get { return Abbreviation + "_s"; }
        }

        /// <summary>
        /// Color of font to be displayed
        /// </summary>
        [SqlFieldName("FontColor")]
        public string FontColor { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Get Catgory by abbreviation
        /// </summary>
        /// <param name="abbr">abbreviation of category</param>
        /// <returns>Category object</returns>
        public static Category GetByAbbreviation(string abbr)
        {
            BusinessCategoryData bcd = new BusinessCategoryData();
            return BusinessDataBinder.BindData<Category>(bcd.SelectCategoryByAbbr(new object[] { abbr }));
        }

        /// <summary>
        /// Select Categories form database
        /// </summary>
        /// <returns>List of all Categories in form on Category objects</returns>
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public static List<Category> GetCategories()
        {
            BusinessCategoryData bcd = new BusinessCategoryData();
            List<Category> catList = BusinessDataBinder.BindData<List<Category>>(bcd.SelectCategory(new object[] { DBNull.Value }));
            var sortedList = from c in catList orderby c.Name select c;
            return sortedList.ToList();
            
        }

        #endregion Methods
    }
}
