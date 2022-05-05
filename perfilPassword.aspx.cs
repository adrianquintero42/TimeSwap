using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TimeSwap.DAL;
using TimeSwap.Model;

namespace TimeSwap
{
    public partial class perfilPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void confirmPasswordChangeButton_Click(object sender, EventArgs e)
        {
            User user = (User)Session["user"];
            if (user.Password.Equals(inputCurrentCurrentPassword.Text))
                if (inputCurrentNewPassword.Text.Length >= 6)
                    if (inputCurrentNewPassword.Text.Equals(inputCurrentNewPasswordRepeat.Text))
                    {
                        UsersStatements usersStatements = new UsersStatements();
                        usersStatements.ChangePassword(user.Id, inputCurrentNewPassword.Text);
                    }

        }
    }
}