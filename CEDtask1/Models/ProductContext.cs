using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CEDtask1.Models
{
    public class ProductContext:DbContext
    {
        public ProductContext() : base("dbconn")
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}