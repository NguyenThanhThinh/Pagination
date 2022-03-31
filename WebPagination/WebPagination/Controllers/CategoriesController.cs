using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebPagination.Models;
using WebPagination.ViewModels.Categories;

namespace WebPagination.Controllers
{
    public class CategoriesController : Controller
    {
        public ActionResult Index(int? page,string search)
        {
            var listCategory = GetCategories().Where(n=>n.Name == search).ToList();
            var pager = new Pager(listCategory.Count(), page);

            var viewModel = new IndexCategoryViewModel
            {
                Items = listCategory.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                Pager = pager
            };

            return View(viewModel);
        }

        private List<Category> GetCategories()
        {
            var caterories = new List<Category>();

            for (int i = 0; i < 200; i++)
            {
                var item = new Category();
                item.Id = i + 1;
                item.Name = $"Category {i + 1}";

                caterories.Add(item);
            }
            return caterories;
        }
    }
}