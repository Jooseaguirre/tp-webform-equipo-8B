using Dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPWebForm_equipo_8B
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }




        protected void btnParticipar_Click(object sender, EventArgs e)
        {
            //VALIDACIONES DE LOS CAMPOS DEL FORMULARIO DE REGISTRO!!!
            bool valido = true;
            LimpiarValidacion();

            // DNI
            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MarcarError(txtDNI);
                lblErrorDNI.Text = "El DNI es obligatorio.";
                valido = false;
            }
            else if (!Regex.IsMatch(txtDNI.Text, @"^\d{7,8}$"))
            {
                MarcarError(txtDNI);
                lblErrorDNI.Text = "El DNI debe tener 7 u 8 dígitos.";
                valido = false;
            }
            else
            {
                MarcarOk(txtDNI);
                lblErrorDNI.Text = "";
            }


            // Nombre

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MarcarError(txtNombre);
                lblErrorNombre.Text = "El nombre es obligatorio.";
            }
            else if (!Regex.IsMatch(txtNombre.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ]+(\s[a-zA-ZáéíóúÁÉÍÓÚñÑ]+)*$"))
            {
                MarcarError(txtNombre);
                lblErrorNombre.Text = "El nombre solo puede contener letras y espacios.";
            }
            else
            {
                MarcarOk(txtNombre);
                lblErrorNombre.Text = "";
            }


            // Apellido
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MarcarError(txtApellido);
                lblErrorApellido.Text = "El apellido es obligatorio.";
            }
            else if (!Regex.IsMatch(txtApellido.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ]+(\s[a-zA-ZáéíóúÁÉÍÓÚñÑ]+)*$"))
            {
                MarcarError(txtApellido);
                lblErrorApellido.Text = "El apellido solo puede contener letras y espacios.";
            }
            else
            {
                MarcarOk(txtApellido);
                lblErrorApellido.Text = "";
            }

            // Email
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                !Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MarcarError(txtEmail);
                valido = false;
            }
            else
                MarcarOk(txtEmail);

            // Teléfono
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MarcarError(txtTelefono);
                lblErrorTelefono.Text = "El teléfono es obligatorio.";
                valido = false;
            }
            else if (!Regex.IsMatch(txtTelefono.Text, @"^\d{8,15}$"))
            {
                MarcarError(txtTelefono);
                lblErrorTelefono.Text = "El teléfono debe tener entre 8 y 15 dígitos.";
                valido = false;
            }
            else
            {
                MarcarOk(txtTelefono);
                lblErrorTelefono.Text = "";
            }

            // Dirección
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MarcarError(txtDireccion);
                valido = false;
            }
            else
                MarcarOk(txtDireccion);

            // Ciudad
            if (string.IsNullOrWhiteSpace(txtCiudad.Text))
            {
                MarcarError(txtCiudad);
                lblErrorCiudad.Text = "La ciudad es obligatoria.";
                valido = false;
            }
            else if (!Regex.IsMatch(txtCiudad.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ]+(\s[a-zA-ZáéíóúÁÉÍÓÚñÑ]+)*$"))
            {
                MarcarError(txtCiudad);
                lblErrorCiudad.Text = "La ciudad solo puede contener letras y espacios.";
                valido = false;
            }
            else
            {
                MarcarOk(txtCiudad);
                lblErrorCiudad.Text = "";
            }

            // Código Postal
            if (string.IsNullOrWhiteSpace(txtCP.Text) || !Regex.IsMatch(txtCP.Text, @"^([A-Za-z]\d{4}[A-Za-z]{0,3}|\d{4,5})$"))
            {
                MarcarError(txtCP);
                valido = false;
            }
            else
                MarcarOk(txtCP);

            // Checkbox de términos
            if (!chkTerminos.Checked)
            {
                lblMensaje.CssClass = "text-danger d-block mt-3 text-center";
                lblMensaje.Text = "Debés aceptar los términos y condiciones.";
                valido = false;
            }

            // Si hay cualquier otro error, mostrar mensaje general
            if (!valido && chkTerminos.Checked)
            {
                lblMensaje.CssClass = "text-danger d-block mt-3 text-center";
                lblMensaje.Text = "Por favor, corregí los campos en rojo.";
                return;
            }

            // Si todo ok
            if (valido)
            {
                lblMensaje.CssClass = "text-success d-block mt-3 text-center";
                lblMensaje.Text = "Formulario validado correctamente";
                Response.Redirect("RegistroExitoso.aspx");
            }

        }

        private void MarcarError(System.Web.UI.WebControls.TextBox txt)
        {
            txt.CssClass = "form-control is-invalid";
        }

        private void MarcarOk(System.Web.UI.WebControls.TextBox txt)
        {
            txt.CssClass = "form-control is-valid";
        }

        private void LimpiarValidacion()
        {
            txtDNI.CssClass = "form-control";
            txtNombre.CssClass = "form-control";
            txtApellido.CssClass = "form-control";
            txtEmail.CssClass = "form-control";
            txtTelefono.CssClass = "form-control";
            txtDireccion.CssClass = "form-control";
            txtCiudad.CssClass = "form-control";
            txtCP.CssClass = "form-control";
        }


    }
}