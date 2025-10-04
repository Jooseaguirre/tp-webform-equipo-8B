using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> ListarPorArticulo(int idArticulo)
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Id, IdArticulo, ImagenUrl FROM Imagenes WHERE IdArticulo = @IdArticulo");
                datos.setearParametro("@IdArticulo", idArticulo);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen img = new Imagen();
                    img.Id = (int)datos.Lector["Id"];
                    img.IdArticulo = (int)datos.Lector["IdArticulo"];
                    img.UrlImagen = datos.Lector["ImagenUrl"].ToString();
                    lista.Add(img);
                }

                return lista;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


       

        //Listar las imagenes del articulo dentro de la misma tarjeta
        public List<ArticuloConImagenes> ListarAgrupado()
        {
            List<ArticuloConImagenes> agrupados = new List<ArticuloConImagenes>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT IdArticulo, ImagenUrl FROM Imagenes ORDER BY IdArticulo");
                datos.ejecutarLectura();

                Dictionary<int, ArticuloConImagenes> mapa = new Dictionary<int, ArticuloConImagenes>();

                while (datos.Lector.Read())
                {
                    int id = (int)datos.Lector["IdArticulo"];
                    string url = datos.Lector["ImagenUrl"].ToString();

                    if (!mapa.ContainsKey(id))
                        mapa[id] = new ArticuloConImagenes { IdArticulo = id, UrlsImagenes = new List<string>() };

                    mapa[id].UrlsImagenes.Add(url);
                }

                agrupados = mapa.Values.ToList();
                return agrupados;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


    }
}
