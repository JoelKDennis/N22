using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using North22ndStreet.Business;

namespace North22ndStreet.Web.Merchants
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadComboBox();
            }
        }

        private void LoadComboBox()
        {
            cmbMerchants.DataSource = Merchant.GetBusinessList();
            cmbMerchants.DataTextField = "Name";
            cmbMerchants.DataValueField = "ID";
            cmbMerchants.DataBind();
            cmbMerchants.Items.Insert(0,new Telerik.Web.UI.RadComboBoxItem("--Choose A Merchant--", "0"));
        }

        protected void cmbMerchants_SelectedIndexChanged(object o, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
        {
            if (cmbMerchants.SelectedValue != "0")
            {
                Response.Redirect("2009Special.aspx?name=" + cmbMerchants.SelectedItem.Value + "&level=1");
            }
        }
    }
}
