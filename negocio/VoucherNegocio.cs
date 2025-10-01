using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using negocio;

namespace negocio
{
    public class VoucherNegocio
    {
        public Voucher BuscarPorCodigo(string codigo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT CodigoVoucher, IdCliente, FechaCanje, IdArticulo FROM Vouchers WHERE CodigoVoucher = @Codigo");
                datos.setearParametro("@Codigo", codigo);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    Voucher v = new Voucher();               
                    v.CodigoVoucher = datos.Lector["CodigoVoucher"].ToString();
                    v.IdCliente = datos.Lector["IdCliente"] == DBNull.Value ? (int?)null : (int)datos.Lector["IdCliente"];
                    v.FechaCanje = datos.Lector["FechaCanje"] == DBNull.Value ? (DateTime?)null : (DateTime)datos.Lector["FechaCanje"];
                    v.IdArticulo = datos.Lector["IdArticulo"] == DBNull.Value ? (int?)null : (int)datos.Lector["IdArticulo"];
                    return v;
                }

                return null;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void AsociarArticulo(string codigoVoucher, int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE Vouchers SET IdArticulo = @IdArticulo WHERE CodigoVoucher = @Codigo");
                datos.setearParametro("@IdArticulo", idArticulo);
                datos.setearParametro("@Codigo", codigoVoucher);
                datos.ejecutarAccion();
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void AsociarCliente(string CodigoVoucher, int clienteId)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE Vouchers SET IdCliente = @IdCliente, FechaCanje = GETDATE() WHERE CodigoVoucher = @Codigo");
                datos.setearParametro("@IdCliente", clienteId);
                datos.setearParametro("@Codigo", CodigoVoucher);
                datos.ejecutarAccion();
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}

