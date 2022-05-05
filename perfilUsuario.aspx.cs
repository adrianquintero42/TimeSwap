using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TimeSwap.DAL;
using TimeSwap.Model;

namespace TimeSwap
{
    public partial class perfilUsuario : System.Web.UI.Page
    {
        private User user = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                user = (User)Session["user"];
                userImgView.ImageUrl = user.Image;
                if (!IsPostBack)
                {

                    inputCurrentUsername.Text = user.FirstName;
                    inputCurrentSurname.Text = user.LastName;
                    inputCurrentDate.Text = user.Birthday.ToString("yyyy-MM-dd");
                    inputCurrentNumber.Text = user.Phone;
                }
            }
        }

        protected void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            if (fileUploadControl.HasFile)
            {
                fileUploadControl.SaveAs(AppDomain.CurrentDomain.BaseDirectory + "UsersImages\\" + user.Id + ".jpg");
                user.Image = "UsersImages\\" + user.Id + ".jpg";
            } else
                if (user.Image.Equals(""))
                    user.Image = null;

            user.FirstName = inputCurrentUsername.Text;
            user.LastName = inputCurrentSurname.Text;
            user.Birthday = DateTime.Parse(inputCurrentDate.Text);
            user.Phone = inputCurrentNumber.Text;

            UsersStatements usersStatements = new UsersStatements();
            usersStatements.UptadeUserInformation(user);
        }
    }
}