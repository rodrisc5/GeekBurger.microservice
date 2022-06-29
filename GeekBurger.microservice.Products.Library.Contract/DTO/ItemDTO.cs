using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBurger.microservice.Products.Library.Contract.DTO
{
    public class ItemDTO
    {
        public Guid ItemId { get; set; }
        public string Name { get; set; }
    }

}
