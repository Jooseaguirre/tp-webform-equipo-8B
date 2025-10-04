<%@ Page Title="Promo Ganá! | Inicio" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="TPWebForm_equipo_8B.Inicio" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="inicio text-center">
        <div class="inicio-bg w-100" style="max-width: 500px;">
            <h1 class="titulo-inicio mb-4">🎁 Bienvenido a Promo Ganá!</h1>
            <p class="mb-4 text-secondary">Ingresá tu código de voucher y elegí tu premio favorito.</p>
            <asp:Button ID="btnCanjear" runat="server" Text="🎫 Canjear voucher" CssClass="btn btn-primary btn-lg btn-canjear w-100" OnClick="btnCanjear_Click" />
        </div>
    </div>
</asp:Content>
