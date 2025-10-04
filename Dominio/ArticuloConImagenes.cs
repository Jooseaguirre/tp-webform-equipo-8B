using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   

    public class ArticuloConImagenes
    {
        public int IdArticulo { get; set; }
        public List<string> UrlsImagenes { get; set; }
    }

}
