<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="perfilPassword.aspx.cs" Inherits="TimeSwap.perfilPassword" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row profileRow" id="securityRow">
        <div class="col-lg-1"></div>
        <div class="col-lg-3 containerNavProfile" id="navSecurity">
            <h4><a class="navProfile" href="./perfilUsuario.aspx">Editar cuenta</a></h4>
            <h4><a class="navProfile" href="./perfilPassword.aspx">Seguridad</a></h4>
            <h4><a class="navProfile" href="./perfilDelete.aspx">Eliminar cuenta</a></h4>
        </div>
        <div class="col-lg-7" id="containerUserSecurity">
            <div class="row">
                <div class="col-lg-2"></div>
                <div class="col-lg-8">
                    <div class="userDataForm">
                        <div class="form-row">
                            <label for="inputCurrentCurrentPassword" class="col-form-label col-lg-4">Contraseña actual</label>
                            <asp:TextBox type="text" class="form-control col-lg-8" ID="inputCurrentCurrentPassword" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-row">
                            <label for="inputCurrentNewPassword" class="col-form-label col-lg-4">Contraseña nueva</label>
                            <asp:TextBox type="password" class="form-control col-lg-8" ID="inputCurrentNewPassword" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-row">
                            <label for="inputCurrentDate" class="col-form-label col-lg-4">Confirma contraseña nueva</label>
                            <asp:TextBox type="password" class="form-control col-lg-8" ID="inputCurrentNewPasswordRepeat" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-row">
                            <div class="col-lg-4"></div>
                            <asp:Button type="submit" CssClass="btn btn-primary col-lg-3 btnProfile" Text="Confirmar" runat="server" ID="confirmPasswordChangeButton" OnClick="confirmPasswordChangeButton_Click" />
                            <div class="col-lg-5"></div>
                        </div>
                        <div class="form-row">
                            <div class="col-lg-3"></div>
                            <a class="col-lg-4" href="#">¿Olvidaste tu contraseña?</a>
                            <div class="col-lg-5"></div>
                        </div>
                    </div>
                </div>
                <div class="col-lg-2"></div>
            </div>
        </div>
        <div class="col-lg-1"></div>
    </div>

</asp:Content>
