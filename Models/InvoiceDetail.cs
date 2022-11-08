using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstDemo.Models
{
    //Detalle de Factura
    public class InvoiceDetail
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string subTitle { get; set; }
        public string datetime { get; set; }
        public string type { get; set; }
        public string description { get; set; }
        public string amount { get; set; }

    }
}