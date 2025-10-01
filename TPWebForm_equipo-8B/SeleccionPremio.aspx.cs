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
    public partial class SeleccionPremio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                cargarPremios();
        }

        private void cargarPremios()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ImagenNegocio ineg = new ImagenNegocio();

            List<Articulo> lista = negocio.Listar();

            List<dynamic> premios = new List<dynamic>();
            foreach (Articulo art in lista)
            {
                var imagenes = ineg.ListarPorArticulo(art.Id);

                foreach (Imagen img in imagenes)
                {
                    premios.Add(new
                    {
                        Id = art.Id,
                        Nombre = art.Nombre,
                        Descripcion = art.Descripcion,
                        ImagenUrl = img.UrlImagen
                    });
                }
            }

            rptPremios.DataSource = premios;
            rptPremios.DataBind();
        }

        
    }
}