<%@ Page Title="Promo Ganá! | Registro" Language="C#" MasterPageFile="~/MiMaster.Master"
    AutoEventWireup="true" CodeBehind="RegistroCliente.aspx.cs"
    Inherits="TPWebForm_equipo_8B.Registro" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="needs-validation d-flex justify-content-center align-items-center" style="min-height: 80vh; padding-top: 54px; padding-bottom: 30px;" ">
        <div class="bg-light p-5 rounded-4 shadow w-100" style="max-width: 500px;">
            <h3 class="text-center text-success fw-bold mb-4">Paso 3: Regístrate para participar</h3>

            <div class="mb-3">
                <asp:Label ID="lblDNI" runat="server" AssociatedControlID="txtDNI" Text="DNI:" CssClass="form-label fw-semibold" />
                <asp:TextBox ID="txtDNI" runat="server" CssClass="form-control" placeholder="Ej: 40123456" />
                <asp:Label ID="lblErrorDNI" runat="server" CssClass="invalid-feedback"></asp:Label>
            </div>

            <div class="mb-3">
                <asp:Label ID="lblNombre" runat="server" AssociatedControlID="txtNombre" Text="Nombre:" CssClass="form-label fw-semibold" />
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" />
                <asp:Label ID="lblErrorNombre" runat="server" CssClass="invalid-feedback"></asp:Label>
            </div>

            <div class="mb-3">
                <asp:Label ID="lblApellido" runat="server" AssociatedControlID="txtApellido" Text="Apellido:" CssClass="form-label fw-semibold" />
                <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" />
                <asp:Label ID="lblErrorApellido" runat="server" CssClass="invalid-feedback"></asp:Label>
            </div>

            <div class="mb-3">
                <asp:Label ID="lblEmail" runat="server" AssociatedControlID="txtEmail" Text="Email:" CssClass="form-label fw-semibold" />
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email" placeholder="ejemplo@mail.com" />
                <div class="invalid-feedback">Ingresá un email válido.</div>
            </div>

            <div class="mb-3">
                <asp:Label ID="lblTelefono" runat="server" AssociatedControlID="txtTelefono" Text="Teléfono:" CssClass="form-label fw-semibold" />
                <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" placeholder="Ej: 1123456789" />
                <asp:Label ID="lblErrorTelefono" runat="server" CssClass="invalid-feedback"></asp:Label>    
            </div>

            <div class="mb-3">
                <asp:Label ID="lblDireccion" runat="server" AssociatedControlID="txtDireccion" Text="Dirección:" CssClass="form-label fw-semibold" />
                <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" />
                <div class="invalid-feedback">Este campo es obligatorio.</div>
            </div>

            <div class="mb-3">
                <asp:Label ID="lblCiudad" runat="server" AssociatedControlID="txtCiudad" Text="Ciudad:" CssClass="form-label fw-semibold" />
                <asp:TextBox ID="txtCiudad" runat="server" CssClass="form-control" />
                <asp:Label ID="lblErrorCiudad" runat="server" CssClass="invalid-feedback"></asp:Label>
            </div>

            <div class="mb-3">
                <asp:Label ID="lblCP" runat="server" AssociatedControlID="txtCP" Text="Código Postal:" CssClass="form-label fw-semibold" />
                <asp:TextBox ID="txtCP" runat="server" CssClass="form-control" />
                <div class="invalid-feedback">Este campo es obligatorio.</div>
            </div>

            <div class="form-check mb-3">
                <asp:CheckBox 
                    ID="chkTerminos" 
                    runat="server" 
                    Text="Acepto los términos y condiciones"/>
            </div>

            <div class="d-grid mt-4">
                <asp:Button ID="btnParticipar" runat="server" Text="🎉 ¡Participar!" CssClass="btn btn-success btn-lg" OnClick="btnParticipar_Click" />
            </div>

            <asp:Label ID="lblMensaje" runat="server" CssClass="text-success d-block mt-3 text-center" />
        </div>
        </div>
</asp:Content>
