using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using North22ndStreet.Business;

namespace North22ndStreet.Web
{
    public partial class _009Special : System.Web.UI.Page
    {
        protected Business.Merchant B
        {
            get{return (Business.Merchant)ViewState["B"];}
            set{ViewState["B"] = value;}
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadStoreData();
                LoadComboBox();
            }            
        }

        private void LoadComboBox()
        {
            cmbMerchants.DataSource = Merchant.GetBusinessList();
            cmbMerchants.DataTextField = "Name";
            cmbMerchants.DataValueField = "ID";
            cmbMerchants.DataBind();
            cmbMerchants.Items.Insert(0, new Telerik.Web.UI.RadComboBoxItem("--Choose A Merchant--", "0"));
        }

        protected void cmbMerchants_SelectedIndexChanged(object o, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
        {
            if (cmbMerchants.SelectedValue != "0")
            {
                Response.Redirect("2009Special.aspx?name=" + cmbMerchants.SelectedItem.Value + "&level=1");
            }
        }

        private void LoadStoreData()
        {            
            if (!string.IsNullOrEmpty(Request.QueryString["name"]) && Request.QueryString["level"] != "0")
            {
                B = Merchant.GetBusiness(int.Parse(Request.QueryString["name"]));
                lblStoreName.Text = B.Name;
                lblStoreAddress.Text = B.Address;
            }
            if (!string.IsNullOrEmpty(Request.QueryString["value"]) && Request.QueryString["level"] != "0")
            {
                B = Business.Merchant.GetBusiness(Merchant.GetBusinessID(int.Parse(Request.QueryString["value"])));
                lblStoreName.Text = B.Name;
                lblStoreAddress.Text = B.Address;
            }
            if (!string.IsNullOrEmpty(Request.QueryString["level"]))
            {
                if (Request.QueryString["level"] == "0")
                {
                    phSpecial.Controls.Add(LoadControl("/Merchants/CategoryList.ascx"));
                    divTitle.Visible = false;
                    divSpacer.Visible = false;
                }
                else
                {
                    if (B != null)
                    {
                        divTitle.Visible = true;
                        switch (B.Name)
                        {
                            case "Tommy's Men Shop":
                                phSpecial.Controls.Add(LoadControl("/Merchants/Tommys/Tommys.ascx"));
                                break;
                            case "Tastykake Thrift Outlet Store":
                                phSpecial.Controls.Add(LoadControl("/Merchants/Tastykake/Tasty.ascx"));
                                break;
                            case "Dave's Fresh Meats":
                                phSpecial.Controls.Add(LoadControl("/Merchants/Daves/DavesUC.ascx"));
                                break;
                            case "Fe-Male Fashions":
                                phSpecial.Controls.Add(LoadControl("/Merchants/FemaleFashions/FemaleFashionsUC.ascx"));
                                break;
                            case "Group Cruises & Great Escapes":
                                phSpecial.Controls.Add(LoadControl("/Merchants/GCGE/GCGEUC.ascx"));
                                break;
                            case "Stop & Save Check Cash":
                                phSpecial.Controls.Add(LoadControl("/Merchants/StopNSave/StopnSaveUC.ascx"));
                                break;
                            case "Eric Holt Optical":
                                phSpecial.Controls.Add(LoadControl("/Merchants/EricHoltOptical/HoltOpticalUC.ascx"));
                                break;
                            default:
                                phSpecial.Controls.Add(LoadControl("/Merchants/SpecialsComingSoon.ascx"));
                                break;
                        }
                    }
                }
            }                            
        }


    }
}
