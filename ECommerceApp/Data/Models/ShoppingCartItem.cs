using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceApp.Data.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingcartItemId { get; set; }
        public Drink Drink { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
