<%@ Page Title="Promo Ganá! | Registro Exitoso" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="RegistroExitoso.aspx.cs" Inherits="TPWebForm_equipo_8B.RegistroExitoso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="d-flex justify-content-center align-items-center" style="min-height: 80vh; padding-top: 21px;">
        <div class="bg-white p-5 rounded-4 shadow text-center animate__animated animate__fadeIn" style="max-width: 500px;">
            <h2 class="text-success fw-bold mb-3">🎉 ¡Registro exitoso!</h2>
            <p class="text-secondary mb-4">Gracias por registrarte en <strong>Promo Ganá!</strong><br />Tu participación ha sido confirmada.</p>
            <p class="text-muted">Pronto recibirás novedades sobre los premios y sorteos.<br />¡Mucha suerte!</p>
            <p class="text-muted">📧 Te hemos enviado un correo de confirmación a la dirección que ingresaste.</p>

            <asp:Button ID="btnVolver" runat="server" Text="⬅ Volver al inicio" CssClass="btn btn-outline-success mt-4" PostBackUrl="~/Inicio.aspx" />
        </div>
    </div>
</asp:Content>
