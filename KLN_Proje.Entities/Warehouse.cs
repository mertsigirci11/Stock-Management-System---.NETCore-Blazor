using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLN_Proje.Entities
{
    public class Warehouse
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [MinLength(7, ErrorMessage = "Warehouse name should be minimum 7 characters")]
        [MaxLength(15, ErrorMessage = "Warehouse name should be maximum 15 characters")]
        public string Name { get; set; }

        [Required]
        public int CompanyId { get; set; }

        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

        public ICollection<Stock> Stocks { get; set; }
    }
}
