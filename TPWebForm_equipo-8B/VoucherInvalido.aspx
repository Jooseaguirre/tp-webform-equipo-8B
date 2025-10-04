<%@ Page Title="Promo Ganá | Voucher Inválido" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="VoucherInvalido.aspx.cs" Inherits="TPWebForm_equipo_8B.VoucherInvalido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="text-center mt-5">
        <h3 class="text-danger">
            <asp:Label ID="lblMotivo" runat="server" />
        </h3>
        <asp:Button ID="btnVolver" runat="server" Text="Volver al inicio" CssClass="btn btn-secondary mt-4" OnClick="btnVolver_Click" />
    </div>
</asp:Content>
