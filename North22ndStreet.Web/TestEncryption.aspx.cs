using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using North22ndStreet.Business;

namespace North22ndStreet.Web
{
    public partial class TestEncryption : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEncrypt_Click(object sender, EventArgs e)
        {
            Security S = new Security();
            txtOutput.Text = S.EncryptData(txtInput.Text);
        }

        protected void btnDecrypt_Click(object sender, EventArgs e)
        {
            Security S = new Security();
            txtOutput.Text = S.DecryptData(txtInput.Text);
        }
    }
}
