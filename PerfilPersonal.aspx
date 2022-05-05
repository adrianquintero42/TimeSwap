<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PerfilPersonal.aspx.cs" Inherits="TimeSwap.PerfilPersonal" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row" style="margin-top: 2rem;">
        <div class="col-lg-2"></div>
        <div class="col-lg-8 colorVesselCol">

            <div class="row colorVesselTemplates" id="userInfoProfile" style="border: 1px solid;">
                <div class="col-lg-3" style="border: 1px solid;">
                    <asp:Image ID="userImage" runat="server" CssClass="imgUserAdvert" />
                </div>
                <div class="col-lg-9" style="border: 1px solid; padding-top: 1rem;">
                    <div class="row">

                        <div class="col-lg-6">
                            <asp:Label ID="nameLabel" runat="server" Text="Nombre" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
                        </div>

                        <div class="col-lg-6 recordAlign align-self-center" style="margin-bottom: 1rem;">
                            <div id="btnEndService" data-toggle="modal" data-target="#modalCloseService">Finalizar servicio</div>
                        </div>

                    </div>
                    <!--<br />
                    <br />
                    <br />-->
                    <div class="row text-center">
                        <div class="col">
                            <h5>Horas<br />
                                ganadas</h5>
                            <asp:Label ID="earnedHoursLabel" runat="server" Text="0" Font-Bold="True" Font-Size="Larger"></asp:Label>
                        </div>
                        <div class="col">
                            <h5>Horas<br />
                                gastadas</h5>
                            <asp:Label ID="spentHoursLablel" runat="server" Text="0" Font-Bold="True" Font-Size="Large"></asp:Label>
                        </div>
                        <div class="col">
                            <h5>Saldo<br />
                                personal</h5>
                            <asp:Label ID="balanceLabel" runat="server" Text="0" Font-Bold="True" Font-Size="Large"></asp:Label>
                        </div>
                        <div class="col">
                            <h5>Servicios realizados</h5>
                            <asp:Label ID="performedServicesLablel" runat="server" Text="0" Font-Bold="True" Font-Size="Large"></asp:Label>
                        </div>
                        <div class="col">
                            <h5>Servicios recibidos</h5>
                            <asp:Label ID="recievedServicesLablel" runat="server" Text="0" Font-Bold="True" Font-Size="Large"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <div id="vesselUserProfile" runat="server"></div>
            <!--<div class="row userAdvertsPublished">
                <div class="col-lg-3">
                    <h1>1h</h1>
                    <asp:Button CssClass="btn btn-secondary" Text="Estoy interesado" runat="server" />
                </div>
                <div class="col-lg-9">
                    <h3>Lorem Ipsum is simply dummy text of the printing</h3>
                    <p>
                        Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, 
                        when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, 
                        but also the leap into electronic typesetting, remaining essentially unchanged. 
                        It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, 
                        and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.type specimen book. 
                        It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. 
                        It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, 
                        and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
                    </p>
                </div>
            </div>-->

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
                        <div class="col-lg-9">
                            <asp:Label CssClass="lab" for="serviceIDTextBox" runat="server">Introduce el identificador del servicio</asp:Label>
                            <asp:TextBox CssClass="form-control" TextMode="SingleLine" ID="serviceIDTextBox" placeholder="3" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-3 align-middle">
                            <asp:Button CssClass="btn btn-primary btnForm" Text="Confirmar" runat="server" OnClick="ConfirmUser_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
