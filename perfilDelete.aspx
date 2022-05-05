<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="perfilDelete.aspx.cs" Inherits="TimeSwap.perfilDelete" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row profileRow" id="profileDeleteRow">
        <div class="col-lg-1"></div>
        <div class="col-lg-3 containerNavProfile" id="navProfileDelete">
            <h4><a class="navProfile" href="./perfilUsuario.aspx">Editar cuenta</a></h4>
            <h4><a class="navProfile" href="./perfilPassword.aspx">Seguridad</a></h4>
            <h4><a class="navProfile" href="./perfilDelete.aspx">Eliminar cuenta</a></h4>
        </div>
        <div class="col-lg-7" id="containerProfileDelete">
            <div class="row">
                <div class="col-lg-2"></div>
                <div class="col-lg-8" id="colProfileDelete">

                    <p>Estás a punto de eliminar tu cuenta. Esta acción no tiene vuelta atrás.<br />¿Seguro que quieres seguir?</p>

                    <asp:Button CssClass="btn btn-primary col-lg-3 btnProfile btnProfileDelete" Text="Eliminar cuenta" runat="server" ID="DeleteProfileButton" OnClick="DeleteProfileButton_Click" />
                    <asp:LinkButton CssClass="btn btn-primary col-lg-3 btnProfile btnProfileDelete" href="./paginaPrincipal.aspx" Text="Volver" runat="server" />
                </div>

                <div class="col-lg-2"></div>
            </div>
        </div>
        <div class="col-lg-1"></div>
    </div>

</asp:Content>
