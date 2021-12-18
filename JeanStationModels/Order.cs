using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JeanStationModels
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string UserId { get; set; }
        public string ProductID { get; set; }
        public string Address { get; set; }
        public double Price     { get; set; }
        public DateTime Date { get; set; }
        public Size size { get; set; }
        public Color color { get; set; }
        public Status status { get; set; }
        public string ImageUrl { get; set; }

    }

    public enum Status
    {
        APPROVED,
        DELIVERED,
        SHIPPED
    }

    public enum Size
    {
        S,
        M,
        L
    }

    public enum Color
    {
        Red,
        Green,
        Blue,
        Black
    }
}
