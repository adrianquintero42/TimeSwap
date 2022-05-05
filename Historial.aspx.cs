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
    public partial class Historial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /**
             * Comprueba si el usuario es NULL
             * Si lo es te devuelve a la página de inicio de sesión
             * Si no lo es, crea en bucle una plantilla en la que se introduciran los datos de todos los servicios recuperados de la base de datos
             */

            if (Session["user"] == null)
                Response.Redirect("Login.aspx");


            ReservedServiceStatements reservedServiceStatements = new ReservedServiceStatements();
            string html = "";
            foreach (ReservedServicies reservedServices in reservedServiceStatements.SelectClosedServices((User)Session["user"]))
            {
                html += "<div class='row colorVesselTemplates'>";

                html += "<div class='col-lg-2 align-self-center'>";
                    html += "<h2>" + reservedServices.Title + "</h2>";
                html += "</div>";

                html += "<div class='col-lg-10'>";
                    html += "<h2>" + reservedServices.Duration + " horas</h2>";
                    html += "<h2>Fecha reserva " + reservedServices.ReservationDate.ToString("dd-MM-yyyy") + "</h2>";
                html += "</div>";

                html += "</div>";
            }
            vesselReservedServices.InnerHtml = html;
        }
    }
}