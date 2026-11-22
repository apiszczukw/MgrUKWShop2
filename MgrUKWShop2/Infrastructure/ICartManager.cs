using MgrUKWShop2.DAL;

namespace MgrUKWShop2.Infrastructure
{
    public interface ICartManager
    {
        public List<CartItem> GetItems(ISession session);

        public void AddToCart(ISession session, int filmId, FilmsContext db);

        public int RemoveFromCart(ISession session, int id);

        public decimal GetCartValue(ISession session);

        public int GetCartQuantity(ISession session);
    }
}
