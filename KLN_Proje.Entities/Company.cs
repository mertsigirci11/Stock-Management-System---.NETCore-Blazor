using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLN_Proje.Entities
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [Required]
        public string Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required]
        public string Phone { get; set; }

        [Required]
        public string TaxNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string EMail { get; set; }

        [Required]
        public string Address { get; set; }

        [MinLength(7, ErrorMessage = "Username should be minimum 7 characters")]
        [MaxLength(15, ErrorMessage = "Username should be maximum 15 characters")]
        [Required]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [MinLength(7, ErrorMessage = "Password should be minimum 7 characters")]
        [MaxLength(15, ErrorMessage = "Password should be maximum 15 characters")]
        public string Password { get; set; }

        public ICollection<Warehouse> Warehouses { get; set; }
    }
}
