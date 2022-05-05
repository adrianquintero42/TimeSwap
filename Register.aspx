<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="TimeSwap.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/css/bootstrap.min.css" integrity="sha384-zCbKRCUGaJDkqS1kPbPd7TveP5iyJE0EjAuZQTgFLD2ylzuqKfdKlfG/eSrtxUkn" crossorigin="anonymous" />
    <link rel="stylesheet" href="./Content/Site.css"/>
</head>
<body>
    <form id="formRegister" runat="server">
        <div id="containerRegisterParent">
            <div id="containerRegisterRow" class="row containerRow">

                <div id="containerLogoRegister" class="col-lg-6 col-md-6 col-sm-12">
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

                <fieldset id="containerRegisterForm" class="col-lg-6 col-md-6 col-sm-12 containerForm">
                    <h1 id="titleRegister">Registro</h1>

                    <div class="form-row">
                        <div class="col-lg-3"></div>
                        <div class="form-group col-lg-6">
                            <asp:TextBox type="email" CssClass="form-control" ID="inputEmail" placeholder="correo@correo.com" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-3"></div>
                    </div>

                    <div class="form-row">
                        <div class="col-lg-3"></div>
                        <div class="form-group col-lg-3">
                            <asp:TextBox type="password" CssClass="form-control" ID="inputPassword" placeholder="Contraseña" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group col-lg-3">
                            <asp:TextBox type="password" CssClass="form-control" ID="inputPasswordRepeat" placeholder="Repetir contraseña" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-3"></div>
                    </div>

                    <br />

                    <div class="form-row">
                        <div class="col-lg-3"></div>
                        <div class="form-group col-lg-3">
                            <asp:TextBox type="text" CssClass="form-control" ID="inputName" placeholder="Nombre" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group col-lg-3">
                            <asp:TextBox type="text" CssClass="form-control" ID="inputSurname" placeholder="Apellidos" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-3"></div>
                    </div>

                    <div class="form-row">
                        <div class="col-lg-3"></div>
                        <div class="form-group col-lg-3">
                            <asp:TextBox type="date" CssClass="form-control" ID="inputDate" placeholder="Fecha de nacimiento" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group col-lg-3">
                            <asp:TextBox type="text" CssClass="form-control" ID="inputNumber" placeholder="Teléfono" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-3"></div>
                    </div>

                    <div class="form-row">
                        <div class="col-lg-3"></div>
                        <div class="form-check col-lg-8 termsCheck">
                        </div>
                        <div class="col-lg-3"></div>
                        <div class="col-lg-6">
                            <asp:Button CssClass="btn btn-primary col-lg-6 btnForm" ID="btnRegister" runat="server" Text="Registrarse" OnClick="btnRegister_Click" />
                        </div>
                    </div>


                </fieldset>
            </div>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.5.1/dist/jquery.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-fQybjgWLrvvRgtW6bFlB7jaZrFsaBXjsOMm/tB9LTS58ONXgqbR9W8oWht/amnpF" crossorigin="anonymous"></script>
</body>
</html>
