<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="paginaPrincipal.aspx.cs" Inherits="TimeSwap.paginaPrincipal" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row colorVesselContainer">
        <div class="col-lg-2 col-md-1 col-sm-1"></div>
        <div class="col-lg-8 col-md-10 col-sm-10 colorVesselCol" id="vesselTemplate" runat="server">


            <!--<div class="row colorVesselTemplates">
                <div class="col-lg-3 alignTextContainer">
                    <img src="./Content/webcam.png" class="imgUserAdvert" />
                    <p>Nombre Apellidos</p>
                    <p>Valoración de otros usuarios 1.2</p>
                    <p>Votos: 412</p>
                    <asp:Button CssClass="btn btn-secondary" Text="Estoy interesado" runat="server" />
                </div>
                <div class="col-lg-8 noticeText">
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
                <div class="col-lg-1 align-self-center" >
                    <h1>1h</h1>
                </div>
            </div>-->

        </div>
        <div class="col-lg-2 col-md-1 col-sm-1"></div>
    </div>

        <!-- Modal Phone -->
    <div class="modal fade" id="modalPhone" tabindex="-1" aria-labelledby="modalPhoneLabel" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered modal-lg">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="modalPhoneLabel">Nombre del interesado</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <div class="row" style="text-align: center;">
                        <div class="col-lg-12">
                            <h2 class="col-lg-12">Numero de teléfono</h2>
                            <h2 class="col-lg-12"></h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
