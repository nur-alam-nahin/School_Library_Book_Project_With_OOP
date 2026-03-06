using School_Library_Book_Project_With_OOP.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Library_Book_Project_With_OOP.Services
{
    class PrintedBookCalculator : PriceCalculator
    {
        public PrintedBookCalculator(Book book) : base(book)
        {

        }
        public override double calculateFinalPrice()
        {
            double maintenancCharge = 50;
            return maintenancCharge + _book.getPrice();

        }
    }
}
