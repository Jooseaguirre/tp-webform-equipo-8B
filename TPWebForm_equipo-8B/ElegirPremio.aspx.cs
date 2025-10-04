using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using negocio;

namespace TPWebForm_equipo_8B
{
    public partial class ElegirPremio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ImagenNegocio negocio = new ImagenNegocio();
                List<ArticuloConImagenes> articulos = negocio.ListarAgrupado();
                rptArticulos.DataSource = articulos;
                rptArticulos.DataBind();
            }
        }



        protected void btnElegir_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string id = btn.CommandArgument;
            Response.Redirect("RegistroCliente.aspx?premio=" + id);
        }


    }
}