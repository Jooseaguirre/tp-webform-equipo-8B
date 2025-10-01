using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio
{
    public class Voucher
    {

        
        public string CodigoVoucher { get; set; }
        public int? IdCliente { get; set; }   // puede ser null si no fue usado
        public DateTime? FechaCanje { get; set; }
        public int? IdArticulo { get; set; }  // premio elegido
    }
}