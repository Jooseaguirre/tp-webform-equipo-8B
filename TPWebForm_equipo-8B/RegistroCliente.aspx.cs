using Dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
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
            //HACER VALIDACIONES DE LOS CAMPOS DEL FORMULARIO DE REGISTRO!!!






            //Una vez validado todos los campos del Formulario de Registro, te redirecciona a la pagina de Registro Exitoso
            Response.Redirect("RegistroExitoso.aspx?");


        }










    }
}