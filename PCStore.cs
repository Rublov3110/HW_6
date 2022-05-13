using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
    public class PCStore
    {
        private AssortmentProducts _assortmentProducts;
        private ShoppingBasket _shoppingBasket;
        private OrderFormation _orderFormation;

        public PCStore()
        {
            _assortmentProducts = new AssortmentProducts();
            _shoppingBasket = new ShoppingBasket();
            _orderFormation = new OrderFormation();
        }

        public void Run()
        {
            _assortmentProducts.VisualizationProducts();
            _shoppingBasket.Bascet();
            _orderFormation.SetOrder(_assortmentProducts.Products, _shoppingBasket.ProductsUser);
            _orderFormation.Order();
        }
    }
}
