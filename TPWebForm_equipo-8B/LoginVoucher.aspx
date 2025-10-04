<%@ Page Title="Promo Ganá! | Ingreso Voucher" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="LoginVoucher.aspx.cs" Inherits="TPWebForm_equipo_8B.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="d-flex justify-content-center align-items-center" style="min-height: 70vh;">
        <div class="bg-light p-5 rounded-4 shadow w-100" style="max-width: 400px;">
            <h3 class="text-center text-primary mb-4">Paso 1: Ingresar Voucher</h3>

            <div class="mb-3">
                <asp:Label ID="lblVoucher" runat="server" Text="Código de voucher:" CssClass="form-label fw-semibold"></asp:Label>
                <asp:TextBox ID="txtVoucher" runat="server" CssClass="form-control text-center" placeholder="Ej: ABC123XYZ" />
            </div>

            <div class="d-grid">
                <asp:Button ID="btnValidar" runat="server" Text="🎫 Validar voucher" CssClass="btn btn-primary btn-sm" OnClick="btnValidar_Click" />
            </div>

            <asp:Label ID="lblMensaje" runat="server" CssClass="text-danger d-block mt-3 text-center"></asp:Label>
        </div>
    </div>
</asp:Content>

