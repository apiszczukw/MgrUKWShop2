
using MgrUKWShop2.DAL;
using Microsoft.AspNetCore.Mvc;

namespace MgrUKWShop2.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        FilmsContext db;

        public MenuViewComponent(FilmsContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = db.Categories.ToList();

            return await Task.FromResult(View("_Menu", categories));
        }
    }
}
