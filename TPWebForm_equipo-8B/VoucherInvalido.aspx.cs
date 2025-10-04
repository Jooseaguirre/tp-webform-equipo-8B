using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPWebForm_equipo_8B
{
    public partial class VoucherInvalido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string motivo = Request.QueryString["motivo"];
                if (motivo == "inexistente")
                    lblMotivo.Text = "El código ingresado no es válido ❌";
                else if (motivo == "usado")
                    lblMotivo.Text = "Este voucher ya fue canjeado";
                else
                    lblMotivo.Text = "Error desconocido al validar el voucher.";
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }

    }
}