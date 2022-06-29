using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBurger.microservice.Products.Library.Contract.DTO
{
    public class ProductChangedDTO
    {
        public ProductStateDTO State { get; set; }
        public ProductDTO Product { get; set; }
    }

}
