using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using North22ndStreet.Business;

namespace North22ndStreet.Web.Merchants
{
    public partial class CategoryList : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            List<Merchant> bizList = new List<Merchant>();
            if (!string.IsNullOrEmpty(Request.QueryString["value"]))
            {
                bizList = Business.Merchant.GetBusinessList(Request.QueryString["value"]);
                foreach (var b in bizList)
                {
                    phMerchantList.Controls.Add(BizListing(b));
                }

                Category c = Category.GetByAbbreviation(Request.QueryString["value"]);
                phStyleSheet.Controls.Add(StyleSheet(c.FontColor));

                storelist.Style["background-image"] = "url('Merchants/CategoryImages/" + c.Abbreviation + ".jpg');";
                storelist.Style["background-repeat"] = "no-repeat;";
                if (bizList.Count == 0)
                {
                    phMerchantList.Controls.Add(NoMatches(c.FontColor));
                }
            }
        }

        private LiteralControl BizListing(Business.Merchant b)
        {            
            StringBuilder sb = new StringBuilder();
            sb.Append("<a href=\"2009Special.aspx?name=" + b.ID + "&level=1\">");
            sb.Append("<span class=\"MerchantLabel2\">" + b.Name + "</span><br/>" );
            sb.Append("<span class=\"MerchantLabel3\">" + b.Address + "</span><br/><br>");
            sb.Append("</a>");
            return new LiteralControl(sb.ToString());
        }

        private LiteralControl NoMatches(string fontColor)
        {
            return new LiteralControl("<span class=\"MerchantLabel3\" style=\"color:" + fontColor + "\">No Businesses exist for this category.</span>");
        }

        private LiteralControl StyleSheet(string fontColor)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<style type=\"text/css\">");
            sb.Append("a:link {COLOR:" + fontColor + "}");
            sb.Append("a:hover {COLOR:" + fontColor + "}");
            sb.Append("a:visited {COLOR:" + fontColor + "}");
            sb.Append("a:active {COLOR:" + fontColor + "}");
            sb.Append("</style>");
            return new LiteralControl(sb.ToString());
        }
    }
}