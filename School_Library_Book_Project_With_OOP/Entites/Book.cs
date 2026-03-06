using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Library_Book_Project_With_OOP.Entites
{
    class Book
    {
        private string title;
        private double price;
        private BookCategory _category;

        public Book(string title, double price,BookCategory category)
        {
            this.title = title;
            this.price = price;
            _category = category;
        }

        public string getTitle()
        {
            return title;
        }

        public double getPrice()
        {
            return price; 
        }


        public BookCategory getCategory()
        {
            return _category;
        }
    }
}
