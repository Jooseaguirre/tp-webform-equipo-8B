<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TPWebForm_equipo_8B.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <h3 class="text-center mb-4">Ingresar Voucher</h3>

        <div class="mb-3">
            <asp:Label ID="lblVoucher" runat="server" Text="Código de voucher:" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtVoucher" runat="server" CssClass="form-control" placeholder="Ej: ABC123XYZ"></asp:TextBox>
        </div>

        <div class="d-grid">
            <asp:Button ID="btnValidar" runat="server" Text="Validar voucher" CssClass="btn btn-primary" OnClick="btnValidar_Click" />
        </div>

        <asp:Label ID="lblMensaje" runat="server" CssClass="text-danger d-block mt-3"></asp:Label>

    </div>


</asp:Content>
