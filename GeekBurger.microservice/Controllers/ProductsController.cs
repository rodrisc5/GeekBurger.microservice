using GeekBurger.microservice.Products.Library.Contract.DTO;
using Microsoft.AspNetCore.Mvc;

namespace GeekBurger.microservice.Products.API.Controllers
{
    public class ProductsController : Controller
    {


        private IList<ProductDTO> Products = new List<ProductDTO>();


        public ProductsController()
        {
            var paulistaStore = "Paulista";
            var morumbiStore = "Morumbi";

            var beef = new ItemDTO { ItemId = Guid.NewGuid(), Name = "beef" };
            var pork = new ItemDTO { ItemId = Guid.NewGuid(), Name = "pork" };
            var mustard = new ItemDTO { ItemId = Guid.NewGuid(), Name = "mustard" };
            var ketchup = new ItemDTO { ItemId = Guid.NewGuid(), Name = "ketchup" };
            var bread = new ItemDTO { ItemId = Guid.NewGuid(), Name = "bread" };
            var wBread = new ItemDTO { ItemId = Guid.NewGuid(), Name = "whole bread" };

            Products = new List<ProductDTO>()
    {
        new ProductDTO { ProductId = Guid.NewGuid(), Name = "Darth Bacon",
            Image = "hamb1.png", StoreName = paulistaStore,
            Items = new List<ItemDTO> {beef, ketchup, bread }
        },
        new ProductDTO { ProductId = Guid.NewGuid(), Name = "Cap. Spork",
            Image = "hamb2.png", StoreName = paulistaStore,
            Items = new List<ItemDTO> { pork, mustard, wBread }
        },
        new ProductDTO { ProductId = Guid.NewGuid(), Name = "Beef Turner",
            Image = "hamb3.png", StoreName = morumbiStore,
            Items = new List<ItemDTO> {beef, mustard, bread }
        }
    };
        }

        [HttpGet("{storename}")]
        public IActionResult GetProductsByStoreName(string storeName)
        {
            var productsByStore = Products.Where(product =>
        product.StoreName == storeName).ToList();

            if (productsByStore.Count <= 0)
                return NotFound();

            return Ok(productsByStore);

        }

    }

}
