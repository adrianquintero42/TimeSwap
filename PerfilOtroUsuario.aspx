<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PerfilOtroUsuario.aspx.cs" Inherits="TimeSwap.paginaOtrosUsuarios" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row" style="margin-top: 2rem;">
        <div class="col-lg-2"></div>
        <div class="col-lg-8 colorVesselCol" >

            <div class="row colorVesselTemplates" id="userInfoProfile" style="border: 1px solid;">
                <div class="col-lg-3" style="border: 1px solid;">
                    <asp:Image ID="userImageOtherUser" runat="server" CssClass="imgUserAdvert" />
                </div>
                <div class="col-lg-9" style="border: 1px solid;">
                    <asp:Label ID="nameLabelOtherUser" runat="server" Text="Nombre" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <div class="row text-center">
                        <div class="col">
                            <h5>Horas<br />ganadas</h5>
                            <asp:Label ID="earnedHoursLabelOtherUser" runat="server" Text="0" Font-Bold="True" Font-Size="Larger"></asp:Label>
                        </div>
                        <div class="col">
                            <h5>Horas<br />gastadas</h5>
                            <asp:Label ID="spentHoursLablelOtherUser" runat="server" Text="0" Font-Bold="True" Font-Size="Large"></asp:Label>
                        </div>
                        <div class="col">
                            <h5>Saldo<br />personal</h5>
                            <asp:Label ID="balanceLabelOtherUser" runat="server" Text="0" Font-Bold="True" Font-Size="Large"></asp:Label>
                        </div>
                        <div class="col">
                            <h5>Servicios realizados</h5>
                            <asp:Label ID="performedServicesLablelOtherUser" runat="server" Text="0" Font-Bold="True" Font-Size="Large"></asp:Label>
                        </div>
                        <div class="col">
                            <h5>Servicios recibidos</h5>
                            <asp:Label ID="recievedServicesLablelOtherUser" runat="server" Text="0" Font-Bold="True" Font-Size="Large"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <div id="vesselOtherProfile" runat="server"></div>

        </div>
        <div class="col-lg-2"></div>
    </div>

    <!-- Modal Close Service -->
    <div class="modal fade" id="modalCloseService" tabindex="-1" aria-labelledby="modalCloseServiceLabel" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered modal-lg">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="modalCloseServiceLabel">Nombre del interesado</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-9">
                            <asp:Label CssClass="lab" for="mailCloseService" runat="server">Introduce el correo del contacto con el que has realizado el servicio</asp:Label>
                            <asp:TextBox CssClass="form-control" TextMode="Email" ID="mailCloseService" placeholder="correo@correo.com" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-3 align-middle">
                            <asp:Button CssClass="btn btn-primary btnForm" Text="Confirmar" runat="server" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
