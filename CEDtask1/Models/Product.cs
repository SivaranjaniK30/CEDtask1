using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CEDtask1.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Product Name is Required")]
        public string Product_Name { get; set; }

        [Required(ErrorMessage = "Product Price is Required")]
        public string Price { get; set; }

        [Required(ErrorMessage = "Product Description is Required")]
        public string Decription { get; set; }

        [Required(ErrorMessage = "Product Type is Required")]
        public string ProductType { get; set; }
      
        public bool isActive { get; set; }

    }
}