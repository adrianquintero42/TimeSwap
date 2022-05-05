<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TimeSwap.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/css/bootstrap.min.css" integrity="sha384-zCbKRCUGaJDkqS1kPbPd7TveP5iyJE0EjAuZQTgFLD2ylzuqKfdKlfG/eSrtxUkn" crossorigin="anonymous" />
    <link rel="stylesheet" href="./Content/Site.css" />
</head>
<body>
    <form runat="server">
        <div id="containerLoginParent">
            <div id="containerLoginRow" class="row containerRow">

                <div id="containerLogoLogin" class="col-lg-6 col-md-6 col-sm-12">
                    <div class="row h-100">
                        <div class="col-lg-7 my-auto logoTimeSwap">
                            <asp:Image CssClass="mx-auto d-block" runat="server" ImageUrl="~/Content/image.png" />
                        </div>
                        <div class="col-lg-5 my-auto mottoTimeSwap">
                            <h2>TIME SWAP</h2>
                            <h5>Una solución diferente</h5>
                        </div>
                    </div>
                </div>

                <fieldset id="containerLoginForm" class="col-lg-6 col-md-6 col-sm-12 containerForm">
                    <div>
                        <h1 id="titleRegister">Inicio de Sesión</h1>

                        <div class="form-row">
                            <div class="col-lg-3"></div>
                            <div class="form-group col-lg-6">
                                <asp:TextBox type="email" class="form-control" ID="inputUsernameLogin" placeholder="Nombre de usuario" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-lg-3"></div>
                        </div>

                        <div class="form-row">
                            <div class="col-lg-3"></div>
                            <div class="form-group col-lg-6">
                                <asp:TextBox type="password" class="form-control" ID="inputPasswordLogin" placeholder="Contraseña" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-lg-3"></div>
                        </div>

                        <asp:Button type="submit" CssClass="btn btn-primary col-lg-6 btnForm" ID="btnLogin" Text="Iniciar sesión" runat="server" OnClick="btnLogin_Click" />

                        <div class="form-group">
                            <p>¿No tienes cuenta? <a href="./Register.aspx">Regístrate</a></p>
                        </div>
                    </div>
                </fieldset>
            </div>
        </div>
        <script src="https://cdn.jsdelivr.net/npm/jquery@3.5.1/dist/jquery.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-fQybjgWLrvvRgtW6bFlB7jaZrFsaBXjsOMm/tB9LTS58ONXgqbR9W8oWht/amnpF" crossorigin="anonymous"></script>
    </form>

</body>
</html>
