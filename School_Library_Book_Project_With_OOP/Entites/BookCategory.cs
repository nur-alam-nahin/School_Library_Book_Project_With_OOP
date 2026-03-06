using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Library_Book_Project_With_OOP.Entites
{
    class BookCategory
    {
        
        private string _categoryName;

        public BookCategory(string categoryName)
        {
            _categoryName = categoryName;
        }

        public string getCategoryName()
        {
            return _categoryName;
        }
    }
}
