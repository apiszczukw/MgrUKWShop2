using MgrUKWShop2.DAL;

namespace MgrUKWShop2.Infrastructure
{
    public class CartManager : ICartManager
    {
        public void AddToCart(ISession session, int filmId, FilmsContext db)
        {
            throw new NotImplementedException();
        }

        public int GetCartQuantity(ISession session)
        {
            var cart = GetItems(session);
            return cart.Sum(i => i.Quantity);
        }

        public decimal GetCartValue(ISession session)
        {
            var cart = GetItems(session);
            return cart.Sum(i => i.Value);
        }

        public List<CartItem> GetItems(ISession session)
        {
            var cart = SessionHelper.DeserializeFromJson<List<CartItem>>(session, Consts.CartSessionKey);

            if (cart == null) cart = new List<CartItem>();

            return cart;
        }

        public int RemoveFromCart(ISession session, int id)
        {
            throw new NotImplementedException();
        }
    }
}
