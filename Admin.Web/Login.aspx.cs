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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;
            
            if (FormsAuthentication.Authenticate(txtUsername.Text, txtPassword.Text))
                FormsAuthentication.RedirectFromLoginPage(txtUsername.Text, true);
            else
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Credentials cannot be verified.";
            }
            //int userID = Security.VerifyPassword(txtUsername.Text, txtPassword.Text);
            //if (userID != 0)
            //{
            //    CreateUserObject(userID);
            //    Response.Redirect("Administration.aspx");
            //}
            //else
            //{
            //    lblErrorMessage.Visible = true;
            //    lblErrorMessage.Text = "Credentials cannot be verified.";
            //}
        }

        private void CreateUserObject(int userID)
        {
            AppUser aUser = AppUser.GetUser(userID);
            aUser.Authenticated = true;
            Session["user"] = aUser;
        }
    }
}
