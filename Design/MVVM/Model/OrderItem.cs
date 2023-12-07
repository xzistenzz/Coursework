using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.MVVM.Model
{
    [Table("OrderItems")]
    public class OrderItem
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
