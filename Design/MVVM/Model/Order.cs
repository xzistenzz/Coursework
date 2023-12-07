using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.MVVM.Model
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int VendorId { get; set; }
        [ForeignKey(nameof(VendorId))]
        public virtual Vendor Vendor { get; set; }
        public List<OrderItem> Items { get; set; }
        [Required]
        public double Cost { get; set; }
    }
}
