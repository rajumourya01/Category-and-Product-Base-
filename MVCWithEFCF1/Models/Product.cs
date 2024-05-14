using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWithEFCF1.Models
{
    public class Product
    {
        [Key]
        public int Pid { get; set; }
        public string PName { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public byte[] ProductImage { get; set; }
        public string ProductImageName { get; set; }
        public bool Discontinued { get; set; }
        public Category Category { get; set; }
    }
}