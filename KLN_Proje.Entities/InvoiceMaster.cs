using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLN_Proje.Entities
{
    public class InvoiceMaster
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string CustomerName { get; set; }

        [Required]
        public string CustomerTaxAdministration { get; set; }

        [Required]
        public string CustomerBankAccountNumber { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }

        [DataType(DataType.Text)]
        public string StringPrice { get; set; }

        public decimal Price { get; set; }

        public decimal VAT { get; set; }

        public decimal TotalPrice { get; set; }



        public ICollection<InvoiceDetail> InvoiceDetails { get; set; }

        public int OfficeId { get; set; }

        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        [ForeignKey("OfficeId")]
        public Office Office { get; set; }
    }
}
