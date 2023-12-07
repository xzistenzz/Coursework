using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.MVVM.Model
{
    [Table("Vendors")]
    public class Vendor
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string VendorName { get; set; }
        [Required]
        public double Salary { get; set; }
        [Required]
        public int WorkingHours { get; set; }
    }
}
