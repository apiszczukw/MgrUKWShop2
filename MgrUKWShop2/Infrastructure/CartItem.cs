using MgrUKWShop2.Models;

namespace MgrUKWShop2.Infrastructure
{
    public class CartItem
    {
        public Film Film { get; set; }

        public int Quantity { get; set; }

        public decimal Value { get; set; }
    }
}
