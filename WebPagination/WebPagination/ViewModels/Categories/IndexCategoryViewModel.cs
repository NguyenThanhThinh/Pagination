using System.Collections.Generic;
using WebPagination.Models;

namespace WebPagination.ViewModels.Categories
{
    public class IndexCategoryViewModel
    {
        public IEnumerable<Category> Items { get; set; }
        public Pager Pager { get; set; }
    }
}