using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FRONTEND.Models
{
    public class Orderline
    {
        public partial class OrderLine
        {
       
            public int OrderId { get; set; }
            
            public int ProductId { get; set; }
            public int Quantity { get; set; }
           
            public decimal UnitPrice { get; set; }

            
            public virtual Order Order { get; set; }
            
            public virtual Product Product { get; set; }
        }
    }
}
