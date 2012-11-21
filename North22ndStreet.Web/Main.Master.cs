using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using North22ndStreet.Business;
using Telerik.Web.UI;

namespace North22ndStreet.Web
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadTree();
                SetLinks();
                SetCategoryRotator();
            }            
        }

        protected void SetCategoryRotator()
        {
            rotatorCategory.ScrollDirection = RotatorScrollDirection.Up | RotatorScrollDirection.Down;
        }

        protected void LoadTree()
        {
            rtvBusinessList.DataSource = StreetBusiness.TreeValues();
            rtvBusinessList.DataTextField = "TextValue";
            rtvBusinessList.DataValueField = "ID";
            rtvBusinessList.DataFieldID = "ID";
            rtvBusinessList.DataFieldParentID = "ParentID";
            rtvBusinessList.DataBind();
        }

        protected void SetLinks()
        {
            lnkAd1.NavigateUrl = "2009Special.aspx?name=" + Merchant.GetBusiness(imgAd1.AlternateText).ID.ToString() + "&level=1";
            lnkAd2.NavigateUrl = "2009Special.aspx?name=" + Merchant.GetBusiness(imgAd2.AlternateText).ID.ToString() + "&level=1";
            lnkAd3.NavigateUrl = "2009Special.aspx?name=" + Merchant.GetBusiness(imgAd3.AlternateText).ID.ToString() + "&level=1";
            lnkAd4.NavigateUrl = "2009Special.aspx?name=" + Merchant.GetBusiness(imgAd4.AlternateText).ID.ToString() + "&level=1";
            lnkAd5.NavigateUrl = "2009Special.aspx?name=" + Merchant.GetBusiness(imgAd5.AlternateText).ID.ToString() + "&level=1";
            lnkAd6.NavigateUrl = "2009Special.aspx?name=" + Merchant.GetBusiness(imgAd6.AlternateText).ID.ToString() + "&level=1";
        }


        protected void rtvBusinessList_NodeClick(object sender, Telerik.Web.UI.RadTreeNodeEventArgs e)
        {
            Response.Redirect("2009Special.aspx?value=" + e.Node.Value + "&level=" + e.Node.Level);
        }
    }
}
