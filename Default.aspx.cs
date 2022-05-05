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
    public partial class _Default : Page
    {

        UsersStatements usersStatements = new UsersStatements();
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            User user = usersStatements.CheckUserAndGetData(inputUsernameLogin.Text);

            if (inputPasswordLogin.Text.Equals(user.Password))
            {
                Session["user"] = user;
                Response.Redirect("paginaPrincipal.aspx");
            } else
            {
                Response.Write("Usuario o contraseña incorrecta.");
            }
        }
    }
}