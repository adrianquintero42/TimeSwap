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
    public partial class perfilDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void DeleteProfileButton_Click(object sender, EventArgs e)
        {
            User user = (User)Session["user"];
            UsersStatements usersStatements = new UsersStatements();
            usersStatements.DeleteUser(user);
            Session["user"] = null;
            Response.Redirect("Default.aspx");

        }
    }
}