<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Historial.aspx.cs" Inherits="TimeSwap.Historial" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row colorVesselContainer">
        <div class="col-lg-2 col-md-1 col-sm-1"></div>
        <div class="col-lg-8 col-md-10 col-sm-10 colorVesselCol">

            <h4>Finalizados</h4>
            <div id="vesselReservedServices" runat="server"></div>
            <!--<div class="row colorVesselTemplates">
                <div class="col-lg-2 align-self-center">
                    <img src="./Content/placeholder.svg" class="imgUserAdvert" />
                    <h3 style="text-align:center;">Horas servicio</h3>
                </div>
                <div class="col-lg-8">
                    <h3>Modal perfil Personal</h3>
                    <p>Descripción</p>
                </div>
                <div class="col-lg-2 recordAlign align-self-center">
                    <div id="btnEndService" data-toggle="modal" data-target="#modalCloseService">Finalizar servicio</div>
                </div>
            </div>-->

            <!--<div class="row colorVesselTemplates">
                <div class="col-lg-2 align-self-center">
                    <img src="./Content/placeholder.svg" class="imgUserAdvert" />
                    <h3 style="text-align:center;">Horas servicio</h3>
                </div>
                <div class="col-lg-8">
                    <h3>Modal perfil Otros Usuarios</h3>
                    <p>Descripción</p>
                </div>
                <div class="col-lg-2 recordAlign align-self-center">
                    <div id="btnConnect" data-toggle="modal" data-target="#modalPhone">Estoy interesado</div>
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
                        <div class="col-lg-3 align-middle">
                            <asp:Button CssClass="btn btn-primary btnForm" Text="Confirmar" runat="server" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>



</asp:Content>
