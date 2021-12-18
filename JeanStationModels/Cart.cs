using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JeanStationModels
{
    public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string UserId { get; set; }
        public string ItemId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category category { get; set; }
        public Section section { get; set; }
        public string ImageUrl { get; set; }
        public int Discount { get; set; }
        public int Quantity { get; set; }

    }
}
