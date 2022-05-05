using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TimeSwap.DAL;
using TimeSwap.Model;

namespace TimeSwap
{
    public partial class Register : System.Web.UI.Page
    {
        private UsersStatements userStatements;
        protected void Page_Load(object sender, EventArgs e)
        {
            userStatements = new UsersStatements();
        }

        //TODO Los Console.Writeline hay que cambiarlos.
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (inputEmail.Text.Length > 0)
                if (inputPassword.Text.Length >= 6)
                    if (inputPassword.Text.Equals(inputPasswordRepeat.Text))
                        if (inputName.Text.Length >= 3)
                            if (inputSurname.Text.Length >= 3)
                                if (Regex.IsMatch(inputDate.Text, @"\d{4}-\d{2}-\d{2}", RegexOptions.IgnoreCase))
                                    if (inputNumber.Text.Length >= 9 && inputNumber.Text.Length <= 15)
                                    {
                                        DateTime enteredDate = DateTime.Parse(inputDate.Text);
                                        User user = new User
                                        {
                                            Email = inputEmail.Text,
                                            Password = inputPassword.Text,
                                            FirstName = inputName.Text,
                                            LastName = inputSurname.Text,
                                            Birthday = enteredDate,
                                            Phone = inputNumber.Text
                                        };
                                        userStatements.RegisterNewUser(user);
                                        Response.Redirect("Default.aspx");
                                    }
                                    else
                                        Response.Write("El número de teléfono debe tener una longitud mínima de 9 dígitos y máxima de 15");
                                else
                                    Response.Write("La fecha de nacimiento no tiene un formato válido");
                            else
                                Response.Write("El apellido deber tener una longitud mínima de 3 caracteres");
                        else
                            Response.Write("El nombre deber tener una longitud mínima de 3 caracteres");
                    else
                        Response.Write("Las contraseñas no coinciden");
                else
                    Response.Write("La contraseña debe tener una longitud mínima de 6 caracteres");
            else
                Response.Write("Introduce tú correo electrónico");
        }
    }
}