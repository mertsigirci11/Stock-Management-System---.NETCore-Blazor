using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLN_Proje.Entities
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [MaxLength(25, ErrorMessage = "Customer name should be maximum 25 characters")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [MaxLength(25, ErrorMessage = "Customer surname should be maximum 25 characters")]
        public string Surname { get; set; }

        public ICollection<InvoiceMaster> InvoiceMasters { get; set; }

        [MinLength(7, ErrorMessage = "Username should be minimum 7 characters")]
        [MaxLength(15, ErrorMessage = "Username should be maximum 15 characters")]
        [Required]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [MinLength(7, ErrorMessage = "Password should be minimum 7 characters")]
        [MaxLength(15, ErrorMessage = "Password should be maximum 15 characters")]
        public string Password { get; set; }

        public string TaxAdministration { get; set; }
        public string BankAccountNumber { get; set; }
    }
}
