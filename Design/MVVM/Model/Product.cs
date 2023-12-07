using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.MVVM.Model
{
    [Table("Products")]
    public class Product
    {
        [Key]
        [Required]
        [Column("Id")]
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public double Cost { get; set; }
        [Required]
        public string CostUnit { get; set; }
        [Required]
        public string Unit { get; set; }
        [Required]
        public double Leftover { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public override string ToString()
            => $"Идентификатор продукта: [{Id}]\nНазвание продукта: {ProductName}\nЦена за килограмм: {Cost}{CostUnit}\nОстаток на складе: {Leftover}{Unit}";
    }
}
