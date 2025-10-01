<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true"
    CodeBehind="SeleccionPremio.aspx.cs" Inherits="TPWebForm_equipo_8B.SeleccionPremio" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <asp:Repeater ID="rptPremios" runat="server">
            <ItemTemplate>
                <div class="col-md-4 mb-4 d-flex">
                    <div class="card h-100 shadow-sm w-100">
                        <img src='<%# Eval("ImagenUrl") %>' class="card-img-top" alt="Premio">
                        <div class="card-body d-flex flex-column text-center">
                            <h5 class="card-title"><%# Eval("Nombre") %></h5>
                            <p class="card-text text-muted"><%# Eval("Descripcion") %></p>
                            <asp:Button runat="server" Text="Elegir"
                                CommandArgument='<%# Eval("Id") %>'
                                OnClick="btnElegir_Click"
                                CssClass="btn btn-primary mt-auto" />
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

   
    <asp:Label ID="Label1" runat="server" CssClass="d-block mt-3"></asp:Label>

    <%--
     <div class="modal fade" id="modalMensaje" ClientIDMode="Static" tabindex="-1" aria-hidden="true">
      <div class="modal-dialog modal-dialog-centered">
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title">Resultado</h5>
            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Cerrar"></button>
          </div>
          <div class="modal-body" id="modalMensajeBody"></div>
          <div class="modal-footer">
            <button type="button" class="btn btn-primary" data-bs-dismiss="modal">Ok</button>
          </div>
        </div>
      </div>
    </div>

    <asp:Label ID="lblMensaje" runat="server" CssClass="text-success mt-3 d-block"></asp:Label>
         --%>
</asp:Content>


