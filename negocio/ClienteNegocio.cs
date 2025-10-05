using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
    

namespace negocio
{
    public class ClienteNegocio
    {
        public Cliente BuscarPorDocumento(string documento)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Id, Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP FROM Clientes WHERE Documento = @Documento");
                datos.setearParametro("@Documento", documento);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    Cliente cli = new Cliente();
                    cli.Id = (int)datos.Lector["Id"];
                    cli.Documento = datos.Lector["Documento"].ToString();
                    cli.Nombre = datos.Lector["Nombre"].ToString();
                    cli.Apellido = datos.Lector["Apellido"].ToString();
                    cli.Email = datos.Lector["Email"].ToString();
                    cli.Direccion = datos.Lector["Direccion"].ToString();
                    cli.Ciudad = datos.Lector["Ciudad"].ToString();
                    cli.CP = (int)datos.Lector["CP"];
                    return cli;
                }

                return null;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public int Insertar(Cliente cli)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(@"INSERT INTO Clientes (Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP) 
                                       OUTPUT INSERTED.Id
                                       VALUES (@Documento, @Nombre, @Apellido, @Email, @Direccion, @Ciudad, @CP)");
                datos.setearParametro("@Documento", cli.Documento);
                datos.setearParametro("@Nombre", cli.Nombre);
                datos.setearParametro("@Apellido", cli.Apellido);
                datos.setearParametro("@Email", cli.Email);
                datos.setearParametro("@Direccion", cli.Direccion);
                datos.setearParametro("@Ciudad", cli.Ciudad);
                datos.setearParametro("@CP", cli.CP);

                return datos.ejecutarAccionConId();
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}