using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;




namespace Website2.Website.Models
{
    public class Product
    {
        public string color {get; set;}
        public string category { get; set; }
        public string type { get; set; }

    //     public override string ToString()
    //     {
    //         JsonSerializer.Serialize<Product>(this);
    //         //return base.ToString();
    //     }
    }
}