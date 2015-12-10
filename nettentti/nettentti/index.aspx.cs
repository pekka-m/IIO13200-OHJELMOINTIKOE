using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nettentti
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private DefaultBL bl;
        protected void Page_Load(object sender, EventArgs e)
        {
            bl = new DefaultBL();
        }

        protected void Button_login_Click(object sender, EventArgs e)
        {
            if (bl.tryLogin(TextBox_username.Text, TextBox_password.Text))
            {
                Response.Redirect("~/home.aspx");
            }
            else
            {
                Label_result.Text = "Käyttäjätunnus ja/tai salasana väärin!";
            }
        }
    }
}