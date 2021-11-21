using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static FRONTEND.Models.Orderline;

namespace FRONTEND.Models
{
    public class Product
    {
        public Product()
        {
            OrderLines = new HashSet<OrderLine>();
        }

        
        public int Id { get; set; }
       
        public string Image { get; set; }
        
        public string Name { get; set; }
       
        public string Description { get; set; }
        
        public decimal Price { get; set; }

        public bool InStock { get; set; }

        
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}

