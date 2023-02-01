using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLN_Proje.Entities
{
    public class Office
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "Office name should be maximum 15 characters")]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int CompanyId { get; set; }

        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

        public ICollection<InvoiceMaster> InvoiceMasters { get; set; }
    }
}
