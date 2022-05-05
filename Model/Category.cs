using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeSwap.Model
{
    public class Category
    {
        private int idCategory;
        private string categoryName;
        private int idSubCategory;

        public Category() {}

        public Category(int idCategory, string categoryName, int idSubCategory)
        {
            IdCategory = idCategory;
            CategoryName = categoryName;
            IdSubCategory = idSubCategory;
        }

        public int IdCategory { get => idCategory; set => idCategory = value; }

        public string CategoryName { get => categoryName; set => categoryName = value; }

        public int IdSubCategory { get => idSubCategory; set => idSubCategory = value; }
    }
}