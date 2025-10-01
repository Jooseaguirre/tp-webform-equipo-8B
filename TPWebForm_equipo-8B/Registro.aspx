<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master"
    AutoEventWireup="true" CodeBehind="Registro.aspx.cs"
    Inherits="TPWebForm_equipo_8B.Registro" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <h3 class="text-center mb-4">Paso 2: Registrate para participar</h3>

        <div class="mb-3">
            <asp:Label ID="lblDNI" runat="server" Text="DNI:" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtDNI" runat="server" CssClass="form-control" placeholder="Ej: 40123456"></asp:TextBox>
        </div>

        <div class="mb-3">
            <asp:Label ID="lblNombre" runat="server" Text="Nombre:" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="mb-3">
            <asp:Label ID="lblApellido" runat="server" Text="Apellido:" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="mb-3">
            <asp:Label ID="lblEmail" runat="server" Text="Email:" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email" placeholder="ejemplo@mail.com"></asp:TextBox>
        </div>

        <div class="mb-3">
            <asp:Label ID="lblTelefono" runat="server" Text="Teléfono:" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" placeholder="Ej: 1123456789"></asp:TextBox>
        </div>

        <div class="mb-3">
            <asp:Label ID="lblDireccion" runat="server" Text="Dirección:" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="mb-3">
            <asp:Label ID="lblCiudad" runat="server" Text="Ciudad:" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtCiudad" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="mb-3">
            <asp:Label ID="lblCP" runat="server" Text="Código Postal:" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtCP" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="d-grid">
            <asp:Button ID="btnParticipar" runat="server" Text="¡Participar!" CssClass="btn btn-success" OnClick="btnParticipar_Click" />
        </div>

        <asp:Label ID="lblMensaje" runat="server" CssClass="text-success d-block mt-3"></asp:Label>
    </div>

</asp:Content>
