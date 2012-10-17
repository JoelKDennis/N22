using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using North22ndStreet.Business;

namespace North22Admin.Web
{
    public partial class Administration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckSecurity();
        }

        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);
            //CheckSecurity();
        }

        private void CheckSecurity()
        {
            //if (Session["user"] == null)
            //    Response.Redirect("Unauthorized.aspx");
            //else
            //{
            //    AppUser aU = (AppUser)Session["user"];
            //}
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //Session["user"] = null;
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }
    }
}
