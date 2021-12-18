using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JeanStationModels
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category category { get; set; }
        public Section section { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int Discount { get; set; }
        public int Quantity { get; set; }

    }

    public enum Category
    {
        Pants,
        Shirt,
        Shoes,
        Tshirt,
        Blouses
    }

    public enum Section
    {
        Men,
        Women,
        Boy,
        Girl
    }
}
