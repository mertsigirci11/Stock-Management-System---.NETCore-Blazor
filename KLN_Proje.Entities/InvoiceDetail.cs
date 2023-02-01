using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLN_Proje.Entities
{
    public class InvoiceDetail
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public int Pieces { get; set; }

        public int Price { get; set; }

        public int Amount { get; set; }

        public int InvoiceMasterId { get; set; }

        [ForeignKey("InvoiceMasterId")]
        public InvoiceMaster InvoiceMaster { get; set; }
    }
}
