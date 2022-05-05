<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="perfilUsuario.aspx.cs" Inherits="TimeSwap.perfilUsuario" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <!--<div class="row" style="border: 1px solid; height:100vh;">-->
    <div class="row profileRow" style="border: 1px solid;">
        <div class="col-lg-1"></div>
        <div class="col-lg-2 containerNavProfile">
            <h4><a class="navProfile" href="./perfilUsuario.aspx">Editar cuenta</a></h4>
            <h4><a class="navProfile" href="./perfilPassword.aspx">Seguridad</a></h4>
            <h4><a class="navProfile" href="./perfilDelete.aspx">Eliminar cuenta</a></h4>
        </div>
        <div class="col-lg-8" id="containerUserData">
            <div class="row">
                <div class="col-lg-2"></div>
                <div class="col-lg-8">
                    <div class="containerUserPicture">
                        <asp:Image ID="userImgView" runat="server" Height="250px" ImageUrl="Content/logo-TS.png" Width="250px" />
                        <h5>Cambiar foto</h5>
                        <asp:FileUpload runat="server" ID="fileUploadControl"/>
                    </div>
                    <hr class="separator" />
                    <div class="userDataForm">
                        <h4>Personal</h4>
                        <div class="form-row">
                            <label for="inputCurrentUsername" class="col-form-label col-lg-3">Nombre</label>
                            <div class="col-lg-1"></div>
                            <asp:TextBox type="text" CssClass="form-control col-lg-8" ID="inputCurrentUsername" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-row">
                            <label for="inputCurrentSurname" class="col-form-label col-lg-3">Apellidos</label>
                            <div class="col-lg-1"></div>
                            <asp:TextBox type="text" CssClass="form-control col-lg-8" ID="inputCurrentSurname" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-row">
                            <label for="inputCurrentDate" class="col-form-label col-lg-3">Fecha de nacimiento</label>
                            <div class="col-lg-1"></div>
                            <asp:TextBox type="date" class="form-control col-lg-8" ID="inputCurrentDate" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-row">
                            <label for="inputCurrentNumber" class="col-form-label col-lg-3">Teléfono</label>
                            <div class="col-lg-1"></div>
                            <asp:TextBox type="text" CssClass="form-control col-lg-8" ID="inputCurrentNumber" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <hr class="separator" />
                    <div class="userDataForm" id="containerBtnUpdate">
                        <asp:Button CssClass="btn btn-primary col-lg-6 btnProfile" ID="btnUpdateProfile" Text="Guardar" runat="server" OnClick="btnUpdateProfile_Click" />
                    </div>

                </div>

                <div class="col-lg-2"></div>
            </div>
        </div>
        <div class="col-lg-1"></div>
    </div>

    <!-- Modal Test -->
    <div class="modal fade" id="modalPrueba" tabindex="-1" aria-labelledby="modalPruebaLabel" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="modalPruebaLabel">Modal title</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    ...
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <button type="button" class="btn btn-primary">Save changes</button>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
