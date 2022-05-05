using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using TimeSwap.DAL;
using TimeSwap.Model;

namespace TimeSwap
{
    public partial class paginaOtrosUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                User user = (User)Session["user"];
                if (!user.Image.Equals("")) userImageOtherUser.ImageUrl = user.Image;
                else userImageOtherUser.ImageUrl = "Content/logo-TS.png";

                nameLabelOtherUser.Text = user.FirstName + " " + user.LastName;
                earnedHoursLabelOtherUser.Text = user.EarnedHours.ToString();
                spentHoursLablelOtherUser.Text = user.SpentHours.ToString();
                balanceLabelOtherUser.Text = user.Balance.ToString();
                performedServicesLablelOtherUser.Text = user.PerformedServices.ToString();
                recievedServicesLablelOtherUser.Text = user.RecievedServices.ToString();

                ServicesStatements servicesStatements = new ServicesStatements();
                HtmlGenericControl htmlGenericControl = vesselOtherProfile;

                string html = "";
                foreach (Service service in servicesStatements.SelectServicesByID(((User)Session["user"]).Id))
                {
                    html += "<div class='row colorVesselTemplates'>";

                        html += "<div class='col-lg-2 align-self-center'>";
                        if (service.UserImg == null || service.UserImg.Equals(""))
                            html += "<img src='./Content/placeholder.svg' class='imgUserAdvert' />";
                        else
                            html += "<img src='" + service.UserImg + "' class='imgUserAdvert'/>";
                            html += "<h3 style='text-align:center;'>" + service.DurationService +"</h3>";
                        html += "</div>";

                        html += "<div class='col-lg-8'>";
                            html += "<p class='hiddenQuery' id='ideServicio'>Id servicio: " + service.Id + "</p>";
                            html += "<p class='hiddenQuery'>Id usuario: " + service.RIdUser + "</p>";
                            html += "<h3>" + service.Title + "</h3>";
                            html += "<p>" + service.DescriptionService + "</p>";
                        html += "</div>";

                        html += "<div class='col-lg-2 recordAlign align-self-center'>";
                            html += "<div id='btnEndService' data-toggle='modal' data-target='#modalCloseService'>Finalizar servicio</div>";
                        html += "</div>";

                    html += "</div>";
                }
                htmlGenericControl.InnerHtml = html;
            }
        }
    }
}