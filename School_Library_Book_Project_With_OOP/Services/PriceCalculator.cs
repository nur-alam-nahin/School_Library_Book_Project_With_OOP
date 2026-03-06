using School_Library_Book_Project_With_OOP.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Library_Book_Project_With_OOP.Services
{
    abstract class PriceCalculator
    {
        protected Book _book;

        protected PriceCalculator(Book book)
        {
            _book = book;
        }

        public abstract double calculateFinalPrice();
    }
}
