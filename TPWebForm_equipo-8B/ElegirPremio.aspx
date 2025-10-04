<%@ Page Title="Promo Ganá! | Elegí tu Premio" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="ElegirPremio.aspx.cs" Inherits="TPWebForm_equipo_8B.ElegirPremio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



<div class="container mt-4">

    <h2 class="text-center mb-4">Paso 2: Elegí tu premio</h2>
    <div class="row justify-content-center">
        <asp:Repeater ID="rptArticulos" runat="server">
            <ItemTemplate>
                <div class="col-lg-3 col-md-4 col-sm-6 mb-4 d-flex">
                    <div class="card shadow-sm flex-fill" style="max-width: 100%; min-height: 360px;">
                        <div class="card-body d-flex flex-column justify-content-between" style="min-height: 280px;">
                            <div id='carousel<%# Eval("IdArticulo") %>' class='carousel slide' data-bs-ride='carousel'>
                                <div class='carousel-inner'>
                                    <asp:Repeater ID="rptImagenes" runat="server" DataSource='<%# Eval("UrlsImagenes") %>'>
                                        <ItemTemplate>
                                            <div class='carousel-item <%# Container.ItemIndex == 0 ? "active" : "" %>'>
                                                <div class="d-flex justify-content-center align-items-center" style="height: 220px;">
                                                    <img src='<%# Container.DataItem %>' class='rounded object-fit-contain' style="max-height: 100%; max-width: 100%;" alt='Imagen del artículo' />
                                                </div>
                                            </div>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </div>
                                <button class='carousel-control-prev' type='button' data-bs-target='#carousel<%# Eval("IdArticulo") %>' data-bs-slide='prev'>
                                    <span class='carousel-control-prev-icon'></span>
                                </button>
                                <button class='carousel-control-next' type='button' data-bs-target='#carousel<%# Eval("IdArticulo") %>' data-bs-slide='next'>
                                    <span class='carousel-control-next-icon'></span>
                                </button>
                            </div>
                            <asp:Button ID="btnElegir" runat="server" Text="¡Quiero este!" CssClass="btn btn-primary mt-auto w-100" CommandArgument='<%# Eval("IdArticulo") %>' OnClick="btnElegir_Click" />
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

</div>



   





   







</asp:Content>


