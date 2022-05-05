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
    public partial class PerfilPersonal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            Refresh();

            ServicesStatements servicesStatements = new ServicesStatements();
            HtmlGenericControl htmlGenericControl = vesselUserProfile;

            string html = "";
            foreach (Service service in servicesStatements.SelectServicesByID(((User)Session["user"]).Id))
            {
                html += "<div class='row colorVesselTemplates'>";

                html += "<div class='col-lg-2 align-self-center'>";
                if (service.UserImg == null || service.UserImg.Equals(""))
                    html += "<img src='./Content/placeholder.svg' class='imgUserAdvert' />";
                else
                    html += "<img src='" + service.UserImg + "' class='imgUserAdvert'/>";
                html += "<h3 style='text-align:center;'>" + service.DurationService + " horas</h3>";
                html += "</div>";

                html += "<div class='col-lg-10'>";
                html += "<p>Identificador de servicio: " + service.Id + "</p>";
                html += "<p class='hiddenQuery'>Id usuario: " + service.RIdUser + "</p>";
                html += "<h3>" + service.Title + "</h3>";
                html += "<p>" + service.DescriptionService + "</p>";
                html += "</div>";

                html += "</div>";
            }
            htmlGenericControl.InnerHtml = html;

        }

        protected void ConfirmUser_Click(object sender, EventArgs e)
        {
            ServicesStatements servicesStatements = new ServicesStatements();
            servicesStatements.UptadeServiceState(int.Parse(serviceIDTextBox.Text));
            UsersStatements usersStatements = new UsersStatements();
            int userID = usersStatements.SearchUser(mailCloseService.Text);
            ReservedServiceStatements reservedServiceStatements = new ReservedServiceStatements();
            DateTime date = DateTime.Now;
            reservedServiceStatements.InsertNewClosedService(date, int.Parse(serviceIDTextBox.Text), userID, ((User)Session["user"]).Id);
            usersStatements.UpdateUserServiceData(userID, ((User)Session["user"]).Id, Int32.Parse(serviceIDTextBox.Text), servicesStatements);
            Response.Redirect("PerfilPersonal.aspx");
            Refresh();
        }

        private void Refresh()
        {
            UsersStatements usersStatements = new UsersStatements();
            User user = usersStatements.CheckUserAndGetData(((User)Session["user"]).Email);
            Session["user"] = user;
            if (!user.Image.Equals("") && user.Image != null) userImage.ImageUrl = user.Image;
            else userImage.ImageUrl = "/Content/logo-TS.png";

            nameLabel.Text = user.FirstName + " " + user.LastName;
            earnedHoursLabel.Text = user.EarnedHours.ToString();
            spentHoursLablel.Text = user.SpentHours.ToString();
            balanceLabel.Text = user.Balance.ToString();
            performedServicesLablel.Text = user.PerformedServices.ToString();
            recievedServicesLablel.Text = user.RecievedServices.ToString();
        }
    }
}