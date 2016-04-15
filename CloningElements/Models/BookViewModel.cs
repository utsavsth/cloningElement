using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloningElements.Models
{
    public class BookViewModel
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

    public class OrderViewModel
    {
        public OrderViewModel()
        {
            Categories = new List<CategoryViewModel>();
        }
        public string Name { get; set; }

        public List<CategoryViewModel> Categories { get; set; }
    }

    public class CategoryViewModel
    {
        public CategoryViewModel()
        {
            Subcategories = new List<SubCategoryViewModel>();
        }
        public string Name { get; set; }
        public List<SubCategoryViewModel> Subcategories { get; set; }
    }

    public class SubCategoryViewModel
    {
        public SubCategoryViewModel()
        {
            Products = new List<ProductViewModel>();
        }
        public string Name { get; set; }
        public List<ProductViewModel> Products { get; set; }
        public string PreviousFieldId { get; set; }
    }

    public class ProductViewModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string PreviousFieldId { get; set; }
    }
}