using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static FRONTEND.Models.Orderline;

namespace FRONTEND.Models
{
    public class Order
    {
        
            public Order()
            {
                OrderLines = new HashSet<OrderLine>();
            }

            public int Id { get; set; }

            public int UserId { get; set; }

            public DateTimeOffset OrderDate { get; set; }
      
            public virtual ICollection<OrderLine> OrderLines { get; set; }
        
    }
}
