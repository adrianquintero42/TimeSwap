using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using TimeSwap.DAL;
using TimeSwap.Model;

namespace TimeSwap
{
    public partial class paginaPrincipal : System.Web.UI.Page
    {
        public string userPhone;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            } else
            {
                ServicesStatements servicesStatements = new ServicesStatements();

                HtmlGenericControl htmlGenericControl = vesselTemplate;

                string html = "";
                foreach (Service service in servicesStatements.SelectServices(((User)Session["user"]).Id))
                {
                    html += "<div class='row colorVesselTemplates'>";
                    html += "<div class='col-lg-3 alignTextContainer'>";
                    if (service.UserImg == null || service.UserImg.Equals(""))
                        html += "<img src='./Content/webcam.png' class='imgUserAdvert' />";
                    else
                        html += "<img src='" + service.UserImg + "' class='imgUserAdvert'/>";
                    html += "<p>" + service.ServiceUser + "</p>";
                    html += "<p class='hiddenQuery'>Id servicio: " + service.Id + "</p>";
                    html += "<p class='hiddenQuery'>Id usuario: " + service.RIdUser + "</p>";
                    html += "<label>" + service.UserPhone + "</label>";
                    html += "</div>";
                    html += "<div class='col-lg-8 noticeText'>";
                    html += "<h2>" + service.Title + "</h2>";
                    html += "<p style='font-size: 1.5rem;'>" + service.DescriptionService + "</p>";
                    html += "</div>";
                    html += "<div class='col-lg-1 align-self-center'>";
                    html += "<h1>" + service.DurationService + "h</h1>";
                    html += "</div>";
                    html += "</div>";
                }
                htmlGenericControl.InnerHtml = html;
            }
        }
    }
}