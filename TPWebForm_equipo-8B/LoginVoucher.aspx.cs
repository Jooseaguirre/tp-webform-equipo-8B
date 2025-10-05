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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            string codigoVoucher = txtVoucher.Text.Trim();
            VoucherNegocio voucherNegocio = new VoucherNegocio();

            try
            {
                Voucher v = voucherNegocio.BuscarPorCodigo(codigoVoucher);

                if (v == null)
                {
                    // No existe el voucher
                    Response.Redirect("VoucherInvalido.aspx?motivo=inexistente");
                }
                else if (v.IdCliente != null || v.FechaCanje != null || v.IdArticulo != null)
                {
                    // Ya fue canjeado
                    Response.Redirect("VoucherInvalido.aspx?motivo=usado");
                }
                else
                {
                    // Voucher válido y no canjeado
                    Session["Voucher"] = codigoVoucher;
                    Response.Redirect("ElegirPremio.aspx?codigo=" + codigoVoucher);
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Ocurrió un error: " + ex.Message;
                lblMensaje.CssClass = "text-danger d-block mt-3";
            }
        }


    }
}
