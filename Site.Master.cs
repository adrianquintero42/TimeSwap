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
    public partial class SiteMaster : MasterPage
    {
        ServicesStatements servicesStatements;
        protected void Page_Load(object sender, EventArgs e)
        {
            servicesStatements = new ServicesStatements();
            if (Session["user"] != null)
            {
                if (((User)Session["user"]).Image == null || ((User)Session["user"]).Image.Equals("")) navBarUserImage.ImageUrl = "/Content/logo-TS.png";
                else navBarUserImage.ImageUrl = ((User)Session["user"]).Image;
            }
        }

        protected void btnPublishAdvert_Click(object sender, EventArgs e)
        {
            Service service = new Service
            {
                Title = advertTitle.Text,
                DescriptionService = advertDescription.Text,
                DurationService = Convert.ToInt32(advertDurationService.Text),
                //TypeService = checkboxType.Checked ? 1 : 0
            };
            servicesStatements.NewService(service, ((User)Session["user"]).Id);
            Response.Redirect("paginaPrincipal.aspx");
        }

        protected void btnCloseSession_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}